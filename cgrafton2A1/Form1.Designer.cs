namespace cgrafton2A1
{
    partial class Form1
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Label();
            this.Discountamount = new System.Windows.Forms.Label();
            this.Discountpercent = new System.Windows.Forms.Label();
            this.Subtotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDiscountamount = new System.Windows.Forms.TextBox();
            this.txtDiscountpercent = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(170, 150);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 30);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(53, 150);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(108, 30);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(31, 113);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(44, 17);
            this.Total.TabIndex = 18;
            this.Total.Text = "Total:";
            this.Total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Discountamount
            // 
            this.Discountamount.AutoSize = true;
            this.Discountamount.Location = new System.Drawing.Point(31, 85);
            this.Discountamount.Name = "Discountamount";
            this.Discountamount.Size = new System.Drawing.Size(118, 17);
            this.Discountamount.TabIndex = 16;
            this.Discountamount.Text = "Discount amount:";
            this.Discountamount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Discountpercent
            // 
            this.Discountpercent.AutoSize = true;
            this.Discountpercent.Location = new System.Drawing.Point(31, 57);
            this.Discountpercent.Name = "Discountpercent";
            this.Discountpercent.Size = new System.Drawing.Size(119, 17);
            this.Discountpercent.TabIndex = 12;
            this.Discountpercent.Text = "Discount percent:";
            this.Discountpercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSize = true;
            this.Subtotal.Location = new System.Drawing.Point(31, 29);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Size = new System.Drawing.Size(64, 17);
            this.Subtotal.TabIndex = 10;
            this.Subtotal.Text = "&Subtotal:";
            this.Subtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(167, 110);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(111, 22);
            this.txtTotal.TabIndex = 19;
            // 
            // txtDiscountamount
            // 
            this.txtDiscountamount.Location = new System.Drawing.Point(167, 82);
            this.txtDiscountamount.Name = "txtDiscountamount";
            this.txtDiscountamount.ReadOnly = true;
            this.txtDiscountamount.Size = new System.Drawing.Size(111, 22);
            this.txtDiscountamount.TabIndex = 17;
            // 
            // txtDiscountpercent
            // 
            this.txtDiscountpercent.Location = new System.Drawing.Point(167, 54);
            this.txtDiscountpercent.Name = "txtDiscountpercent";
            this.txtDiscountpercent.Size = new System.Drawing.Size(111, 22);
            this.txtDiscountpercent.TabIndex = 13;
            this.txtDiscountpercent.Text = "5";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(167, 26);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(111, 22);
            this.txtSubtotal.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 229);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Discountamount);
            this.Controls.Add(this.Discountpercent);
            this.Controls.Add(this.Subtotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDiscountamount);
            this.Controls.Add(this.txtDiscountpercent);
            this.Controls.Add(this.txtSubtotal);
            this.Name = "Form1";
            this.Text = "cgrafton-2A1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Discountamount;
        private System.Windows.Forms.Label Discountpercent;
        private System.Windows.Forms.Label Subtotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDiscountamount;
        private System.Windows.Forms.TextBox txtDiscountpercent;
        private System.Windows.Forms.TextBox txtSubtotal;
    }
}

