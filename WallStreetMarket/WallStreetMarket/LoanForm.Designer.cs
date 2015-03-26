namespace WallStreetMarket
{
    partial class LoanForm
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
            this.lblText = new System.Windows.Forms.Label();
            this.tbLoan = new System.Windows.Forms.TextBox();
            this.btnPayGet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(133, 20);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(35, 13);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "label1";
            // 
            // tbLoan
            // 
            this.tbLoan.Location = new System.Drawing.Point(53, 47);
            this.tbLoan.Name = "tbLoan";
            this.tbLoan.Size = new System.Drawing.Size(199, 20);
            this.tbLoan.TabIndex = 1;
            // 
            // btnPayGet
            // 
            this.btnPayGet.Location = new System.Drawing.Point(112, 81);
            this.btnPayGet.Name = "btnPayGet";
            this.btnPayGet.Size = new System.Drawing.Size(75, 23);
            this.btnPayGet.TabIndex = 2;
            this.btnPayGet.Text = "button1";
            this.btnPayGet.UseVisualStyleBackColor = true;
            this.btnPayGet.Click += new System.EventHandler(this.btnPayGet_Click);
            // 
            // LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 116);
            this.Controls.Add(this.btnPayGet);
            this.Controls.Add(this.tbLoan);
            this.Controls.Add(this.lblText);
            this.Name = "LoanForm";
            this.Text = "LoanForm";
            this.Load += new System.EventHandler(this.LoanForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox tbLoan;
        private System.Windows.Forms.Button btnPayGet;
    }
}