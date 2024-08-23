using InvoiceAI.Custom_Control;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace InvoiceAI
{
    public partial class UserForm : Form
    {
        private DbHelper dbHelper;
        public UserForm()
        {
            InitializeComponent();
            this.KeyPreview = true;

            string server = "127.0.0.1";
            string port = "3306"; 
            string database = "invoiceai";
            string user = "root";
            string password = "";


            dbHelper = new DbHelper(server, port, database, user, password);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Close this App?", "Application Close", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            string query = "SELECT * FROM users";
            string result = userButtons(query, panel1);
            panel1.Focus();
        }

        private void UserForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                // Handle F1 key press if needed
            }
        }

        public string userButtons(string query, FlowLayoutPanel panel)
        {
            string ret = "";
            try
            {
                DataTable table = dbHelper.ExecuteQuery(query);

                if (table.Rows.Count == 0)
                {
                    label1.Text = "No user found, please register.";
                }
                else
                {
                    label1.Text = "Select a user to Login";
                    foreach (DataRow row in table.Rows)
                    {
                        string id = row["user_id"].ToString();
                        string username = row["username"].ToString();
                        string type = row["role"].ToString();

                        btnUser btn = new btnUser
                        {
                            UserName = username,
                            UserType = type
                        };

                        if (!string.IsNullOrEmpty(username))
                        {
                            panel.Controls.Add(btn);
                        }
                    }
                    ret = "Data Fetched Successfully..:)";
                }
            }
            catch (Exception ex)
            {
                ret = ex.Message;
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }
    }
}
