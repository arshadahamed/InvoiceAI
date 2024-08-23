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
    public partial class InvoiceLine : UserControl
    {
        public InvoiceLine()
        {
            InitializeComponent();
        }

        public string InvID
        {
            get { return lblInvID.Text; }
            set { lblInvID.Text = value; }
        }

        public string InvNo
        {
            get { return lblInvNo.Text; }
            set { lblInvNo.Text = value; }
        }
        public string InvSup
        {
            get { return lblSupplier.Text; }
            set { lblSupplier.Text = value; }
        }

        public string InvDate
        {
            get { return lblPDate.Text; }
            set { lblPDate.Text = value; }
        }

        public string InvTotal
        {
            get { return lblTotalAmount.Text; }
            set { lblTotalAmount.Text = value; }
        }

        private void InvoiceLine_Load(object sender, EventArgs e)
        {

        }
    }
}
