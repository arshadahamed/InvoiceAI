using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceAI.Custom_Control
{
    public partial class btnUser : UserControl
    {
        public btnUser()
        {
            InitializeComponent();
        }

        public string UserID { get; set; }
        public string UserType
        {
            get { return lblType.Text; }
            set { lblType.Text = value; }
        }

        public string UserName
        {
            get { return lblUName.Text; }
            set { lblUName.Text = value; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.lblUserLo.Text = UserName;
            login.lblUsType.Text = UserType;
            login.Show();
            ((Form)this.TopLevelControl).Close();
        }

        private void lblUName_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.lblUserLo.Text = UserName;
            login.lblUsType.Text = UserType;
            login.Show();
            ((Form)this.TopLevelControl).Close();
        }
    }
}
