namespace MyBagelShop
{
    partial class CompanyReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyReceipt));
            this.ReceiptPictureBox = new System.Windows.Forms.PictureBox();
            this.ReceiptCompanyLabel = new System.Windows.Forms.Label();
            this.UniqueIDReceiptTextBox = new System.Windows.Forms.TextBox();
            this.ReceiptFinalPriceTextBox = new System.Windows.Forms.TextBox();
            this.ReceiptDateLabelTextBox = new System.Windows.Forms.TextBox();
            this.ThanksLabel = new System.Windows.Forms.Label();
            this.ItemsReceiptListBox = new System.Windows.Forms.ListBox();
            this.TypeReceiptLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ReceiptPictureBox
            // 
            this.ReceiptPictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.ReceiptPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ReceiptPictureBox.Image")));
            this.ReceiptPictureBox.Location = new System.Drawing.Point(236, 24);
            this.ReceiptPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ReceiptPictureBox.Name = "ReceiptPictureBox";
            this.ReceiptPictureBox.Size = new System.Drawing.Size(356, 127);
            this.ReceiptPictureBox.TabIndex = 0;
            this.ReceiptPictureBox.TabStop = false;
            // 
            // ReceiptCompanyLabel
            // 
            this.ReceiptCompanyLabel.AutoSize = true;
            this.ReceiptCompanyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReceiptCompanyLabel.Location = new System.Drawing.Point(295, 175);
            this.ReceiptCompanyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReceiptCompanyLabel.Name = "ReceiptCompanyLabel";
            this.ReceiptCompanyLabel.Size = new System.Drawing.Size(220, 32);
            this.ReceiptCompanyLabel.TabIndex = 1;
            this.ReceiptCompanyLabel.Text = "MyBagelShop Ltd.";
            // 
            // UniqueIDReceiptTextBox
            // 
            this.UniqueIDReceiptTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.UniqueIDReceiptTextBox.Enabled = false;
            this.UniqueIDReceiptTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UniqueIDReceiptTextBox.Location = new System.Drawing.Point(53, 220);
            this.UniqueIDReceiptTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UniqueIDReceiptTextBox.Name = "UniqueIDReceiptTextBox";
            this.UniqueIDReceiptTextBox.Size = new System.Drawing.Size(698, 34);
            this.UniqueIDReceiptTextBox.TabIndex = 2;
            this.UniqueIDReceiptTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReceiptFinalPriceTextBox
            // 
            this.ReceiptFinalPriceTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ReceiptFinalPriceTextBox.Enabled = false;
            this.ReceiptFinalPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReceiptFinalPriceTextBox.Location = new System.Drawing.Point(53, 543);
            this.ReceiptFinalPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ReceiptFinalPriceTextBox.Name = "ReceiptFinalPriceTextBox";
            this.ReceiptFinalPriceTextBox.Size = new System.Drawing.Size(698, 34);
            this.ReceiptFinalPriceTextBox.TabIndex = 4;
            this.ReceiptFinalPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReceiptDateLabelTextBox
            // 
            this.ReceiptDateLabelTextBox.Enabled = false;
            this.ReceiptDateLabelTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReceiptDateLabelTextBox.Location = new System.Drawing.Point(53, 271);
            this.ReceiptDateLabelTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ReceiptDateLabelTextBox.Name = "ReceiptDateLabelTextBox";
            this.ReceiptDateLabelTextBox.Size = new System.Drawing.Size(698, 34);
            this.ReceiptDateLabelTextBox.TabIndex = 5;
            this.ReceiptDateLabelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ThanksLabel
            // 
            this.ThanksLabel.AutoSize = true;
            this.ThanksLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ThanksLabel.Location = new System.Drawing.Point(139, 592);
            this.ThanksLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ThanksLabel.Name = "ThanksLabel";
            this.ThanksLabel.Size = new System.Drawing.Size(490, 28);
            this.ThanksLabel.TabIndex = 7;
            this.ThanksLabel.Text = "Enjoy your bagel(s) and we hope to see you again!";
            // 
            // ItemsReceiptListBox
            // 
            this.ItemsReceiptListBox.FormattingEnabled = true;
            this.ItemsReceiptListBox.ItemHeight = 25;
            this.ItemsReceiptListBox.Location = new System.Drawing.Point(53, 358);
            this.ItemsReceiptListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ItemsReceiptListBox.Name = "ItemsReceiptListBox";
            this.ItemsReceiptListBox.Size = new System.Drawing.Size(698, 179);
            this.ItemsReceiptListBox.TabIndex = 8;
            // 
            // TypeReceiptLabel
            // 
            this.TypeReceiptLabel.AutoSize = true;
            this.TypeReceiptLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TypeReceiptLabel.Location = new System.Drawing.Point(226, 321);
            this.TypeReceiptLabel.Name = "TypeReceiptLabel";
            this.TypeReceiptLabel.Size = new System.Drawing.Size(366, 25);
            this.TypeReceiptLabel.TabIndex = 9;
            this.TypeReceiptLabel.Text = "Left to right: Type, Size, Quantity, Cost of row";
            // 
            // CompanyReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 665);
            this.Controls.Add(this.TypeReceiptLabel);
            this.Controls.Add(this.ItemsReceiptListBox);
            this.Controls.Add(this.ThanksLabel);
            this.Controls.Add(this.ReceiptDateLabelTextBox);
            this.Controls.Add(this.ReceiptFinalPriceTextBox);
            this.Controls.Add(this.UniqueIDReceiptTextBox);
            this.Controls.Add(this.ReceiptCompanyLabel);
            this.Controls.Add(this.ReceiptPictureBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CompanyReceipt";
            this.Text = "MyBagelShop Company Receipt";
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox ReceiptPictureBox;
        private Label ReceiptCompanyLabel;
        private TextBox UniqueIDReceiptTextBox;
        private TextBox ReceiptFinalPriceTextBox;
        private TextBox ReceiptDateLabelTextBox;
        private Label ThanksLabel;
        private ListBox ItemsReceiptListBox;
        private Label TypeReceiptLabel;
    }
}