namespace WallStreetMarket
{
    partial class ExchangeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbExchangeFrom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbExchangeTo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.btnExchange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exchange";
            // 
            // cbExchangeFrom
            // 
            this.cbExchangeFrom.FormattingEnabled = true;
            this.cbExchangeFrom.Items.AddRange(new object[] {
            "Euro",
            "Dollar",
            "Lev"});
            this.cbExchangeFrom.Location = new System.Drawing.Point(12, 47);
            this.cbExchangeFrom.Name = "cbExchangeFrom";
            this.cbExchangeFrom.Size = new System.Drawing.Size(121, 21);
            this.cbExchangeFrom.TabIndex = 1;
            this.cbExchangeFrom.SelectedIndexChanged += new System.EventHandler(this.cbExchangeFrom_SelectedIndexChanged);
            this.cbExchangeFrom.TextChanged += new System.EventHandler(this.cbExchangeFrom_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "to";
            // 
            // cbExchangeTo
            // 
            this.cbExchangeTo.Enabled = false;
            this.cbExchangeTo.FormattingEnabled = true;
            this.cbExchangeTo.Location = new System.Drawing.Point(264, 47);
            this.cbExchangeTo.Name = "cbExchangeTo";
            this.cbExchangeTo.Size = new System.Drawing.Size(121, 21);
            this.cbExchangeTo.TabIndex = 3;
            this.cbExchangeTo.SelectedIndexChanged += new System.EventHandler(this.cbExchangeTo_SelectedIndexChanged);
            this.cbExchangeTo.TextChanged += new System.EventHandler(this.cbExchangeTo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Exchange at:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(334, 88);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 13);
            this.lblPrice.TabIndex = 5;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Enabled = false;
            this.tbQuantity.Location = new System.Drawing.Point(146, 88);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(100, 20);
            this.tbQuantity.TabIndex = 7;
            this.tbQuantity.TextChanged += new System.EventHandler(this.tbQuantity_TextChanged);
            // 
            // btnExchange
            // 
            this.btnExchange.Enabled = false;
            this.btnExchange.Location = new System.Drawing.Point(162, 131);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(75, 30);
            this.btnExchange.TabIndex = 8;
            this.btnExchange.Text = "Exchange";
            this.btnExchange.UseVisualStyleBackColor = true;
            this.btnExchange.Click += new System.EventHandler(this.btnExchange_Click);
            // 
            // ExchangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 189);
            this.Controls.Add(this.btnExchange);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbExchangeTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbExchangeFrom);
            this.Controls.Add(this.label1);
            this.Name = "ExchangeForm";
            this.Text = "ExchangeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExchangeForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbExchangeFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbExchangeTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Button btnExchange;
    }
}