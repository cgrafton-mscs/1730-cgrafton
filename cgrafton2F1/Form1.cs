using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cgrafton2F1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // #1:if
            Result1textBox.Text = Ex2fCalculations.Calc01(Input1AtextBox.Text);

            // #2:if {block}
            Result2textBox.Text = Ex2fCalculations.Calc02(Input2AtextBox.Text);

            // #3: if else
            Result3textBox.Text = Ex2fCalculations.Calc03(Input3AtextBox.Text);

            // #4: if else if
            Result4textBox.Text = Ex2fCalculations.Calc04(Input4AtextBox.Text);

            // #5: Better range test
            Result5textBox.Text = Ex2fCalculations.Calc05(Input5AtextBox.Text);

            // #6: Nested if else
            Result6textBox.Text = Ex2fCalculations.Calc06(Input6AtextBox.Text, Input6BtextBox.Text);

            // #7: input Validation
            Result7textBox.Text = Ex2fCalculations.Calc07(Input7AtextBox.Text);

            // #8: input Validation, calculate total and shipping
            //     Shipping = $5.00 if total is < $50.00
            Result8textBox.Text = Ex2fCalculations.Calc08(Input8AtextBox.Text, Input8BtextBox.Text);
        }
    }
}
