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
    public partial class DailySummaryForm : Form
    {
        public DailySummaryForm()
        {
            InitializeComponent();
        }

        public void DisplayDailySummary(int Transactions, Decimal Average, Decimal OverallSales, int BagelsSold)
        {
            BagelsSoldTextBox.Text = BagelsSold.ToString();
            SalesValueTextBox.Text = OverallSales.ToString("C");
            TransactionsTextBox.Text = Transactions.ToString();
            AverageTransactionTextBox.Text = Average.ToString("C");
        }
    }
}
