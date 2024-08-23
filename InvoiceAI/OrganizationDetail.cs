using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InvoiceAI
{
    public partial class OrganizationDetail : UserControl
    {
        private DbHelper dbHelper;
        private string userName;
        private string userId;

        public OrganizationDetail(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            InitializeDbHelper();
            LoadUserId();
            LoadOrganizationDetails();
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

        private void LoadUserId()
        {
            string query = "SELECT user_id FROM users WHERE username = @userName";
            DataTable table = dbHelper.ExecuteQuery(query, new MySqlParameter("@userName", userName));

            if (table.Rows.Count == 1)
            {
                userId = table.Rows[0]["user_id"].ToString();
            }
            else
            {
                MessageBox.Show("User ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadOrganizationDetails()
        {
            string query = @"
                SELECT o.organization_name, o.register_number, o.address, o.contact_number, o.email, o.database_type, o.system_provider 
                FROM organization o
                JOIN users u ON u.org_id = o.org_id
                WHERE u.user_id = @userId";
            LoadOrganization(query);
        }

        public void LoadOrganization(string query)
        {
            try
            {
                DataTable table = dbHelper.ExecuteQuery(query, new MySqlParameter("@userId", userId));

                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("No organization details found.");
                    return;
                }

                DataRow row = table.Rows[0];
                tbOrgName.Text = row["organization_name"].ToString();
                tbOrgRegNo.Text = row["register_number"].ToString();
                tbOrgAddress.Text = row["address"].ToString();
                tbOrgContact.Text = row["contact_number"].ToString();
                tbOrgContactEmail.Text = row["email"].ToString();
                cbDBMS.Text = row["database_type"].ToString();
                cbSystemProvider.Text = row["system_provider"].ToString();

               /* MessageBox.Show("Organization details fetched successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            tbOrgName.Text = "";
            tbOrgRegNo.Text = "";
            tbOrgAddress.Text = "";
            tbOrgContact.Text = "";
            tbOrgContactEmail.Text = "";
            cbDBMS.Text = "";
            cbSystemProvider.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(userName))
            {
                try
                {
                    string query = @"
                        UPDATE organization
                        SET organization_name = @orgName, 
                            register_number = @regNo, 
                            address = @address, 
                            contact_number = @contactNo, 
                            email = @email, 
                            database_type = @dbType, 
                            system_provider = @systemProvider
                        WHERE org_id = (
                            SELECT org_id 
                            FROM users 
                            WHERE user_id = @userId
                        )";

                    dbHelper.ExecuteNonQuery(query,
                        new MySqlParameter("@orgName", tbOrgName.Text),
                        new MySqlParameter("@regNo", tbOrgRegNo.Text),
                        new MySqlParameter("@address", tbOrgAddress.Text),
                        new MySqlParameter("@contactNo", tbOrgContact.Text),
                        new MySqlParameter("@email", tbOrgContactEmail.Text),
                        new MySqlParameter("@dbType", cbDBMS.Text),
                        new MySqlParameter("@systemProvider", cbSystemProvider.Text),
                        new MySqlParameter("@userId", userId));

                    ClearFields();
                    MessageBox.Show("Organization details updated successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You do not have permission to update this organization's details.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
