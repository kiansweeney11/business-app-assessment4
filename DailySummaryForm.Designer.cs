namespace MyBagelShop
{
    partial class DailySummaryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailySummaryForm));
            this.DailySummaryFormGroupBox = new System.Windows.Forms.GroupBox();
            this.AverageTransactionTextBox = new System.Windows.Forms.TextBox();
            this.TransactionsTextBox = new System.Windows.Forms.TextBox();
            this.SalesValueTextBox = new System.Windows.Forms.TextBox();
            this.BagelsSoldTextBox = new System.Windows.Forms.TextBox();
            this.AverageLabel = new System.Windows.Forms.Label();
            this.NumberTransactionsLabel = new System.Windows.Forms.Label();
            this.SalesValueLabel = new System.Windows.Forms.Label();
            this.NumberSoldLabel = new System.Windows.Forms.Label();
            this.SummaryPictureBox = new System.Windows.Forms.PictureBox();
            this.DailySummaryFormGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SummaryPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DailySummaryFormGroupBox
            // 
            this.DailySummaryFormGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.DailySummaryFormGroupBox.Controls.Add(this.AverageTransactionTextBox);
            this.DailySummaryFormGroupBox.Controls.Add(this.TransactionsTextBox);
            this.DailySummaryFormGroupBox.Controls.Add(this.SalesValueTextBox);
            this.DailySummaryFormGroupBox.Controls.Add(this.BagelsSoldTextBox);
            this.DailySummaryFormGroupBox.Controls.Add(this.AverageLabel);
            this.DailySummaryFormGroupBox.Controls.Add(this.NumberTransactionsLabel);
            this.DailySummaryFormGroupBox.Controls.Add(this.SalesValueLabel);
            this.DailySummaryFormGroupBox.Controls.Add(this.NumberSoldLabel);
            this.DailySummaryFormGroupBox.Location = new System.Drawing.Point(114, 49);
            this.DailySummaryFormGroupBox.Name = "DailySummaryFormGroupBox";
            this.DailySummaryFormGroupBox.Size = new System.Drawing.Size(525, 284);
            this.DailySummaryFormGroupBox.TabIndex = 0;
            this.DailySummaryFormGroupBox.TabStop = false;
            this.DailySummaryFormGroupBox.Text = "Daily Summary Sales Report";
            // 
            // AverageTransactionTextBox
            // 
            this.AverageTransactionTextBox.Enabled = false;
            this.AverageTransactionTextBox.Location = new System.Drawing.Point(299, 220);
            this.AverageTransactionTextBox.Name = "AverageTransactionTextBox";
            this.AverageTransactionTextBox.Size = new System.Drawing.Size(150, 34);
            this.AverageTransactionTextBox.TabIndex = 7;
            this.AverageTransactionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TransactionsTextBox
            // 
            this.TransactionsTextBox.Enabled = false;
            this.TransactionsTextBox.Location = new System.Drawing.Point(299, 166);
            this.TransactionsTextBox.Name = "TransactionsTextBox";
            this.TransactionsTextBox.Size = new System.Drawing.Size(150, 34);
            this.TransactionsTextBox.TabIndex = 6;
            this.TransactionsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SalesValueTextBox
            // 
            this.SalesValueTextBox.Enabled = false;
            this.SalesValueTextBox.Location = new System.Drawing.Point(299, 112);
            this.SalesValueTextBox.Name = "SalesValueTextBox";
            this.SalesValueTextBox.Size = new System.Drawing.Size(150, 34);
            this.SalesValueTextBox.TabIndex = 5;
            this.SalesValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BagelsSoldTextBox
            // 
            this.BagelsSoldTextBox.Enabled = false;
            this.BagelsSoldTextBox.Location = new System.Drawing.Point(301, 58);
            this.BagelsSoldTextBox.Name = "BagelsSoldTextBox";
            this.BagelsSoldTextBox.Size = new System.Drawing.Size(150, 34);
            this.BagelsSoldTextBox.TabIndex = 4;
            this.BagelsSoldTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AverageLabel
            // 
            this.AverageLabel.AutoSize = true;
            this.AverageLabel.Location = new System.Drawing.Point(46, 220);
            this.AverageLabel.Name = "AverageLabel";
            this.AverageLabel.Size = new System.Drawing.Size(210, 28);
            this.AverageLabel.TabIndex = 3;
            this.AverageLabel.Text = "Average Transaction:";
            // 
            // NumberTransactionsLabel
            // 
            this.NumberTransactionsLabel.AutoSize = true;
            this.NumberTransactionsLabel.Location = new System.Drawing.Point(46, 168);
            this.NumberTransactionsLabel.Name = "NumberTransactionsLabel";
            this.NumberTransactionsLabel.Size = new System.Drawing.Size(135, 28);
            this.NumberTransactionsLabel.TabIndex = 2;
            this.NumberTransactionsLabel.Text = "Transactions:";
            // 
            // SalesValueLabel
            // 
            this.SalesValueLabel.AutoSize = true;
            this.SalesValueLabel.Location = new System.Drawing.Point(46, 116);
            this.SalesValueLabel.Name = "SalesValueLabel";
            this.SalesValueLabel.Size = new System.Drawing.Size(122, 28);
            this.SalesValueLabel.TabIndex = 1;
            this.SalesValueLabel.Text = "Sales Value:";
            // 
            // NumberSoldLabel
            // 
            this.NumberSoldLabel.AutoSize = true;
            this.NumberSoldLabel.Location = new System.Drawing.Point(46, 64);
            this.NumberSoldLabel.Name = "NumberSoldLabel";
            this.NumberSoldLabel.Size = new System.Drawing.Size(126, 28);
            this.NumberSoldLabel.TabIndex = 0;
            this.NumberSoldLabel.Text = "Bagels Sold:";
            // 
            // SummaryPictureBox
            // 
            this.SummaryPictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.SummaryPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SummaryPictureBox.Image")));
            this.SummaryPictureBox.Location = new System.Drawing.Point(214, 352);
            this.SummaryPictureBox.Name = "SummaryPictureBox";
            this.SummaryPictureBox.Size = new System.Drawing.Size(321, 130);
            this.SummaryPictureBox.TabIndex = 1;
            this.SummaryPictureBox.TabStop = false;
            // 
            // DailySummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 504);
            this.Controls.Add(this.SummaryPictureBox);
            this.Controls.Add(this.DailySummaryFormGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DailySummaryForm";
            this.Text = "DailySummaryForm";
            this.DailySummaryFormGroupBox.ResumeLayout(false);
            this.DailySummaryFormGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SummaryPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox DailySummaryFormGroupBox;
        private Label AverageLabel;
        private Label NumberTransactionsLabel;
        private Label SalesValueLabel;
        private Label NumberSoldLabel;
        private TextBox AverageTransactionTextBox;
        private TextBox TransactionsTextBox;
        private TextBox SalesValueTextBox;
        private TextBox BagelsSoldTextBox;
        private PictureBox SummaryPictureBox;
    }
}