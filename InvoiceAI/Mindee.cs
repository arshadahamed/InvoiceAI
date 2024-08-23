using System;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mindee;
using Mindee.Input;
using Mindee.Product.Invoice;
using Newtonsoft.Json.Linq;

namespace InvoiceAI
{
    public partial class Mindee : UserControl
    {
        private string server = "127.0.0.1";
        private string port = "3306";
        private string database = "invoiceai";
        private string user = "root";
        private string password = "";
        private bool isOcrProcessed = false;
        private ocrloading loadingOverlay;

       
        public Mindee()
        {
            InitializeComponent();
            loadingOverlay = new ocrloading();
        }

        private void Mindee_Load(object sender, EventArgs e)
        {
            dgvItems.Columns.Add("Description", "Description");
            dgvItems.Columns.Add("ProductCode", "Product code");
            dgvItems.Columns.Add("Quantity", "Quantity");
            dgvItems.Columns.Add("TaxAmount", "Tax Amount");
            dgvItems.Columns.Add("TaxRate", "Tax Rate (%)");
            dgvItems.Columns.Add("TotalAmount", "Total Amount");
            dgvItems.Columns.Add("UnitPrice", "Unit Price");

            ClearAll();
        }

        private void ClearAll()
        {
            lblInvoiceNumber.Text = "";
            lblPurchaseDate.Text = "";
            lblDueDate.Text = "";
            lblTotalAmount.Text = "";
            lblTotalNetAmount.Text = "";
            lblPurchaseOrder.Text = "";
            lblSupplierName.Text = "";
            lblCustomerName.Text = "";
            lblCustomerAddress.Text = "";
            dgvItems.Rows.Clear();
            pbUpload.Image = null;
            btnOCRMindee.Enabled = false;
            isOcrProcessed = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.pdf;*)|*.jpg;*.jpeg;*.png;*.pdf;*|All Files(*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    string imageSavePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "invoices", Path.GetFileName(imageLocation));


