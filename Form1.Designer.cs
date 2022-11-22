namespace MyBagelShop
{
    partial class MainBagelForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainBagelForm));
            this.CompleteOrderButton = new System.Windows.Forms.Button();
            this.BagelTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.BagelPriceLabel = new System.Windows.Forms.Label();
            this.BagelTypeLabel = new System.Windows.Forms.Label();
            this.BagelTypeListBox = new System.Windows.Forms.ListBox();
            this.SearchResultGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchFormListBox = new System.Windows.Forms.ListBox();
            this.SizeGroupBox = new System.Windows.Forms.GroupBox();
            this.LabelAdditionalCost = new System.Windows.Forms.Label();
            this.SizePriceLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.SizeListBox = new System.Windows.Forms.ListBox();
            this.OrderQuantityGroupBox = new System.Windows.Forms.GroupBox();
            this.ValidAmountLabel = new System.Windows.Forms.Label();
            this.NumberSelectedLabel = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.ClearMainButton = new System.Windows.Forms.Button();
            this.OptionSelectedPriceTextBox = new System.Windows.Forms.TextBox();
            this.PriceDisplayGroupBox = new System.Windows.Forms.GroupBox();
            this.CurrentBasketTotalGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalOrderedStockTextBox = new System.Windows.Forms.TextBox();
            this.TotalSalesOrderTextBox = new System.Windows.Forms.TextBox();
            this.TotalBasketCostLabel = new System.Windows.Forms.Label();
            this.TotalQuantityLabel = new System.Windows.Forms.Label();
            this.CurrentBasketDetailsListBox = new System.Windows.Forms.ListBox();
            this.SearchMainForm = new System.Windows.Forms.Button();
            this.SearchFormGroupBox = new System.Windows.Forms.GroupBox();
            this.DateRadioButton = new System.Windows.Forms.RadioButton();
            this.IDRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchPreviousButton = new System.Windows.Forms.Button();
            this.SearchPrevTextBox = new System.Windows.Forms.TextBox();
            this.SearchFormIDLabel = new System.Windows.Forms.Label();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.StockReportButton = new System.Windows.Forms.Button();
            this.SummaryItemButton = new System.Windows.Forms.Button();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.AddOrderToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CompleteToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SearchToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SalesSummaryToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ItemSalesSummary = new System.Windows.Forms.ToolTip(this.components);
            this.StockReportToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ClearToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ExitToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SearchPrevToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BagelTypeGroupBox.SuspendLayout();
            this.SearchResultGroupBox.SuspendLayout();
            this.SizeGroupBox.SuspendLayout();
            this.OrderQuantityGroupBox.SuspendLayout();
            this.PriceDisplayGroupBox.SuspendLayout();
            this.CurrentBasketTotalGroupBox.SuspendLayout();
            this.SearchFormGroupBox.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CompleteOrderButton
            // 
            this.CompleteOrderButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CompleteOrderButton.Enabled = false;
            this.CompleteOrderButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CompleteOrderButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CompleteOrderButton.Location = new System.Drawing.Point(26, 72);
            this.CompleteOrderButton.Name = "CompleteOrderButton";
            this.CompleteOrderButton.Size = new System.Drawing.Size(219, 38);
            this.CompleteOrderButton.TabIndex = 0;
            this.CompleteOrderButton.Text = "&Complete Order";
            this.CompleteToolTip.SetToolTip(this.CompleteOrderButton, "Complete order with items\r\ncurrently in basket.");
            this.CompleteOrderButton.UseVisualStyleBackColor = false;
            this.CompleteOrderButton.Click += new System.EventHandler(this.CompleteOrderButton_Click);
            // 
            // BagelTypeGroupBox
            // 
            this.BagelTypeGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.BagelTypeGroupBox.Controls.Add(this.BagelPriceLabel);
            this.BagelTypeGroupBox.Controls.Add(this.BagelTypeLabel);
            this.BagelTypeGroupBox.Controls.Add(this.BagelTypeListBox);
            this.BagelTypeGroupBox.Location = new System.Drawing.Point(13, 13);
            this.BagelTypeGroupBox.Name = "BagelTypeGroupBox";
            this.BagelTypeGroupBox.Size = new System.Drawing.Size(408, 462);
            this.BagelTypeGroupBox.TabIndex = 1;
            this.BagelTypeGroupBox.TabStop = false;
            this.BagelTypeGroupBox.Text = "Bagel Type Selection";
            // 
            // BagelPriceLabel
            // 
            this.BagelPriceLabel.AutoSize = true;
            this.BagelPriceLabel.Location = new System.Drawing.Point(194, 53);
            this.BagelPriceLabel.Name = "BagelPriceLabel";
            this.BagelPriceLabel.Size = new System.Drawing.Size(59, 28);
            this.BagelPriceLabel.TabIndex = 2;
            this.BagelPriceLabel.Text = "Price";
            // 
            // BagelTypeLabel
            // 
            this.BagelTypeLabel.AutoSize = true;
            this.BagelTypeLabel.Location = new System.Drawing.Point(6, 53);
            this.BagelTypeLabel.Name = "BagelTypeLabel";
            this.BagelTypeLabel.Size = new System.Drawing.Size(116, 28);
            this.BagelTypeLabel.TabIndex = 1;
            this.BagelTypeLabel.Text = "Bagel Type";
            // 
            // BagelTypeListBox
            // 
            this.BagelTypeListBox.FormattingEnabled = true;
            this.BagelTypeListBox.ItemHeight = 28;
            this.BagelTypeListBox.Items.AddRange(new object[] {
            "Plain\t\t€2.00",
            "Whole Wheat\t€2.20",
            "Garlic\t\t€2.40",
            "Toasted\t\t€2.50",
            "Onion\t\t€2.65",
            "French Toast\t€2.75",
            "Multigrain\t€2.80",
            "Cinnamon Raisin\t€2.90",
            "Blueberry\t\t€2.80",
            "Chocolate Chip\t€3.00",
            "Salt\t\t€2.75",
            "Poppy Seed\t€2.60",
            "Pumpernickel\t€3.10"});
            this.BagelTypeListBox.Location = new System.Drawing.Point(6, 84);
            this.BagelTypeListBox.Name = "BagelTypeListBox";
            this.BagelTypeListBox.Size = new System.Drawing.Size(356, 368);
            this.BagelTypeListBox.TabIndex = 0;
            this.BagelTypeListBox.SelectedIndexChanged += new System.EventHandler(this.BagelTypeListBox_SelectedIndexChanged);
            // 
            // SearchResultGroupBox
            // 
            this.SearchResultGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.SearchResultGroupBox.Controls.Add(this.SearchFormListBox);
            this.SearchResultGroupBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchResultGroupBox.Location = new System.Drawing.Point(12, 481);
            this.SearchResultGroupBox.Name = "SearchResultGroupBox";
            this.SearchResultGroupBox.Size = new System.Drawing.Size(694, 256);
            this.SearchResultGroupBox.TabIndex = 12;
            this.SearchResultGroupBox.TabStop = false;
            this.SearchResultGroupBox.Text = "Search Result";
            this.SearchResultGroupBox.Visible = false;
            // 
            // SearchFormListBox
            // 
            this.SearchFormListBox.FormattingEnabled = true;
            this.SearchFormListBox.ItemHeight = 28;
            this.SearchFormListBox.Location = new System.Drawing.Point(20, 54);
            this.SearchFormListBox.Name = "SearchFormListBox";
            this.SearchFormListBox.Size = new System.Drawing.Size(657, 172);
            this.SearchFormListBox.TabIndex = 0;
            // 
            // SizeGroupBox
            // 
            this.SizeGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.SizeGroupBox.Controls.Add(this.LabelAdditionalCost);
            this.SizeGroupBox.Controls.Add(this.SizePriceLabel);
            this.SizeGroupBox.Controls.Add(this.SizeLabel);
            this.SizeGroupBox.Controls.Add(this.SizeListBox);
            this.SizeGroupBox.Location = new System.Drawing.Point(427, 13);
            this.SizeGroupBox.Name = "SizeGroupBox";
            this.SizeGroupBox.Size = new System.Drawing.Size(300, 324);
            this.SizeGroupBox.TabIndex = 2;
            this.SizeGroupBox.TabStop = false;
            this.SizeGroupBox.Text = "Bagel Size Selection";
            // 
            // LabelAdditionalCost
            // 
            this.LabelAdditionalCost.AutoSize = true;
            this.LabelAdditionalCost.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LabelAdditionalCost.Location = new System.Drawing.Point(23, 261);
            this.LabelAdditionalCost.Name = "LabelAdditionalCost";
            this.LabelAdditionalCost.Size = new System.Drawing.Size(256, 28);
            this.LabelAdditionalCost.TabIndex = 3;
            this.LabelAdditionalCost.Text = "Additional Cost is per bagel.";
            // 
            // SizePriceLabel
            // 
            this.SizePriceLabel.AutoSize = true;
            this.SizePriceLabel.Location = new System.Drawing.Point(136, 62);
            this.SizePriceLabel.Name = "SizePriceLabel";
            this.SizePriceLabel.Size = new System.Drawing.Size(158, 28);
            this.SizePriceLabel.TabIndex = 2;
            this.SizePriceLabel.Text = "Additional Cost";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(6, 62);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(50, 28);
            this.SizeLabel.TabIndex = 1;
            this.SizeLabel.Text = "Size";
            // 
            // SizeListBox
            // 
            this.SizeListBox.FormattingEnabled = true;
            this.SizeListBox.ItemHeight = 28;
            this.SizeListBox.Items.AddRange(new object[] {
            "Small\t\t€0.00",
            "Medium\t\t€0.20",
            "Regular\t\t€0.40",
            "Large\t\t€0.60",
            "Extra Large\t€1.00"});
            this.SizeListBox.Location = new System.Drawing.Point(6, 93);
            this.SizeListBox.Name = "SizeListBox";
            this.SizeListBox.Size = new System.Drawing.Size(288, 144);
            this.SizeListBox.TabIndex = 0;
            this.SizeListBox.SelectedIndexChanged += new System.EventHandler(this.SizeListBox_SelectedIndexChanged);
            // 
            // OrderQuantityGroupBox
            // 
            this.OrderQuantityGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.OrderQuantityGroupBox.Controls.Add(this.ValidAmountLabel);
            this.OrderQuantityGroupBox.Controls.Add(this.NumberSelectedLabel);
            this.OrderQuantityGroupBox.Controls.Add(this.QuantityTextBox);
            this.OrderQuantityGroupBox.Location = new System.Drawing.Point(733, 19);
            this.OrderQuantityGroupBox.Name = "OrderQuantityGroupBox";
            this.OrderQuantityGroupBox.Size = new System.Drawing.Size(300, 231);
            this.OrderQuantityGroupBox.TabIndex = 3;
            this.OrderQuantityGroupBox.TabStop = false;
            this.OrderQuantityGroupBox.Text = "Order Quantity";
            this.OrderQuantityGroupBox.Visible = false;
            // 
            // ValidAmountLabel
            // 
            this.ValidAmountLabel.AutoSize = true;
            this.ValidAmountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ValidAmountLabel.Location = new System.Drawing.Point(45, 123);
            this.ValidAmountLabel.Name = "ValidAmountLabel";
            this.ValidAmountLabel.Size = new System.Drawing.Size(193, 75);
            this.ValidAmountLabel.TabIndex = 2;
            this.ValidAmountLabel.Text = "Please ensure there are\r\nno negative numbers \r\nor decimals inputted.";
            this.ValidAmountLabel.Visible = false;
            // 
            // NumberSelectedLabel
            // 
            this.NumberSelectedLabel.AutoSize = true;
            this.NumberSelectedLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumberSelectedLabel.Location = new System.Drawing.Point(6, 49);
            this.NumberSelectedLabel.Name = "NumberSelectedLabel";
            this.NumberSelectedLabel.Size = new System.Drawing.Size(186, 50);
            this.NumberSelectedLabel.TabIndex = 1;
            this.NumberSelectedLabel.Text = "Number of Selected \r\nBagels Ordered:";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(203, 65);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(76, 34);
            this.QuantityTextBox.TabIndex = 0;
            this.QuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuantityTextBox.TextChanged += new System.EventHandler(this.QuantityTextBox_TextChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitButton.Location = new System.Drawing.Point(26, 406);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(219, 34);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "&Exit";
            this.ExitToolTip.SetToolTip(this.ExitButton, "Press to close application.");
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddOrderButton.Enabled = false;
            this.AddOrderButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddOrderButton.Location = new System.Drawing.Point(26, 17);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(219, 34);
            this.AddOrderButton.TabIndex = 5;
            this.AddOrderButton.Text = "&Add to Order";
            this.AddOrderToolTip.SetToolTip(this.AddOrderButton, "Add selected items to basket\r\nand continue shopping.\r\n");
            this.AddOrderButton.UseVisualStyleBackColor = false;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // ClearMainButton
            // 
            this.ClearMainButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClearMainButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClearMainButton.Location = new System.Drawing.Point(26, 351);
            this.ClearMainButton.Name = "ClearMainButton";
            this.ClearMainButton.Size = new System.Drawing.Size(219, 34);
            this.ClearMainButton.TabIndex = 6;
            this.ClearMainButton.Text = "C&lear";
            this.ClearToolTip.SetToolTip(this.ClearMainButton, "Clear / reset form for next order.");
            this.ClearMainButton.UseVisualStyleBackColor = false;
            this.ClearMainButton.Click += new System.EventHandler(this.ClearMainButton_Click);
            // 
            // OptionSelectedPriceTextBox
            // 
            this.OptionSelectedPriceTextBox.Location = new System.Drawing.Point(63, 65);
            this.OptionSelectedPriceTextBox.Name = "OptionSelectedPriceTextBox";
            this.OptionSelectedPriceTextBox.Size = new System.Drawing.Size(150, 34);
            this.OptionSelectedPriceTextBox.TabIndex = 0;
            this.OptionSelectedPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PriceDisplayGroupBox
            // 
            this.PriceDisplayGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.PriceDisplayGroupBox.Controls.Add(this.OptionSelectedPriceTextBox);
            this.PriceDisplayGroupBox.Location = new System.Drawing.Point(427, 343);
            this.PriceDisplayGroupBox.Name = "PriceDisplayGroupBox";
            this.PriceDisplayGroupBox.Size = new System.Drawing.Size(300, 132);
            this.PriceDisplayGroupBox.TabIndex = 7;
            this.PriceDisplayGroupBox.TabStop = false;
            this.PriceDisplayGroupBox.Text = "Selected Combo Price";
            this.PriceDisplayGroupBox.Visible = false;
            // 
            // CurrentBasketTotalGroupBox
            // 
            this.CurrentBasketTotalGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.CurrentBasketTotalGroupBox.Controls.Add(this.TotalOrderedStockTextBox);
            this.CurrentBasketTotalGroupBox.Controls.Add(this.TotalSalesOrderTextBox);
            this.CurrentBasketTotalGroupBox.Controls.Add(this.TotalBasketCostLabel);
            this.CurrentBasketTotalGroupBox.Controls.Add(this.TotalQuantityLabel);
            this.CurrentBasketTotalGroupBox.Location = new System.Drawing.Point(733, 256);
            this.CurrentBasketTotalGroupBox.Name = "CurrentBasketTotalGroupBox";
            this.CurrentBasketTotalGroupBox.Size = new System.Drawing.Size(300, 219);
            this.CurrentBasketTotalGroupBox.TabIndex = 8;
            this.CurrentBasketTotalGroupBox.TabStop = false;
            this.CurrentBasketTotalGroupBox.Text = "Current Basket Total";
            this.CurrentBasketTotalGroupBox.Visible = false;
            // 
            // TotalOrderedStockTextBox
            // 
            this.TotalOrderedStockTextBox.Location = new System.Drawing.Point(129, 60);
            this.TotalOrderedStockTextBox.Name = "TotalOrderedStockTextBox";
            this.TotalOrderedStockTextBox.Size = new System.Drawing.Size(150, 34);
            this.TotalOrderedStockTextBox.TabIndex = 3;
            this.TotalOrderedStockTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalSalesOrderTextBox
            // 
            this.TotalSalesOrderTextBox.Location = new System.Drawing.Point(129, 149);
            this.TotalSalesOrderTextBox.Name = "TotalSalesOrderTextBox";
            this.TotalSalesOrderTextBox.Size = new System.Drawing.Size(150, 34);
            this.TotalSalesOrderTextBox.TabIndex = 2;
            this.TotalSalesOrderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalBasketCostLabel
            // 
            this.TotalBasketCostLabel.AutoSize = true;
            this.TotalBasketCostLabel.Location = new System.Drawing.Point(6, 152);
            this.TotalBasketCostLabel.Name = "TotalBasketCostLabel";
            this.TotalBasketCostLabel.Size = new System.Drawing.Size(111, 28);
            this.TotalBasketCostLabel.TabIndex = 1;
            this.TotalBasketCostLabel.Text = "Total Cost:";
            // 
            // TotalQuantityLabel
            // 
            this.TotalQuantityLabel.AutoSize = true;
            this.TotalQuantityLabel.Location = new System.Drawing.Point(6, 51);
            this.TotalQuantityLabel.Name = "TotalQuantityLabel";
            this.TotalQuantityLabel.Size = new System.Drawing.Size(94, 56);
            this.TotalQuantityLabel.TabIndex = 0;
            this.TotalQuantityLabel.Text = "Bagels \r\nOrdered:";
            // 
            // CurrentBasketDetailsListBox
            // 
            this.CurrentBasketDetailsListBox.FormattingEnabled = true;
            this.CurrentBasketDetailsListBox.ItemHeight = 28;
            this.CurrentBasketDetailsListBox.Location = new System.Drawing.Point(727, 481);
            this.CurrentBasketDetailsListBox.Name = "CurrentBasketDetailsListBox";
            this.CurrentBasketDetailsListBox.Size = new System.Drawing.Size(586, 256);
            this.CurrentBasketDetailsListBox.TabIndex = 9;
            this.CurrentBasketDetailsListBox.Visible = false;
            // 
            // SearchMainForm
            // 
            this.SearchMainForm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SearchMainForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchMainForm.Location = new System.Drawing.Point(26, 131);
            this.SearchMainForm.Name = "SearchMainForm";
            this.SearchMainForm.Size = new System.Drawing.Size(219, 34);
            this.SearchMainForm.TabIndex = 10;
            this.SearchMainForm.Text = "&Search";
            this.SearchToolTip.SetToolTip(this.SearchMainForm, "Search previous transaction details\r\nby ID or Date/Time.");
            this.SearchMainForm.UseVisualStyleBackColor = false;
            this.SearchMainForm.Click += new System.EventHandler(this.SearchMainForm_Click);
            // 
            // SearchFormGroupBox
            // 
            this.SearchFormGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.SearchFormGroupBox.Controls.Add(this.DateRadioButton);
            this.SearchFormGroupBox.Controls.Add(this.IDRadioButton);
            this.SearchFormGroupBox.Controls.Add(this.SearchPreviousButton);
            this.SearchFormGroupBox.Controls.Add(this.SearchPrevTextBox);
            this.SearchFormGroupBox.Controls.Add(this.SearchFormIDLabel);
            this.SearchFormGroupBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchFormGroupBox.Location = new System.Drawing.Point(338, 12);
            this.SearchFormGroupBox.Name = "SearchFormGroupBox";
            this.SearchFormGroupBox.Size = new System.Drawing.Size(540, 193);
            this.SearchFormGroupBox.TabIndex = 11;
            this.SearchFormGroupBox.TabStop = false;
            this.SearchFormGroupBox.Text = "Search Previous Transaction";
            this.SearchFormGroupBox.Visible = false;
            // 
            // DateRadioButton
            // 
            this.DateRadioButton.AutoSize = true;
            this.DateRadioButton.Location = new System.Drawing.Point(230, 61);
            this.DateRadioButton.Name = "DateRadioButton";
            this.DateRadioButton.Size = new System.Drawing.Size(138, 32);
            this.DateRadioButton.TabIndex = 6;
            this.DateRadioButton.TabStop = true;
            this.DateRadioButton.Text = "Date/Time";
            this.DateRadioButton.UseVisualStyleBackColor = true;
            // 
            // IDRadioButton
            // 
            this.IDRadioButton.AutoSize = true;
            this.IDRadioButton.Location = new System.Drawing.Point(62, 61);
            this.IDRadioButton.Name = "IDRadioButton";
            this.IDRadioButton.Size = new System.Drawing.Size(58, 32);
            this.IDRadioButton.TabIndex = 5;
            this.IDRadioButton.TabStop = true;
            this.IDRadioButton.Text = "ID";
            this.IDRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchPreviousButton
            // 
            this.SearchPreviousButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SearchPreviousButton.ForeColor = System.Drawing.SystemColors.Window;
            this.SearchPreviousButton.Location = new System.Drawing.Point(352, 135);
            this.SearchPreviousButton.Name = "SearchPreviousButton";
            this.SearchPreviousButton.Size = new System.Drawing.Size(160, 35);
            this.SearchPreviousButton.TabIndex = 4;
            this.SearchPreviousButton.Text = "&Search";
            this.SearchPrevToolTip.SetToolTip(this.SearchPreviousButton, "Search to display previous transaction \r\nby inputted ID / date.");
            this.SearchPreviousButton.UseVisualStyleBackColor = false;
            this.SearchPreviousButton.Click += new System.EventHandler(this.SearchPrevButton_Click);
            // 
            // SearchPrevTextBox
            // 
            this.SearchPrevTextBox.Location = new System.Drawing.Point(152, 135);
            this.SearchPrevTextBox.Name = "SearchPrevTextBox";
            this.SearchPrevTextBox.Size = new System.Drawing.Size(175, 34);
            this.SearchPrevTextBox.TabIndex = 2;
            this.SearchPrevTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SearchFormIDLabel
            // 
            this.SearchFormIDLabel.AutoSize = true;
            this.SearchFormIDLabel.Location = new System.Drawing.Point(20, 135);
            this.SearchFormIDLabel.Name = "SearchFormIDLabel";
            this.SearchFormIDLabel.Size = new System.Drawing.Size(80, 28);
            this.SearchFormIDLabel.TabIndex = 0;
            this.SearchFormIDLabel.Text = "Search:";
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonPanel.Controls.Add(this.StockReportButton);
            this.ButtonPanel.Controls.Add(this.SummaryItemButton);
            this.ButtonPanel.Controls.Add(this.SummaryButton);
            this.ButtonPanel.Controls.Add(this.AddOrderButton);
            this.ButtonPanel.Controls.Add(this.CompleteOrderButton);
            this.ButtonPanel.Controls.Add(this.SearchMainForm);
            this.ButtonPanel.Controls.Add(this.ClearMainButton);
            this.ButtonPanel.Controls.Add(this.ExitButton);
            this.ButtonPanel.Location = new System.Drawing.Point(1044, 19);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(269, 456);
            this.ButtonPanel.TabIndex = 13;
            // 
            // StockReportButton
            // 
            this.StockReportButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.StockReportButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StockReportButton.Location = new System.Drawing.Point(26, 296);
            this.StockReportButton.Name = "StockReportButton";
            this.StockReportButton.Size = new System.Drawing.Size(219, 34);
            this.StockReportButton.TabIndex = 13;
            this.StockReportButton.Text = "Stock &Report";
            this.StockReportToolTip.SetToolTip(this.StockReportButton, "Generate a stock report for the manager\r\nshowing available stock of each item.");
            this.StockReportButton.UseVisualStyleBackColor = false;
            this.StockReportButton.Click += new System.EventHandler(this.StockReportButton_Click);
            // 
            // SummaryItemButton
            // 
            this.SummaryItemButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SummaryItemButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SummaryItemButton.Location = new System.Drawing.Point(26, 241);
            this.SummaryItemButton.Name = "SummaryItemButton";
            this.SummaryItemButton.Size = new System.Drawing.Size(219, 34);
            this.SummaryItemButton.TabIndex = 12;
            this.SummaryItemButton.Text = "&Item Sales Summary";
            this.ItemSalesSummary.SetToolTip(this.SummaryItemButton, "Generate report displaying sales of each\r\nitem/size sold today.");
            this.SummaryItemButton.UseVisualStyleBackColor = false;
            this.SummaryItemButton.Click += new System.EventHandler(this.SummaryItemButton_Click);
            // 
            // SummaryButton
            // 
            this.SummaryButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SummaryButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SummaryButton.Location = new System.Drawing.Point(26, 186);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(219, 34);
            this.SummaryButton.TabIndex = 11;
            this.SummaryButton.Text = "&Total Sales Summary";
            this.SalesSummaryToolTip.SetToolTip(this.SummaryButton, "Generate summary details of all\r\nsales made today.");
            this.SummaryButton.UseVisualStyleBackColor = false;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // AddOrderToolTip
            // 
            this.AddOrderToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.AddOrderToolTip.ToolTipTitle = "Info";
            // 
            // CompleteToolTip
            // 
            this.CompleteToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.CompleteToolTip.ToolTipTitle = "Info";
            // 
            // SearchToolTip
            // 
            this.SearchToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.SearchToolTip.ToolTipTitle = "Info";
            // 
            // SalesSummaryToolTip
            // 
            this.SalesSummaryToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.SalesSummaryToolTip.ToolTipTitle = "Info";
            // 
            // ItemSalesSummary
            // 
            this.ItemSalesSummary.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ItemSalesSummary.ToolTipTitle = "Info";
            // 
            // StockReportToolTip
            // 
            this.StockReportToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.StockReportToolTip.ToolTipTitle = "Info";
            // 
            // ClearToolTip
            // 
            this.ClearToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ClearToolTip.ToolTipTitle = "Info";
            // 
            // ExitToolTip
            // 
            this.ExitToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ExitToolTip.ToolTipTitle = "Info";
            // 
            // SearchPrevToolTip
            // 
            this.SearchPrevToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.SearchPrevToolTip.ToolTipTitle = "Info";
            // 
            // MainBagelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 877);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.SearchResultGroupBox);
            this.Controls.Add(this.SearchFormGroupBox);
            this.Controls.Add(this.CurrentBasketDetailsListBox);
            this.Controls.Add(this.CurrentBasketTotalGroupBox);
            this.Controls.Add(this.PriceDisplayGroupBox);
            this.Controls.Add(this.OrderQuantityGroupBox);
            this.Controls.Add(this.SizeGroupBox);
            this.Controls.Add(this.BagelTypeGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainBagelForm";
            this.Text = "MyBagelShop LTD.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BagelTypeGroupBox.ResumeLayout(false);
            this.BagelTypeGroupBox.PerformLayout();
            this.SearchResultGroupBox.ResumeLayout(false);
            this.SizeGroupBox.ResumeLayout(false);
            this.SizeGroupBox.PerformLayout();
            this.OrderQuantityGroupBox.ResumeLayout(false);
            this.OrderQuantityGroupBox.PerformLayout();
            this.PriceDisplayGroupBox.ResumeLayout(false);
            this.PriceDisplayGroupBox.PerformLayout();
            this.CurrentBasketTotalGroupBox.ResumeLayout(false);
            this.CurrentBasketTotalGroupBox.PerformLayout();
            this.SearchFormGroupBox.ResumeLayout(false);
            this.SearchFormGroupBox.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button CompleteOrderButton;
        private GroupBox BagelTypeGroupBox;
        private ListBox BagelTypeListBox;
        private Label BagelTypeLabel;
        private Label BagelPriceLabel;
        private GroupBox SizeGroupBox;
        private ListBox SizeListBox;
        private Label SizePriceLabel;
        private Label SizeLabel;
        private Label LabelAdditionalCost;
        private GroupBox OrderQuantityGroupBox;
        private TextBox QuantityTextBox;
        private Label NumberSelectedLabel;
        private Button ExitButton;
        private Button AddOrderButton;
        private Button ClearMainButton;
        private TextBox OptionSelectedPriceTextBox;
        private GroupBox PriceDisplayGroupBox;
        private Label ValidAmountLabel;
        private GroupBox CurrentBasketTotalGroupBox;
        private TextBox TotalOrderedStockTextBox;
        private TextBox TotalSalesOrderTextBox;
        private Label TotalBasketCostLabel;
        private Label TotalQuantityLabel;
        private ListBox CurrentBasketDetailsListBox;
        private Button SearchMainForm;
        private GroupBox SearchResultGroupBox;
        private ListBox SearchFormListBox;
        private GroupBox SearchFormGroupBox;
        private Button SearchPreviousButton;
        private TextBox SearchPrevTextBox;
        private Label SearchFormIDLabel;
        private Panel ButtonPanel;
        private RadioButton DateRadioButton;
        private RadioButton IDRadioButton;
        private Button SummaryButton;
        private Button StockReportButton;
        private Button SummaryItemButton;
        private ToolTip AddOrderToolTip;
        private ToolTip CompleteToolTip;
        private ToolTip SearchToolTip;
        private ToolTip SalesSummaryToolTip;
        private ToolTip ItemSalesSummary;
        private ToolTip StockReportToolTip;
        private ToolTip ClearToolTip;
        private ToolTip ExitToolTip;
        private ToolTip SearchPrevToolTip;
    }
}