using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceAI
{
    public partial class frmRegister : Form
    {
        private DbHelper dbHelper;
        private ErrorProvider errorProvider = new ErrorProvider();

        public frmRegister()
        {
            InitializeComponent();
            txtPassword.Validating += txtPassword_Validating;
            txtComPassword.Validating += txtComPassword_Validating;
            txtUsername.Validating += txtUsername_Validating;

            string server = "127.0.0.1";
            string port = "3306";
            string database = "invoiceai";
            string user = "root";
            string password = "";

            dbHelper = new DbHelper(server, port, database, user, password);
        }

        public void Caps()
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                label14.Text = "Caps Lock On";
                label14.Visible = true;
                label14.ForeColor = System.Drawing.Color.DarkRed;
            }
            else
            {
                label14.Visible = false;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
            txtUsername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new UserForm().Show();
            this.Hide();
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtComPassword.PasswordChar = '*';
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            Caps();
        }

        private void txtComPassword_KeyDown(object sender, KeyEventArgs e)
        {
            Caps();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (txtPassword.Text == txtComPassword.Text)
                {
                    try
                    {
                        string hashedPassword = HashPassword(txtPassword.Text);
                        string orgId = Guid.NewGuid().ToString();

                        string query1 = $"INSERT INTO users (username, password, role, org_id) VALUES ('{txtUsername.Text}', '{hashedPassword}', 'Admin', '{orgId}')";
                        dbHelper.ExecuteNonQuery(query1);

                        string query2 = $"INSERT INTO organization (org_id, organization_name, register_number, address, contact_number, email, database_type, system_provider) " +
                                        $"VALUES ('{orgId}', '{tbOrgName.Text}', '{tbOrgRegNo.Text}', '{tbOrgAddress.Text}', '{tbOrgContact.Text}', '{tbOrgContactEmail.Text}', '{cbDBMS.Text}', '{cbSystemProvider.Text}')";
                        dbHelper.ExecuteNonQuery(query2);

                        txtUsername.Text = "";
                        txtPassword.Text = "";
                        txtComPassword.Text = "";
                        tbOrgName.Text = "";
                        tbOrgRegNo.Text = "";
                        tbOrgAddress.Text = "";
                        tbOrgContact.Text = "";
                        tbOrgContactEmail.Text = "";
                        cbDBMS.Text = "";
                        cbSystemProvider.Text = "";

                        MessageBox.Show("Your account has been successfully created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match, please enter again", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Text = "";
                    txtComPassword.Text = "";
                    txtPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please fill in all required fields", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtUsername, "Username cannot be empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtUsername, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPassword, "Password cannot be empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtPassword, null);
            }
        }

        private void txtComPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtComPassword.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtComPassword, "Confirm Password cannot be empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtComPassword, null);
            }
        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(txtPassword, "");
        }

        private void txtComPassword_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(txtComPassword, "");
        }

        private void gbOrganizationDetail_Enter(object sender, EventArgs e)
        {

        }
    }
}