                    if (File.Exists(imageSavePath))
                    {
                        MessageBox.Show("An image with the same name already exists. Please rename the file and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    pbUpload.ImageLocation = imageLocation;
                    File.Copy(imageLocation, imageSavePath, true);
                    MessageBox.Show("Image saved at: " + imageSavePath, "Image Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnOCRMindee.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetJsonSavePath(string imagePath)
        {
            string directory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "ocrdata");
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string fileName = Path.GetFileNameWithoutExtension(imagePath) + ".json";
            return Path.Combine(directory, fileName);
        }

        private async void btnOCRMindee_Click(object sender, EventArgs e)
        {
            if (pbUpload.ImageLocation == null)
            {
                MessageBox.Show("No image detected. Please upload an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string imageSavePath = pbUpload.ImageLocation;
            string jsonSavePath = GetJsonSavePath(imageSavePath);

            loadingOverlay.Show();

            await ProcessOCR(imageSavePath, jsonSavePath);
            DisplayInvoiceData(jsonSavePath);

            loadingOverlay.Hide();

            isOcrProcessed = true;
        }

        private async Task ProcessOCR(string filePath, string savePath)
        {
            string apiKey = "06793c2fcaff2ad21d4b800ef611ca9c";

            MindeeClient mindeeClient = new MindeeClient(apiKey);

            var inputSource = new LocalInputSource(filePath);

            var response = await mindeeClient.ParseAsync<InvoiceV4>(inputSource);

            var jsonOutput = Newtonsoft.Json.JsonConvert.SerializeObject(response.Document);

            File.WriteAllText(savePath, jsonOutput);

            MessageBox.Show("OCR processing completed. JSON file saved at: " + savePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DisplayInvoiceData(string jsonFilePath)
        {
            try
            {
                string jsonData = File.ReadAllText(jsonFilePath);
                JObject invoiceData = JObject.Parse(jsonData);

                var prediction = invoiceData["Inference"]?["Pages"]?[0]?["Prediction"];

                lblInvoiceNumber.Text = prediction?["InvoiceNumber"]?["Value"]?.ToString() ?? "N/A";
                lblPurchaseDate.Text = prediction?["Date"]?["Value"]?.ToString() ?? "N/A";
                lblDueDate.Text = prediction?["DueDate"]?["Value"]?.ToString() ?? "N/A";
                lblTotalAmount.Text = prediction?["TotalAmount"]?["Value"]?.ToString() ?? "N/A";
                lblTotalNetAmount.Text = prediction?["TotalNet"]?["Value"]?.ToString() ?? "N/A";

                var referenceNumbers = prediction?["ReferenceNumbers"] as JArray;
                if (referenceNumbers != null && referenceNumbers.Count > 0)
                {
                    lblPurchaseOrder.Text = referenceNumbers[0]["Value"]?.ToString() ?? "N/A";
                }
                else
                {
                    lblPurchaseOrder.Text = "N/A";
                }

                lblSupplierName.Text = prediction?["SupplierName"]?["Value"]?.ToString() ?? "N/A";
                lblCustomerName.Text = prediction?["CustomerName"]?["Value"]?.ToString() ?? "N/A";
                lblCustomerAddress.Text = prediction?["CustomerAddress"]?["Value"]?.ToString() ?? "N/A";

                dgvItems.Rows.Clear();
                var lineItems = prediction?["LineItems"] as JArray;
                if (lineItems != null)
                {
                    foreach (var item in lineItems)
                    {
                        dgvItems.Rows.Add(
                            item["Description"]?.ToString() ?? "N/A",
                            item["ProductCode"]?.ToString() ?? "N/A",
                            item["Quantity"]?.ToString() ?? "N/A",
                            item["TaxAmount"]?.ToString() ?? "N/A",
                            item["TaxRate"]?.ToString() ?? "N/A",
                            item["TotalAmount"]?.ToString() ?? "N/A",
                            item["UnitPrice"]?.ToString() ?? "N/A"
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred while displaying data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveDataToDatabase()
        {
            string connectionString = $"Server={server};Port={port};Database={database};Uid={user};Pwd={password};";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Invoices (InvoiceNumber, PurchaseDate, DueDate, TotalAmount, TotalNetAmount, PurchaseOrder, SupplierName, CustomerName, CustomerAddress, imagePath, ocrPath) VALUES (@InvoiceNumber, @PurchaseDate, @DueDate, @TotalAmount, @TotalNetAmount, @PurchaseOrder, @SupplierName, @CustomerName, @CustomerAddress, @ImagePath, @OcrPath); SELECT LAST_INSERT_ID();", conn))
                {
                    cmd.Parameters.AddWithValue("@InvoiceNumber", lblInvoiceNumber.Text);
                    cmd.Parameters.AddWithValue("@PurchaseDate", ParseDate(lblPurchaseDate.Text));
                    cmd.Parameters.AddWithValue("@DueDate", ParseDate(lblDueDate.Text));
                    cmd.Parameters.AddWithValue("@TotalAmount", ParseDecimal(lblTotalAmount.Text));
                    cmd.Parameters.AddWithValue("@TotalNetAmount", ParseDecimal(lblTotalNetAmount.Text));
                    cmd.Parameters.AddWithValue("@PurchaseOrder", lblPurchaseOrder.Text);
                    cmd.Parameters.AddWithValue("@SupplierName", lblSupplierName.Text);
                    cmd.Parameters.AddWithValue("@CustomerName", lblCustomerName.Text);
                    cmd.Parameters.AddWithValue("@CustomerAddress", lblCustomerAddress.Text);
                    cmd.Parameters.AddWithValue("@ImagePath", pbUpload.ImageLocation);
                    cmd.Parameters.AddWithValue("@OcrPath", GetJsonSavePath(pbUpload.ImageLocation));

                    int invoiceID = Convert.ToInt32(cmd.ExecuteScalar());

                    foreach (DataGridViewRow row in dgvItems.Rows)
                    {
                        if (row.IsNewRow) continue;

                        using (MySqlCommand lineCmd = new MySqlCommand("INSERT INTO invoicelineitems (InvoiceID, Description, ProductCode, Quantity, TaxAmount, TaxRate, TotalAmount, UnitPrice) VALUES (@InvoiceID, @Description, @ProductCode, @Quantity, @TaxAmount, @TaxRate, @TotalAmount, @UnitPrice)", conn))
                        {
                            lineCmd.Parameters.AddWithValue("@InvoiceID", invoiceID);
                            lineCmd.Parameters.AddWithValue("@Description", row.Cells["Description"].Value?.ToString() ?? "N/A");
                            lineCmd.Parameters.AddWithValue("@ProductCode", row.Cells["ProductCode"].Value?.ToString() ?? "N/A");
                            lineCmd.Parameters.AddWithValue("@Quantity", ParseDecimal(row.Cells["Quantity"].Value?.ToString()));
                            lineCmd.Parameters.AddWithValue("@TaxAmount", ParseDecimal(row.Cells["TaxAmount"].Value?.ToString()));
                            lineCmd.Parameters.AddWithValue("@TaxRate", ParseDecimal(row.Cells["TaxRate"].Value?.ToString()));
                            lineCmd.Parameters.AddWithValue("@TotalAmount", ParseDecimal(row.Cells["TotalAmount"].Value?.ToString()));
                            lineCmd.Parameters.AddWithValue("@UnitPrice", ParseDecimal(row.Cells["UnitPrice"].Value?.ToString()));

                            lineCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        private DateTime ParseDate(string date)
        {
            if (DateTime.TryParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
            {
                return parsedDate;
            }
            return DateTime.MinValue;
        }

        private decimal ParseDecimal(string value)
        {
            if (decimal.TryParse(value, out decimal parsedDecimal))
            {
                return parsedDecimal;
            }
            return 0;
        }

        private void btnMigrate_Click(object sender, EventArgs e)
        {
            if (!isOcrProcessed)
            {
                MessageBox.Show("OCR processing has not been completed. Please complete the OCR process before migrating data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                SaveDataToDatabase();
                MessageBox.Show("Data migration completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred during data migration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearAll();
        }
    }
}