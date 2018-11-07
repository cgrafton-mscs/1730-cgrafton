using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cgrafton2G
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // 1A) Switch with no default
            resultSwitch01textbox.Text = Ex2gCalculations.Switch01(input1Atextbox.Text);

            // 1B) Seperate 'if' statements
            resultIf01textbox.Text = Ex2gCalculations.If01(input1Atextbox.Text);

            // 1C) If ElseIf
            resultElseIf01textbox.Text = Ex2gCalculations.ElseIf01(input1Atextbox.Text);

            // 1D) Nested If-Else
            resultNestedIfElse01textbox.Text = Ex2gCalculations.NestedIfElse01(input1Atextbox.Text);

            // 1E) 'Switch' w/ default
            resultSwitchDefault01textbox.Text = Ex2gCalculations.SwitchDefault01(input1Atextbox.Text);

            // 1F) Seperate 'if' statements, default
            resultIfDefault01textbox.Text = Ex2gCalculations.IfDefault01(input1Atextbox.Text);

            // 1G) If ElseIf w/ default
            resultElseIfDefault01textbox.Text = Ex2gCalculations.ElseIfDefault01(input1Atextbox.Text);

            // 1H) Nested If-Else w/ default
            resultNestedIfElseDefault01textbox.Text = Ex2gCalculations.NestedIfElseDefault01(input1Atextbox.Text);

            // 2A) 'Switch' with no default
            resultSwitch02textbox.Text = Ex2gCalculations.Switch02(input2Atextbox.Text);

            // 2B) Separate 'if' statements
            resultIf02textbox.Text = Ex2gCalculations.If02(input2Atextbox.Text);

            // 2C) If ElseIf
            resultElseIf02textbox.Text = Ex2gCalculations.ElseIf02(input2Atextbox.Text);

            // 2D) Nested If-Else
            resultNestedIfElse02textbox.Text = Ex2gCalculations.NestedIfElse02(input2Atextbox.Text);
        }
    }
}
