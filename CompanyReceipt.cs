using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBagelShop
{
    public partial class CompanyReceipt : Form
    {
        public CompanyReceipt()
        {
            InitializeComponent();
        }

        private void CompanyReceipt_Load(object sender, EventArgs e)
        {
            //this.UniqueIDReceiptTextBox.Text = "Sale ID " + "";
        }

        public void DisplayCompanyReceipt(int ID, String Date, Decimal OverallPrice, String Details)
        {
            UniqueIDReceiptTextBox.Text = "Sale ID: " + ID.ToString();
            ReceiptDateLabelTextBox.Text = Date;
            ReceiptOrderDetailsTextBox.Text = Details;
            ReceiptFinalPriceTextBox.Text = "Total Cost is: " + OverallPrice.ToString("C");
        }
    }
}
