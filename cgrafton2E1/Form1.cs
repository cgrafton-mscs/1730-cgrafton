using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cgrafton2E1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Result01Textbox.Text = "";
            Result02Textbox.Text = "";
            Result03aTextbox.Text = "";
            Result03bTextbox.Text = "";
            Result04aTextbox.Text = "";
            Result04bTextbox.Text = "";
            Result05aTextbox.Text = "";
            Result05bTextbox.Text = "";
            Result06aTextbox.Text = "";
            Result06bTextbox.Text = "";
            Result07Textbox.Text = "";
            Result08Textbox.Text = "";
            Result09Textbox.Text = "";
            Result09bTextbox.Text = "";
            Result10Textbox.Text = "";


            // #01
            decimal subtotal = Convert.ToDecimal(Input01aTextbox.Text);
            Result01Textbox.Text = (
                LogicalOperations.q01(subtotal)
                ).ToString();

            // #02
            int timeInService = Convert.ToInt32(Input02aTextbox.Text);
            Result02Textbox.Text = (
                LogicalOperations.q02(timeInService)
                ).ToString();

            // #03 - 06
            bool isValid = Convert.ToBoolean(Input03aTextbox.Text);
            int years = Convert.ToInt32(Input03cTextbox.Text);

            // #03
            int counter = Convert.ToInt32(Input03bTextbox.Text);
            Result03aTextbox.Text = (
                LogicalOperations.q03(isValid, years, counter)
                ).ToString();
            Result03bTextbox.Text = counter.ToString();

            // #04
            counter = Convert.ToInt32(Input03bTextbox.Text);
            Result04aTextbox.Text = (
                LogicalOperations.q04(isValid, years, counter)
                ).ToString();
            Result04bTextbox.Text = counter.ToString();

            // #05
            counter = Convert.ToInt32(Input03bTextbox.Text);
            Result05aTextbox.Text = (
                LogicalOperations.q05(isValid, years, counter)
                ).ToString();
            Result05bTextbox.Text = counter.ToString();

            // #06
            counter = Convert.ToInt32(Input03bTextbox.Text);
            Result06aTextbox.Text = (
                LogicalOperations.q06(isValid, years, counter)
                ).ToString();
            Result06bTextbox.Text = counter.ToString();

            // #07
            DateTime startDate = Convert.ToDateTime(Input07aTextbox.Text);
            DateTime experationDate = Convert.ToDateTime(Input07bTextbox.Text);
            DateTime Date = Convert.ToDateTime(Input07cTextbox.Text);
            isValid = Convert.ToBoolean(Input07dTextbox.Text);
            Result07Textbox.Text = (
                LogicalOperations.q07(startDate, experationDate, Date, isValid)
                ).ToString();

            // #08
            decimal thisYTD = Convert.ToDecimal(Input08aTextbox.Text);
            decimal lastYTD = Convert.ToDecimal(Input08bTextbox.Text);
            string emType = Input08cTextbox.Text;
            int startYear = Convert.ToInt32(Input08dTextbox.Text);
            int currentYear = Convert.ToInt32(Input08eTextbox.Text);
            Result08Textbox.Text =
                (
                LogicalOperations.q08(thisYTD, lastYTD, emType, startYear, currentYear)
                ).ToString();

            //#09
            counter = Convert.ToInt32(Input09aTextbox.Text);
            years = Convert.ToInt32(Input09bTextbox.Text);
            Result09Textbox.Text = (
                LogicalOperations.q09(counter, years)
                ).ToString();
            Result09bTextbox.Text = counter.ToString();

            //#10
            int a = Convert.ToInt32(Input10aTextbox.Text);
            int b = Convert.ToInt32(Input10bTextbox.Text);
            int c = Convert.ToInt32(Input10cTextbox.Text);
            int d = Convert.ToInt32(Input10dTextbox.Text);
            //Result10Textbox.Text = (a + b * c - d).ToString();
            Result10Textbox.Text = (
                LogicalOperations.q10(a, b, c, d)
                ).ToString();

            // #11
            bool Prime = Convert.ToBoolean(Input11aTextbox.Text);
            decimal price = Convert.ToInt32(Input11bTextbox.Text);
            float weight = Convert.ToSingle(Input11cTextbox.Text);
            Result11Textbox.Text = LogicalOperations.q11(Prime, price, weight).ToString();

            //#12
            Prime = Convert.ToBoolean(Input12aTextbox.Text);
            price = Convert.ToInt32(Input12bTextbox.Text);
            weight = Convert.ToSingle(Input12cTextbox.Text);
            Result12Textbox.Text = LogicalOperations.q12(Prime, price, weight).ToString();

            // #13
            string State = Input13aTextbox.Text;
            string itemType = Input13bTextbox.Text;
            Result13Textbox.Text = LogicalOperations.q13(State, itemType).ToString();

        }
    }
}
