using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cgrafton2D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSPV_Click(object sender, EventArgs e)
        {
            textBox1input.Text = "Frank";
            textBox2input.Text = "";
            textBox3input.Text = "2.3";
            textBox4input.Text = "false";
            textBox5inputA.Text = "2";
            textBox5inputB.Text = "2";
            textBox6input.Text = "xyz";
            textBox7input.Text = "1";
            textBox8inputA.Text = "1";
            textBox8inputB.Text = "2";
            textBox9input.Text = "500";
            textBox10inputA.Text = "2";
            textBox10inputB.Text = "3";
        }

        private void btnSFV_Click(object sender, EventArgs e)
        {
            textBox1input.Text = "xyz";
            textBox2input.Text = "xyz";
            textBox3input.Text = "2.4";
            textBox4input.Text = "true";
            textBox5inputA.Text = "2";
            textBox5inputB.Text = "3";
            textBox6input.Text = "Jones";
            textBox7input.Text = "0";
            textBox8inputA.Text = "1";
            textBox8inputB.Text = "1";
            textBox9input.Text = "499";
            textBox10inputA.Text = "4";
            textBox10inputB.Text = "3";

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            textBox1resultA.Text = "Fail";
            textBox2resultA.Text = "Fail";
            textBox3resultA.Text = "Fail";
            textBox4resultA.Text = "Fail";
            textBox5resultA.Text = "Fail";
            textBox6resultA.Text = "Fail";
            textBox7resultA.Text = "Fail";
            textBox8resultA.Text = "Fail";
            textBox9resultA.Text = "Fail";
            textBox10resultA.Text = "Fail";

            textBox1resultB.Text = "Pass";
            textBox2resultB.Text = "Pass";
            textBox3resultB.Text = "Pass";
            textBox4resultB.Text = "Pass";
            textBox5resultB.Text = "Pass";
            textBox6resultB.Text = "Pass";
            textBox7resultB.Text = "Pass";
            textBox8resultB.Text = "Pass";
            textBox9resultB.Text = "Pass";
            textBox10resultB.Text = "Pass";

            if (textBox1input.Text == "Frank")
                textBox1resultA.Text = "Pass";
            if (textBox1input.Text != "Frank")
                textBox1resultB.Text = "Fail";

            if (textBox2input.Text == "")
                textBox2resultA.Text = "Pass";
            if (textBox2input.Text != "")
                textBox2resultB.Text = "Fail";

            decimal val3 = Convert.ToDecimal(textBox3input.Text);
            if (val3 == 2.3m)
                textBox3resultA.Text = "Pass";
            if (val3 != 2.3m)
                textBox3resultB.Text = "Fail";

            bool val4 = Convert.ToBoolean(textBox4input.Text);
            if (val4 == false)
                textBox4resultA.Text = "Pass";
            if (val4 != false)
                textBox4resultB.Text = "Fail";

            decimal val5A = Convert.ToDecimal(textBox5inputA.Text);
            decimal val5B = Convert.ToDecimal(textBox5inputB.Text);
            if (val5A == val5B)
                textBox5resultA.Text = "Pass";
            if (val5A != val5B)
                textBox5resultB.Text = "Fail";

            if (textBox6input.Text != "Jones")
                textBox6resultA.Text = "Pass";
            if (textBox6input.Text == "Jones")
                textBox6resultB.Text = "Fail";

            decimal val7 = Convert.ToDecimal(textBox7input.Text);
            if (val7 > 0)
                textBox7resultA.Text = "Pass";
            if (val7 <= 0)
                textBox7resultB.Text = "Fail";

            decimal val8A = Convert.ToDecimal(textBox8inputA.Text);
            decimal val8B = Convert.ToDecimal(textBox8inputB.Text);
            if (val8A < val8B)
                textBox8resultA.Text = "Pass";
            if (val8A >= val8B)
                textBox8resultB.Text = "Fail";

            decimal val9 = Convert.ToDecimal(textBox9input.Text);
            if (val9 >= 500)
                textBox9resultA.Text = "Pass";
            if (val9 < 500)
                textBox9resultB.Text = "Fail";

            decimal val10A = Convert.ToDecimal(textBox10inputA.Text);
            decimal val10B = Convert.ToDecimal(textBox10inputB.Text);
            if (val10A <= val10B)
                textBox10resultA.Text = "Pass";
            if (val10A > val10B)
                textBox10resultB.Text = "Fail";

        }
    }
}
