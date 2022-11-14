// Name: Kian Sweeney
// ID: 22220670
// Due Date: 25/11/2022
// MS806 - Assignment 4
// Your client MyBagelShop Inc. (MBSI) is a regional chain of gourmet
// bagel bars, whose rapid rate of expansion has meant that the head office
// management team wishes to become more systematic, and
// systems orientated in their business approach.
// Your company has been commissioned to create a well-designed
// electronic point of sale (EPOS) application
// for use by their counter staff in processing customer orders.

using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

        //Array for live count of stock
        const int ROW_SIZE = 13, COLUMN_SIZE = 5;
        public static int[,] OpeningStock = new int[ROW_SIZE, COLUMN_SIZE];

        // array for the starting stock
        // read in if no values for previous closing i.e the start
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

        // file names constants
        const string CLOSINGFILE = "ClosingReport.txt";
        const string ORDERDETAILS = "OrderDetails.txt";

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
            decimal TotalCostOrder = 0.00m;
            String OrderDetailsReceipt = "";
            String DateReceipt;
            int TransactionID;
            CompanyReceipt MyCompanyReceipt = new CompanyReceipt();
            for (int i = 0; i < Basket.Count; i++)
            {
                // get total order cost
                TotalCostOrder += (BagelTypeCosts[Basket[i][0]] + BagelSizeCosts[Basket[i][1]]) * Basket[i][2];
            }
            // get value of each row as per spec
            List<decimal> BasketRowValues = new List<decimal>();
            for (int i = 0; i < Basket.Count; i++)
            {
                // get cost for each line
                decimal TotalCostRow = (BagelTypeCosts[Basket[i][0]] + BagelSizeCosts[Basket[i][1]]) * Basket[i][2];
                BasketRowValues.Add(TotalCostRow);
            }

            DateReceipt = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
            TransactionID = TransactionIDGenerator();
            for(int i = 0; i < BasketRowValues.Count; i++)
            {
                OrderDetailsReceipt += (BagelTypes[Basket[i][0]].ToString()) + "\t" + (BagelSize[Basket[i][1]].ToString()) + "\t" + BasketRowValues[i].ToString("C") + System.Environment.NewLine;
            }
            //Thread.Sleep(2000);
            StreamWriter InputFile = File.AppendText(ORDERDETAILS);
            InputFile.WriteLine(TransactionID);
            InputFile.WriteLine(DateReceipt);
            InputFile.WriteLine(TotalCostOrder);
            InputFile.WriteLine(OrderDetailsReceipt);
            InputFile.Close();
            //Debug.WriteLine(OrderDetailsReceipt);
            MyCompanyReceipt.DisplayCompanyReceipt(TransactionID, DateReceipt, TotalCostOrder, OrderDetailsReceipt);
            MyCompanyReceipt.ShowDialog();
            ClearMainButton_Click(sender, e);
            //if (File.Exists(ORDERDETAILS))
            //{
                //Thread.Sleep(2000);
             //   StreamWriter InputFile = File.AppendText(ORDERDETAILS);
             // /  InputFile.WriteLine(TransactionID);
                //InputFile.WriteLine(DateReceipt);
                //InputFile.WriteLine(OrderDetailsReceipt);
                //InputFile.Close();
                //Debug.WriteLine(OrderDetailsReceipt);
                //MyCompanyReceipt.DisplayCompanyReceipt(TransactionID, DateReceipt, TotalCostOrder, OrderDetailsReceipt);
                //MyCompanyReceipt.ShowDialog();
                //ClearMainButton_Click(sender, e);
            //}
            //else
            //{
            //    MessageBox.Show("Invalid File.", "Info");
            //}
        }

        private int CalculateFileLines()
        {
            // lines count is variable for iterating through
            // this is set as 1 due to it only being used if file does exist
            int LinesCount = 1, TotalLines;
            try
            {
                StreamReader OutputFile = File.OpenText(ORDERDETAILS);
                while (OutputFile.ReadLine() != null)
                {
                    LinesCount++;
                }
                TotalLines = LinesCount;
                OutputFile.Close();
            }
            catch
            {
                // assign zero lines to this
                // an error message is unncessary
                TotalLines = 0;
            }
            return TotalLines;
        }


        private int TransactionIDGenerator()
        {
            int FileLines = CalculateFileLines();
            Random Rand = new Random();
            int rand = Rand.Next(0, 99999);
            if (FileLines >= 1)
            {
                StreamReader OutputFile = File.OpenText(ORDERDETAILS);
                while (OutputFile.ReadLine() != null)
                {
                    for (int i = 1; i <= FileLines; i++)
                    {
                        if (OutputFile.ReadLine() == rand.ToString("D5"))
                        {
                            // call function again to try generate a new unique number
                            TransactionIDGenerator();
                        }
                        else
                        {
                            // generates random number if not on file
                            return rand;
                            OutputFile.Close();
                            break;
                        }
                    }
                }
                OutputFile.Close();
                return rand;
            }
            else
            {
                // handle when file is empty to start
                // if we leave an error message our id wont be generated. this addresses this.
                return rand;
            }
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            // need to ensure values are selected for adding order first
            int BagelTypeSelectedIndex = BagelTypeListBox.SelectedIndex;
            int BagelSizeSelectedIndex = SizeListBox.SelectedIndex;

            // visibility settings mean both need to be selected anyway
            // this just catches anything in case
            if(BagelTypeSelectedIndex == -1)
            {
                MessageBox.Show("Please select a bagel type.", "Info");
            }
            else if(BagelSizeSelectedIndex == -1)
            {
                MessageBox.Show("Please select a bagel size.", "Info");
            }
            else
            {
                if(QuantityOrderedCount > 0)
                {
                    // next, we need to check there is enough stock available
                    // if not we cannot complete the order
                    int StockCurrentAvailable = StockAvailable[BagelTypeSelectedIndex, BagelSizeSelectedIndex];

                    //need to subtract quantity if item is already in the basket
                    for (int i = 0; i < Basket.Count; i++)
                    {
                        if (Basket[i][0] == BagelTypeSelectedIndex && Basket[i][1] == BagelSizeSelectedIndex)
                        {
                            Debug.WriteLine(string.Join("\t", Basket));
                            // basket is arranged as:
                            // index 0 is bagel type
                            // index 1 is bagel size
                            // index 2 is related to overall stock of this combo
                            StockCurrentAvailable -= Basket[i][2];
                        }
                    }

                    if (QuantityOrderedCount > StockCurrentAvailable)
                    {
                        MessageBox.Show("Selected number of Bagel Size/Type out of stock\n" + "Current inputted total: " + QuantityOrderedCount.ToString() + "\n"
                            + "Current stock available: " + StockCurrentAvailable.ToString(),
                            "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.QuantityTextBox.Text = StockCurrentAvailable.ToString();
                        this.QuantityTextBox.Focus();
                    }
                    else
                    {
                        string Quant = QuantityOrderedCount.ToString();
                        string Details = BagelTypes[BagelTypeSelectedIndex].PadRight(20 - BagelTypes[BagelTypeSelectedIndex].Length) + "\t" 
                            +  BagelSize[BagelSizeSelectedIndex].PadRight(15 - BagelSize[BagelSizeSelectedIndex].Length) + "\t" +
                                          Quant.PadRight(40 - (BagelSize[BagelSizeSelectedIndex].Length + BagelTypes[BagelTypeSelectedIndex].Length)) +  "\n";
                        CurrentBasketDetailsListBox.Items.Add(Details);
                        int[] ItemDetails = {BagelTypeSelectedIndex, BagelSizeSelectedIndex, QuantityOrderedCount};
                        Basket.Add(ItemDetails);

                        CompleteOrderButton.Enabled = true;
                        CompleteOrderButton.Focus();

                        UpdateBasketTotals();
                        this.QuantityTextBox.Clear();
                        this.CurrentBasketDetailsListBox.Visible = true;
                        this.CurrentBasketTotalGroupBox.Visible = true;
                    }
                }
                else
                {
                    // already disabled if not valid but check display message box in case
                    MessageBox.Show("Please check value for Quantity." +
                    "\nPlease ensure there are no decimals or negative numbers inputted.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    QuantityTextBox.Focus();
                }
            }
        }

        private void SearchMainForm_Click(object sender, EventArgs e)
        {
            ClearMainButton_Click(sender, e);
            this.BagelTypeGroupBox.Visible = false;
            this.SizeGroupBox.Visible = false;
            this.SearchFormGroupBox.Visible = true;
        }

        private void IDSearchButton_Click(object sender, EventArgs e)
        {
            int TotalLinesFile = CalculateFileLines();
            // clear for next search if user wants to check another ID
            SearchFormListBox.Items.Clear();
            String TransactIDString = this.IDSearchTextBox.Text;
            // transaction ID's are only length 5 and digits so make sure
            // these conditions are met
            if(TransactIDString.Length == 5)
            {
                StreamReader OutputFile = File.OpenText(ORDERDETAILS);
                string LineRead = OutputFile.ReadLine();
                while(LineRead != null)
                {
                    if (LineRead == TransactIDString)
                    {
                        // strings to clarify user what the returned results are
                        SearchResultGroupBox.Visible = true;
                        SearchFormListBox.Items.Add("ID is: " + LineRead);
                        SearchFormListBox.Items.Add("Order Date/Time was: " + OutputFile.ReadLine());
                        SearchFormListBox.Items.Add("Total Cost was: �" + OutputFile.ReadLine());
                        String Details = OutputFile.ReadLine();
                        while(LineRead.Equals(TransactIDString))
                        {
                            String[] words = Details.Split("\t");
                            //Debug.WriteLine(words.Length);
                            if (words.Length > 1)
                            {
                                SearchFormListBox.Items.Add("Order Details were: " + Details);
                                Details = OutputFile.ReadLine();
                            }
                            else
                            {
                                LineRead = Details;
                            }
                        }
                        break;

                    }
                    else
                    {
                        LineRead = OutputFile.ReadLine();
                    }
                }
                OutputFile.Close();
                if (SearchFormListBox.Items.Count < 1)
                {
                    MessageBox.Show("ID inputted not on file", "Info",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.IDSearchTextBox.Focus();
                    // if already visible from an initial check - hide
                    SearchFormListBox.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Please input a valid ID.\nPlease ensure 5 numeric characters are inputted.", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.IDSearchTextBox.Focus();
                // if already visible from an initial check - hide
                SearchFormListBox.Visible = false;
            }

        }

        private void SearchDateButton_Click(object sender, EventArgs e)
        {
            int TotalLinesFile = CalculateFileLines();
            // clear for next search if user wants to check another time
            SearchFormListBox.Items.Clear();
            String Prev = "";
            String TimeString = this.DateSearchTextBox.Text;
            if (TimeString.Length > 5)
            {
                StreamReader OutputFile = File.OpenText(ORDERDETAILS);
                string LineRead = OutputFile.ReadLine();
                while (LineRead != null)
                {
                    if (LineRead == TimeString)
                    {
                        // strings to clarify user what the returned results are
                        SearchResultGroupBox.Visible = true;
                        SearchFormListBox.Items.Add("ID is: " + Prev);
                        SearchFormListBox.Items.Add("Order Date/Time was: " + LineRead);
                        SearchFormListBox.Items.Add("Total Cost was: �" + OutputFile.ReadLine());
                        String Details = OutputFile.ReadLine();
                        while (LineRead.Equals(TimeString))
                        {
                            String[] words = Details.Split("\t");
                            //Debug.WriteLine(words.Length);
                            if (words.Length > 1)
                            {
                                SearchFormListBox.Items.Add("Order Details were: " + Details);
                                Details = OutputFile.ReadLine();
                            }
                            else
                            {
                                Prev = LineRead;
                                LineRead = Details;
                            }
                        }
                        //break;

                    }
                    else
                    {
                        Prev = LineRead;
                        LineRead = OutputFile.ReadLine();
                    }
                }
                OutputFile.Close();
                if (SearchFormListBox.Items.Count < 1)
                {
                    MessageBox.Show("Time of transaction inputted not on file", "Info",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.IDSearchTextBox.Focus();
                    // if already visible from an initial check - hide
                    SearchFormListBox.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Please input a valid date/time.", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.IDSearchTextBox.Focus();
                // if already visible from an initial check - hide
                SearchFormListBox.Visible = false;
            }
        }

        private void MainBagelForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(CLOSINGFILE))
            {
                try
                {
                    StreamReader InputFile = File.OpenText(CLOSINGFILE);
                    //Read File and Save to PlacesAvailable
                    for (int i = 0; i < BagelTypes.Length; i++)
                    {
                        for (int j = 0; j < BagelSize.Length; j++)
                        {
                            string Line = InputFile.ReadLine();

                            if (Line.IndexOf(":") >= 0)
                            {
                                Line = Line.Substring(Line.IndexOf(":") + 1);
                                OpeningStock[i, j] = int.Parse(Line);
                                StockAvailable[i, j] = int.Parse(Line);
                            }

                        }
                    }
                    InputFile.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't read last transaction file from yesterday:" + ex.Message);
                }
            }

            //in case where there is no Closing Stock, the array StockAvailable is taken as Opening Stock
            else
            {
                for (int i = 0; i < BagelTypes.Length; i++)
                {
                    for (int j = 0; j < BagelSize.Length; j++)
                    {
                        OpeningStock[i, j] = StockAvailable[i, j];
                    }
                }
            }
        }

        private void BagelTypeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PriceDisplayGroupBox.Visible = true;
            if(SizeListBox.SelectedIndex != -1 && SizeListBox.SelectedIndex != -1)
            {
                // handle any potential error if other index not selected
                this.OptionSelectedPriceTextBox.Text = (BagelTypeCosts[BagelTypeListBox.SelectedIndex] +
                    BagelSizeCosts[SizeListBox.SelectedIndex]).ToString("C");
                // only display quantity when other values selected
                this.OrderQuantityGroupBox.Visible = true;
            }
            else if (SizeListBox.SelectedIndex == -1 && BagelTypeListBox.SelectedIndex == -1)
            {
                //this.OptionSelectedPriceTextBox.Text = (BagelSizeCosts[SizeListBox.SelectedIndex]).ToString("C");
            }
        }

        private void SizeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PriceDisplayGroupBox.Visible = true;
            if (BagelTypeListBox.SelectedIndex != -1 && SizeListBox.SelectedIndex != -1)
            {
                this.OptionSelectedPriceTextBox.Text = (BagelTypeCosts[BagelTypeListBox.SelectedIndex] +
                    BagelSizeCosts[SizeListBox.SelectedIndex]).ToString("C");
                // only display quantity when other values selected
                this.OrderQuantityGroupBox.Visible = true;
            }
            else if(SizeListBox.SelectedIndex == -1 && BagelTypeListBox.SelectedIndex == -1)
            {
                //this.OptionSelectedPriceTextBox.Text = (BagelSizeCosts[SizeListBox.SelectedIndex]).ToString("C");
            }
        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            if(!int.TryParse(QuantityTextBox.Text, out QuantityOrderedCount) ||
                         QuantityOrderedCount <= 0)
            {
                if (BagelTypeListBox.SelectedIndex != -1 && SizeListBox.SelectedIndex != -1)
                {
                    this.OptionSelectedPriceTextBox.Text = (BagelTypeCosts[BagelTypeListBox.SelectedIndex] +
BagelSizeCosts[SizeListBox.SelectedIndex]).ToString("C");
                    this.ValidAmountLabel.Visible = true;
                    this.AddOrderButton.Enabled = false;
                }
            }
            else
            {
                this.OptionSelectedPriceTextBox.Text = ((BagelTypeCosts[BagelTypeListBox.SelectedIndex] +
        BagelSizeCosts[SizeListBox.SelectedIndex]) * QuantityOrderedCount).ToString("C");
                this.ValidAmountLabel.Visible = false;
                // don't enable unless valid value inputted
                this.AddOrderButton.Enabled = true;
            }
            
        }

        private void UpdateBasketTotals()
        {
            //calculate and display basket totals
            decimal TotalBasketCost = 0;
            int TotalStockOrder = 0;
            for (int i = 0; i < Basket.Count; i++)
            {
                decimal Val = (BagelTypeCosts[Basket[i][0]]) + (BagelSizeCosts[Basket[i][1]]);
                TotalBasketCost += Val * QuantityOrderedCount;

                TotalStockOrder += Basket[i][2];

            }
            TotalSalesOrderTextBox.Text = TotalBasketCost.ToString("C");
            TotalOrderedStockTextBox.Text = TotalStockOrder.ToString();
        }

        private void ClearMainButton_Click(object sender, EventArgs e)
        {
            this.SizeListBox.SelectedIndex = -1;
            this.BagelTypeListBox.SelectedIndex = -1;
            this.QuantityTextBox.Clear();
            this.OptionSelectedPriceTextBox.Clear();
            this.OrderQuantityGroupBox.Visible = false;
            this.PriceDisplayGroupBox.Visible = false;
            this.CurrentBasketTotalGroupBox.Visible = false;
            this.CurrentBasketDetailsListBox.Visible = false;
            this.CurrentBasketDetailsListBox.Items.Clear();
            this.AddOrderButton.Enabled = false;
            this.CompleteOrderButton.Enabled = false;
            this.BagelTypeGroupBox.Visible = true;
            this.SizeGroupBox.Visible = true;
            this.SearchFormGroupBox.Visible = false;
            this.SearchResultGroupBox.Visible = false;
            Basket.Clear();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}