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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainBagelForm));
            this.CompleteOrderButton = new System.Windows.Forms.Button();
            this.BagelTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.BagelPriceLabel = new System.Windows.Forms.Label();
            this.BagelTypeLabel = new System.Windows.Forms.Label();
            this.BagelTypeListBox = new System.Windows.Forms.ListBox();
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
            this.BagelTypeGroupBox.SuspendLayout();
            this.SizeGroupBox.SuspendLayout();
            this.OrderQuantityGroupBox.SuspendLayout();
            this.PriceDisplayGroupBox.SuspendLayout();
            this.CurrentBasketTotalGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CompleteOrderButton
            // 
            this.CompleteOrderButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CompleteOrderButton.Enabled = false;
            this.CompleteOrderButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CompleteOrderButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CompleteOrderButton.Location = new System.Drawing.Point(892, 581);
            this.CompleteOrderButton.Name = "CompleteOrderButton";
            this.CompleteOrderButton.Size = new System.Drawing.Size(200, 38);
            this.CompleteOrderButton.TabIndex = 0;
            this.CompleteOrderButton.Text = "Complete Order";
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
            this.ExitButton.Location = new System.Drawing.Point(1055, 164);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(112, 34);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddOrderButton.Enabled = false;
            this.AddOrderButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddOrderButton.Location = new System.Drawing.Point(1055, 354);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(165, 34);
            this.AddOrderButton.TabIndex = 5;
            this.AddOrderButton.Text = "Add to Order";
            this.AddOrderButton.UseVisualStyleBackColor = false;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // ClearMainButton
            // 
            this.ClearMainButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClearMainButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClearMainButton.Location = new System.Drawing.Point(1055, 244);
            this.ClearMainButton.Name = "ClearMainButton";
            this.ClearMainButton.Size = new System.Drawing.Size(112, 34);
            this.ClearMainButton.TabIndex = 6;
            this.ClearMainButton.Text = "Clear";
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
            // MainBagelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 657);
            this.Controls.Add(this.CurrentBasketTotalGroupBox);
            this.Controls.Add(this.PriceDisplayGroupBox);
            this.Controls.Add(this.ClearMainButton);
            this.Controls.Add(this.AddOrderButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OrderQuantityGroupBox);
            this.Controls.Add(this.SizeGroupBox);
            this.Controls.Add(this.BagelTypeGroupBox);
            this.Controls.Add(this.CompleteOrderButton);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainBagelForm";
            this.Text = "MyBagelShop LTD.";
            this.Load += new System.EventHandler(this.MainBagelForm_Load);
            this.BagelTypeGroupBox.ResumeLayout(false);
            this.BagelTypeGroupBox.PerformLayout();
            this.SizeGroupBox.ResumeLayout(false);
            this.SizeGroupBox.PerformLayout();
            this.OrderQuantityGroupBox.ResumeLayout(false);
            this.OrderQuantityGroupBox.PerformLayout();
            this.PriceDisplayGroupBox.ResumeLayout(false);
            this.PriceDisplayGroupBox.PerformLayout();
            this.CurrentBasketTotalGroupBox.ResumeLayout(false);
            this.CurrentBasketTotalGroupBox.PerformLayout();
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
    }
}