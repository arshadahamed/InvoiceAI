using System;
using System.Drawing;
using System.Windows.Forms;

namespace InvoiceAI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            DisplayWelcome(new welcome());
        }

        public string DUserName
        {
            get { return lblDashUesr.Text; }
            set { lblDashUesr.Text = value; }
        }

        public string DUserType
        {
            get { return lblDashUserType.Text; }
            set { lblDashUserType.Text = value; }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Logout?", "User Logout", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                new UserForm().Show();
                this.Hide();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Close this App?", "Application Close", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnOCR_Click(object sender, EventArgs e)
        {
            DisplayControl(new Mindee(), btnOCR);
        }

        private void btnInventoryDash_Click(object sender, EventArgs e)
        {
            DisplayControl(new OrganizationDetail(lblDashUesr.Text), btnInventoryDash);
        }

        private void DisplayControl(Control control, Button activeButton)
        {
            panelContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContent.Controls.Add(control);

            ResetButtonColors();

            activeButton.BackColor = Color.FromArgb(47, 47, 47);
            activeButton.ForeColor = Color.White;
        }

        private void ResetButtonColors()
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = Color.FromArgb(1, 56, 99);
                    button.ForeColor = Color.White;
                }
            }
        }

        private void btnSettingDash_Click(object sender, EventArgs e)
        {
            DisplayControl(new UserDetails(), btnSettingDash);
        }

        private void btnInvDash_Click(object sender, EventArgs e)
        {
            DisplayControl(new InvoiceList(), btnInvDash);
        }

        private void DisplayWelcome(Control control)
        {
            panelContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContent.Controls.Add(control);

            ResetButtonColors();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayWelcome(new welcome());
        }
    }
}
