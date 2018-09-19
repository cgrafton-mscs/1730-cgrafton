using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cgrafton1F
{
    public partial class frmCurrency : Form
    {
        public frmCurrency()
        {
            InitializeComponent();
        }

        private void frmCurrency_Load(object sender, EventArgs e)
        {

            btnBrazil.BackgroundImage = picBrazil.Image;
            btnMexico.BackgroundImage = picMexicodim.Image;
            btnIndia.BackgroundImage = picIndiadim.Image;
            btnSouthKorea.BackgroundImage = picSouthKoreadim.Image;
            txtRate.Text = "0.244750";
            lblCurrency.Text = btnBrazil.Text + ": ";
            txtUSD.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtCurrency.Focus();

        }

        private void btnBrazil_Click(object sender, EventArgs e)
        {
            btnBrazil.BackgroundImage = picBrazil.Image;
            btnMexico.BackgroundImage = picMexicodim.Image;
            btnIndia.BackgroundImage = picIndiadim.Image;
            btnSouthKorea.BackgroundImage = picSouthKoreadim.Image;
            txtRate.Text = "0.244750";
            txtCurrency.Focus();
        }

        private void btnMexico_Click(object sender, EventArgs e)
        {
            btnMexico.BackgroundImage = picMexico.Image;
            btnBrazil.BackgroundImage = picBrazildim.Image;
            btnIndia.BackgroundImage = picIndiadim.Image;
            btnSouthKorea.BackgroundImage = picSouthKoreadim.Image;
            txtRate.Text = "0.0518386";
            txtCurrency.Focus();
        }

        private void btnIndia_Click(object sender, EventArgs e)
        {
            btnIndia.BackgroundImage = picIndia.Image;
            btnBrazil.BackgroundImage = picBrazildim.Image;
            btnMexico.BackgroundImage = picMexicodim.Image;
            btnSouthKorea.BackgroundImage = picSouthKoreadim.Image;
            txtRate.Text = "0.0137822";
            txtCurrency.Focus();
        }

        private void btnSouthKorea_Click(object sender, EventArgs e)
        {
            btnSouthKorea.BackgroundImage = picSouthKorea.Image;
            btnMexico.BackgroundImage = picMexicodim.Image;
            btnBrazil.BackgroundImage = picBrazildim.Image;
            btnIndia.BackgroundImage = picIndiadim.Image;
            txtRate.Text = "0.000885382";
            txtCurrency.Focus();
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSD.Text =
                (Convert.ToDecimal(txtCurrency.Text)
                * Convert.ToDecimal(txtRate.Text)).ToString("0.00");
        }

        private void txtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
             txtTotalUSD.Text =
               (Convert.ToDecimal(txtUSD.Text)
               + Convert.ToDecimal(txtTotalUSD.Text)).ToString("0.00");
            lblEquation.Text = lblEquation.Text + " + " + txtUSD.Text;

        }

        private void lblEquation_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCurrency.Text = "0.";
            txtTotalUSD.Text = "";
            lblEquation.Text = "";
        }
    }
}
