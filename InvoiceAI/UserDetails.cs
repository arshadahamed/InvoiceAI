using System;
using System.Data;
using System.Windows.Forms;

namespace InvoiceAI
{
    public partial class UserDetails : UserControl
    {
        private DbHelper dbHelper;

        public UserDetails()
        {
            InitializeComponent();
      
            string server = "127.0.0.1";
            string port = "3306"; 
            string database = "invoiceai";
            string user = "root";
            string password = "";


            dbHelper = new DbHelper(server, port, database, user, password);
        }

        void BlindData()
        {

            var dashboard = Application.OpenForms["Dashboard"] as Dashboard;
            if (dashboard != null)
            {
                string userName = dashboard.DUserName;
                string query = $"SELECT user_id, username, password, role, org_id FROM users WHERE username = '{userName}'";


                DataTable userTable = dbHelper.ExecuteQuery(query);

                if (userTable.Rows.Count > 0)
                {
                    DataRow userRow = userTable.Rows[0];
                    lblUserID.Text = userRow["user_id"].ToString();
                    txtUserName.Text = userRow["username"].ToString();
                    txtUserPassword.Text = userRow["password"].ToString();
                    txtUserRole.Text = userRow["role"].ToString();
                    lblOrgID.Text = userRow["org_id"].ToString();

                    // Update dashboard username label
                    dashboard.DUserName = userRow["username"].ToString();
                }
                else
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Dashboard not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserDetails_Load(object sender, EventArgs e)
        {
            BlindData();
        }

        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                var builder = new System.Text.StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btnCLear_Click(object sender, EventArgs e)
        {
            lblUserID.Text = "";
            lblOrgID.Text = "";
            txtUserName.Text = "";
            txtUserPassword.Text = "";
            txtUserRole.Text = "";
        }

        private void btnEditCus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lblUserID.Text))
            {
                int userId = int.Parse(lblUserID.Text);
                string newUserName = txtUserName.Text;
                string newUserRole = txtUserRole.Text;

                UpdateUser(userId, newUserName, newUserRole);
            }
            else
            {
                MessageBox.Show("User ID is empty. Please load a user first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateUser(int userId, string username, string role)
        {
            string query = $"UPDATE users SET username = @username, role = @role WHERE user_id = @user_id";
            try
            {
                int rowsAffected = dbHelper.ExecuteNonQuery(query,
                    new MySql.Data.MySqlClient.MySqlParameter("@username", username),
                    new MySql.Data.MySqlClient.MySqlParameter("@role", role),
                    new MySql.Data.MySqlClient.MySqlParameter("@user_id", userId));

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lblUserID.Text = "";
            lblOrgID.Text = "";
            txtUserName.Text = "";
            txtUserPassword.Text = "";
            txtUserRole.Text = "";
        }
    }
}
