using System.Diagnostics;
using System.Windows.Forms;

namespace MyBagelShop
{
    public partial class MainBagelForm : Form
    {
        //Array for the workshops
        public static string[] BagelTypes { get; set; } = { "Plain", "Whole Wheat", "Garlic",
                                                            "Toasted", "Onion", "French Toast", "Multigrain",
                                                           "Cinnamon Raisin", "Blueberry", "Chocolate Chip", 
                                                            "Salt", "Poppy Seed", "Pumpernickel"};

        // array for type of bagel costs
        public static decimal[] BagelTypeCosts { get; set; } = {2m, 2.2m, 2.4m, 2.5m, 2.65m, 2.75m, 2.8m, 2.9m, 2.8m,
                                                                3m, 2.75m, 2.6m, 3.1m};
        // array with 5 different sizes of bagels
        public static string[] BagelSize { get; set; } = {"Small", "Medium", "Regular", "Large", "Extra-Large" };

        //Array for the Starting Stock
        public static int[,] StockAvailable { get; set; } =  {  { 10, 20, 25, 29, 30},
                                                                { 14, 17, 6, 23, 5},
                                                                { 25, 10, 23, 12, 11},
                                                                { 17, 16, 15, 33, 30},
                                                                { 20, 45, 30, 35, 45},
                                                                { 22, 21, 27, 35, 10},
                                                                { 11, 20, 8, 15, 20},
                                                                { 25, 30, 13, 20, 25},
                                                                { 5, 9, 11, 18, 22},
                                                                { 4, 6, 8, 10, 10},
                                                                { 20, 20, 20, 20, 20},
                                                                { 20, 20, 20, 20, 20},
                                                                { 20, 20, 20, 20, 20}};
        // array for bagel size costs
        public static decimal[] BagelSizeCosts { get; set; } = {0.00m, 0.2m, 0.4m, 0.6m, 1m};

        // list to store current basket details
        List<int[]> Basket = new List<int[]>();

        // list to store what type of bagel being sold
        List<string[]> SalesData = new List<string[]>();
 
        List<int[]> AllTransactions { get; set; } = new List<int[]>();

        int QuantityOrderedCount;

        public MainBagelForm()
        {
            InitializeComponent();
        }

        private void CompleteOrderButton_Click(object sender, EventArgs e)
        {

        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {

        }

        private void MainBagelForm_Load(object sender, EventArgs e)
        {

        }

        private void BagelTypeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PriceDisplayGroupBox.Visible = true;
            if(SizeListBox.SelectedIndex != -1)
            {
                // handle any potential error if other index not selected
                this.OptionSelectedPriceTextBox.Text = (BagelTypeCosts[BagelTypeListBox.SelectedIndex] +
                    BagelSizeCosts[SizeListBox.SelectedIndex]).ToString("C");
                // only display quantity when other values selected
                this.OrderQuantityGroupBox.Visible = true;
            }
            else
            {
                this.OptionSelectedPriceTextBox.Text = (BagelTypeCosts[BagelTypeListBox.SelectedIndex]).ToString("C");
            }
        }

        private void SizeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PriceDisplayGroupBox.Visible = true;
            if (BagelTypeListBox.SelectedIndex != -1)
            {
                this.OptionSelectedPriceTextBox.Text = (BagelTypeCosts[BagelTypeListBox.SelectedIndex] +
                    BagelSizeCosts[SizeListBox.SelectedIndex]).ToString("C");
                // only display quantity when other values selected
                this.OrderQuantityGroupBox.Visible = true;
            }
            else
            {
                this.OptionSelectedPriceTextBox.Text = (BagelSizeCosts[SizeListBox.SelectedIndex]).ToString("C");
            }
        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            if(!int.TryParse(QuantityTextBox.Text, out QuantityOrderedCount) ||
                         QuantityOrderedCount <= 0)
            {
                this.OptionSelectedPriceTextBox.Text = (BagelTypeCosts[BagelTypeListBox.SelectedIndex] +
        BagelSizeCosts[SizeListBox.SelectedIndex]).ToString("C");
            }
            else
            {
                this.OptionSelectedPriceTextBox.Text = ((BagelTypeCosts[BagelTypeListBox.SelectedIndex] +
        BagelSizeCosts[SizeListBox.SelectedIndex]) * QuantityOrderedCount).ToString("C");
            }
            
        }
    }
}