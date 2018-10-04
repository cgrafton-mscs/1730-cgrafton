using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cgrafton2A1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //txtDiscountamount.Text =
            //    (Convert.ToDecimal(txtSubtotal.Text)
            //    * Convert.ToDecimal(txtDiscountpercent.Text) / 100).ToString("0.00");
            Decimal Subtotal = Convert.ToInt32(txtSubtotal.Text);
            Decimal Discountpercent = Convert.ToInt32(txtDiscountpercent.Text);
            Decimal Discountamount = Subtotal * Discountpercent / 100;
            txtDiscountamount.Text = Discountamount.ToString("0.00");

            //txtTotal.Text =
            //    (Convert.ToDecimal(txtSubtotal.Text)
            //    - Convert.ToDecimal(txtDiscountamount.Text)).ToString("0.00");
            Decimal Total = Subtotal - Discountamount;
            txtTotal.Text = Total.ToString("0.00");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
