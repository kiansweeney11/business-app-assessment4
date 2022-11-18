using System;
using System.Collections;
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
    public partial class ManagementSummaryForm : Form
    {
        public ManagementSummaryForm()
        {
            InitializeComponent();
        }

        public void DisplayManagementSummaryForm(String Time, List<String> Vals)
        {
            DateSumTextBox.Text = Time;
            for(int i = 0; i < Vals.Count; i++)
            {
                StockCountListBox.Items.Add(Vals[i]);
            }
            this.Text = "Daily Items Sold Breakdown per Item";
        }
    }
}
