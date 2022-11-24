namespace MyBagelShop
{
    partial class ManagementSummaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementSummaryForm));
            this.PictureBoxStockSummary = new System.Windows.Forms.PictureBox();
            this.StockCountListBox = new System.Windows.Forms.ListBox();
            this.DateSumTextBox = new System.Windows.Forms.TextBox();
            this.SummaryManagementLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStockSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxStockSummary
            // 
            this.PictureBoxStockSummary.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxStockSummary.Image")));
            this.PictureBoxStockSummary.Location = new System.Drawing.Point(304, 12);
            this.PictureBoxStockSummary.Name = "PictureBoxStockSummary";
            this.PictureBoxStockSummary.Size = new System.Drawing.Size(322, 124);
            this.PictureBoxStockSummary.TabIndex = 0;
            this.PictureBoxStockSummary.TabStop = false;
            // 
            // StockCountListBox
            // 
            this.StockCountListBox.ItemHeight = 28;
            this.StockCountListBox.Location = new System.Drawing.Point(147, 206);
            this.StockCountListBox.Name = "StockCountListBox";
            this.StockCountListBox.Size = new System.Drawing.Size(654, 200);
            this.StockCountListBox.TabIndex = 1;
            // 
            // DateSumTextBox
            // 
            this.DateSumTextBox.Enabled = false;
            this.DateSumTextBox.Location = new System.Drawing.Point(147, 153);
            this.DateSumTextBox.Name = "DateSumTextBox";
            this.DateSumTextBox.Size = new System.Drawing.Size(654, 34);
            this.DateSumTextBox.TabIndex = 2;
            this.DateSumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SummaryManagementLabel
            // 
            this.SummaryManagementLabel.AutoSize = true;
            this.SummaryManagementLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.SummaryManagementLabel.Location = new System.Drawing.Point(326, 423);
            this.SummaryManagementLabel.Name = "SummaryManagementLabel";
            this.SummaryManagementLabel.Size = new System.Drawing.Size(300, 112);
            this.SummaryManagementLabel.TabIndex = 3;
            this.SummaryManagementLabel.Text = "Only items that have been sold\r\nare mentioned in report. Those\r\nnot mentioned hav" +
    "e had no sales\r\ntoday.";
            // 
            // ManagementSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 544);
            this.Controls.Add(this.SummaryManagementLabel);
            this.Controls.Add(this.DateSumTextBox);
            this.Controls.Add(this.StockCountListBox);
            this.Controls.Add(this.PictureBoxStockSummary);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ManagementSummaryForm";
            this.Text = "ManagementSummaryForm";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStockSummary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox PictureBoxStockSummary;
        private ListBox StockCountListBox;
        private TextBox DateSumTextBox;
        private Label SummaryManagementLabel;
    }
}