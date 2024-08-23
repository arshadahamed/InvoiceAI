using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using InvoiceAI.Custom_Control;

namespace InvoiceAI
{
    public partial class InvoiceList : UserControl
    {
        private DbHelper dbHelper;

        public InvoiceList()
        {
            InitializeComponent();
            InitializeDbHelper();
            LoadInvoices();
        }

        private void InitializeDbHelper()
        {
            string server = "127.0.0.1";
            string port = "3306";
            string database = "invoiceai";
            string user = "root";
            string password = "";

            dbHelper = new DbHelper(server, port, database, user, password);
        }

        private void InvoiceList_Load(object sender, EventArgs e)
        {
            LoadInvoices();
        }

        private void LoadInvoices()
        {
            panelInvoice.Controls.Clear();
            string query = "SELECT InvoiceID, InvoiceNumber, PurchaseDate, SupplierName, TotalAmount FROM invoices";
            string result = LoadInvoiceLines(query, panelInvoice);
            panelInvoice.Focus();
        }

        public string LoadInvoiceLines(string query, FlowLayoutPanel panel)
        {
            string ret = "";
            try
            {
                DataTable table = dbHelper.ExecuteQuery(query);

                if (table.Rows.Count == 0)
                {
                    label1.Text = "No Invoices Found!";
                }
                else
                {
                    foreach (DataRow row in table.Rows)
                    {
                        string invID = row["InvoiceID"].ToString();
                        string invNo = row["InvoiceNumber"].ToString();
                        string invDate = row["PurchaseDate"] != DBNull.Value ? Convert.ToDateTime(row["PurchaseDate"]).ToString("yyyy-MM-dd") : string.Empty;
                        string invSup = row["SupplierName"].ToString();
                        string invTotal = row["TotalAmount"].ToString();

                        InvoiceLine invoiceLine = new InvoiceLine
                        {
                            InvID = invID,
                            InvNo = invNo,
                            InvDate = invDate,
                            InvSup = invSup,
                            InvTotal = invTotal
                        };

                        if (!string.IsNullOrEmpty(invID))
                        {
                            panel.Controls.Add(invoiceLine);
                        }
                    }
                    ret = "Data fetched successfully.";
                }
            }
            catch (Exception ex)
            {
                ret = ex.Message;
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        private void InvoiceList_Load_1(object sender, EventArgs e)
        {

        }
    }
}
