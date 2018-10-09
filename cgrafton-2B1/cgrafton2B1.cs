using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cgrafton_2B1
{
    public partial class cgrafton2B1 : Form
    {
        public cgrafton2B1()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, EventArgs e)
        {
            decimal AmountBrazil = Convert.ToDecimal(txtAmountBrazil.Text);
            decimal RateBrazil = Convert.ToDecimal(txtRateBrazil.Text);
            decimal USDBrazil = AmountBrazil * RateBrazil;
            txtUSDBrazil.Text = USDBrazil.ToString("0.00");

            decimal AmountIndia = Convert.ToDecimal(txtAmountIndia.Text);
            decimal RateIndia = Convert.ToDecimal(txtRateIndia.Text);
            decimal USDIndia = AmountIndia * RateIndia;
            txtUSDIndia.Text = USDIndia.ToString("0.00");

            decimal AmountMexico = Convert.ToDecimal(txtAmountMexico.Text);
            decimal RateMexico = Convert.ToDecimal(txtRateMexico.Text);
            decimal USDMexico = AmountMexico * RateMexico;
            txtUSDMexico.Text = USDMexico.ToString("0.00");

            decimal AmountSouthKorea = Convert.ToDecimal(txtAmountSouthKorea.Text);
            decimal RateSouthKorea = Convert.ToDecimal(txtRateSouthKorea);
            decimal USDSouthKorea = AmountSouthKorea * RateSouthKorea;
            txtUSDSouthKorea.Text = USDSouthKorea.ToString("0.00");

            decimal TotalUSD = USDBrazil + USDIndia + USDMexico + USDSouthKorea;
            txtTotalUSD.Text = TotalUSD.ToString("0.00");

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountBrazil.Text = "0.00";
            txtRateBrazil.Text = "0.244750";
            txtAmountIndia.Text = "0.00";
            txtRateIndia.Text = "0.0137822";
            txtAmountMexico.Text = "0.00";
            txtRateMexico.Text = "0.0518386";
            txtAmountSouthKorea.Text = "0.00";
            txtRateSouthKorea.Text = "0.000885382";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
