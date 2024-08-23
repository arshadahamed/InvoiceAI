using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace InvoiceAI
{
    public partial class Login : Form
    {
        private DbHelper dbHelper;

        public Login()
        {
            InitializeComponent();
            txtPassword.Validating += txtPassword_Validating;
            txtPassword.Validated += txtPassword_Validated;

            string server = "127.0.0.1";
            string port = "3306"; 
            string database = "invoiceai";
            string user = "root";
            string password = "";


            dbHelper = new DbHelper(server, port, database, user, password);
        }

        public string UName { get; set; }

        public string USType
        {
            get { return lblUsType.Text; }
            set { lblUsType.Text = value; }
        }

        public string UserName
        {
            get { return lblUserLo.Text; }
            set { lblUserLo.Text = value; }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            UName = lblUserLo.Text;
            USType = lblUsType.Text;
            WarningMessageShow();
        }

        public void Caps()
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                label7.Text = "Caps Lock On";
                label7.Visible = true;
                label7.ForeColor = Color.Lime;
            }
            else
            {
                label7.Visible = false;
            }
        }

        private void WarningMessageShow()
        {
            DateTime expDate = Convert.ToDateTime("12/30/2024");
            DateTime currentDate = DateTime.Now.Date;
            double nrOfDays = (expDate - currentDate).TotalDays;

            if (nrOfDays <= 0)
            {
                MessageBox.Show("Your Application is Expired. And Please Contact Us!", "Software Expired", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            new UserForm().Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.Focus();
        }

        private void lblCreateAcc_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Close();
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = checkbxShowPas.Checked ? '\0' : '*';
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            Caps();

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.F1)
            {
                btnLogin.PerformClick();
            }
        }

        private ErrorProvider errorProvider = new ErrorProvider();

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPassword, "Password Box cannot be empty!");
            }
        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(txtPassword, "");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string hashedPassword = HashPassword(txtPassword.Text);
            string query1 = "SELECT username, password FROM users WHERE username=@username AND password=@password";

            DataTable result = dbHelper.ExecuteQuery(query1, new MySqlParameter("@username", lblUserLo.Text), new MySqlParameter("@password", hashedPassword));

            DateTime expDate = Convert.ToDateTime("12/03/2024");
            DateTime currentDate = DateTime.Now.Date;
            double nrOfDays = (expDate - currentDate).TotalDays;

            if (nrOfDays > 0)
            {
                if (result.Rows.Count > 0)
                {
                    string username = lblUserLo.Text;
                    string usertype = lblUsType.Text;

                    Dashboard welcome = new Dashboard
                    {
                        DUserName = username
                    };

                    welcome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Text = "";
                    txtPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("Your Application is Expired. And Please Contact Us!", "Software Expired", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                var builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
