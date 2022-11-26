using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        public void DisplayCompanyReceipt(int ID, String Date, Decimal OverallPrice, String Details)
        {
            UniqueIDReceiptTextBox.Text = "Sale ID: " + ID.ToString();
            ReceiptDateLabelTextBox.Text = Date;
            String[] Vals = Details.Split("\n");
            //Debug.WriteLine(Vals.Length);
            for (int i = 0; i < Vals.Length - 1; i++)
            {
                //String string1 = Vals[i].ToString();
                //String[] lst1 = string1.Split("\t");
                // tried padding right after splitting on tab for alignment didnt work so left it as it was
                ItemsReceiptListBox.Items.Add(Vals[i]);
            }
            ReceiptFinalPriceTextBox.Text = "Total Cost is: " + OverallPrice.ToString("C");
        }
    }
}
