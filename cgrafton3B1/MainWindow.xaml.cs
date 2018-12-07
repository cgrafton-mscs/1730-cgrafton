using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cgrafton3B1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calcbtn_Click(object sender, RoutedEventArgs e)
        {
            //0 Calculate DiscountPercent
            try
            {

                decimal subtotal = Decimal.Parse(this.inputtextbox0a.Text);
                decimal discountpercent = Ex3bCalculations.GetDiscountPercent(subtotal);
                resulttextbox0.Text = discountpercent.ToString("f3");
            }
            catch
            {
                resulttextbox0.Text = "";
                MessageBox.Show("Invalid Input: " + this.inputtextbox0a.Text);
            }
            //1 Calculate DiscountPercent using output arguement
            try
            {

                decimal subtotal = Decimal.Parse(this.inputtextbox1a.Text);
                decimal discountpercent;
                    Ex3bCalculations.GetDiscountPercent(subtotal, out discountpercent);
                resulttextbox1.Text = discountpercent.ToString("f3");
            }
            catch
            {
                resulttextbox1.Text = "";
                MessageBox.Show("Invalid Input: " + this.inputtextbox1a.Text);
            }
            //2 Calculate futureValue
            try
            {
                int months = Int32.Parse(this.inputtextbox2a.Text);
                decimal monthlyInvestment = Decimal.Parse(this.inputtextbox2b.Text);
                decimal monthlyIntrestRate = Decimal.Parse(this.inputtextbox2c.Text);
                decimal futureValue = Ex3bCalculations.CalculateFutureValue(monthlyInvestment, monthlyIntrestRate, months);
                resulttextbox2.Text = futureValue.ToString("c2");
            }
            catch
            {
                resulttextbox2.Text = "";
                MessageBox.Show("Invalid Input:\n"
                    + this.inputtextbox2a.Text + "\n"
                    + this.inputtextbox2b.Text + "\n"
                    + this.inputtextbox2c.Text + "\n");
            }
            //3 Calculate futureValue using ref arguement
            try
            {
                int months = Int32.Parse(this.inputtextbox3a.Text);
                decimal monthlyInvestment = Decimal.Parse(this.inputtextbox3b.Text);
                decimal monthlyIntrestRate = Decimal.Parse(this.inputtextbox3c.Text);
                decimal futureValue = 0m;
                Ex3bCalculations.CalculateFutureValue(
                    monthlyInvestment, monthlyIntrestRate, months, ref futureValue);
                resulttextbox3.Text = futureValue.ToString("c2");
            }
            catch
            {
                resulttextbox3.Text = "";
                MessageBox.Show("Invalid Input:\n"
                    + this.inputtextbox3a.Text + "\n"
                    + this.inputtextbox3b.Text + "\n"
                    + this.inputtextbox3c.Text + "\n");
            }
            //4 Calculate Degrees Celsius
            try
            {

                double fahrenheit = Double.Parse(this.inputtextbox4a.Text);
                double celsius = Ex3bCalculations.FahrenheitToCelsius(fahrenheit);
                resulttextbox4.Text = celsius.ToString("f1");
            }
            catch
            {
                resulttextbox4.Text = "";
                MessageBox.Show("Invalid Input: " + this.inputtextbox4a.Text);
            }
            //5 Calculate Degrees Fahrenheit
            try
            {

                double celsius = Double.Parse(this.inputtextbox5a.Text);
                double fahrenheit;
                Ex3bCalculations.CelsiusToFahrenheit(celsius, out fahrenheit);
                resulttextbox5.Text = fahrenheit.ToString("f1");
            }
            catch
            {
                resulttextbox5.Text = "";
                MessageBox.Show("Invalid Input: " + this.inputtextbox5a.Text);
            }
            //6 GrossPay
            try
            {
                decimal hours = Decimal.Parse(this.inputtextbox6a.Text);
                decimal rate = Decimal.Parse(this.inputtextbox6b.Text);
                this.resulttextbox6.Text = Ex3bCalculations.GrossPay(hours, rate).ToString("c2");
            }
            catch
            {
                resulttextbox6.Text = "";
                MessageBox.Show("Invalid input: \n"
                    + this.inputtextbox6a.Text + "\n"
                    + this.inputtextbox6b.Text + "\n");
            }
            //7 TotalHours
            try
            {
                this.resulttextbox7.Text =
                    Ex3bCalculations.TotalHours(this.inputtextbox7a.Text).ToString("n2");
            }
            catch
            {
                this.resulttextbox7.Text = " ";
                MessageBox.Show("Invalid input: " + this.inputtextbox7a.Text);
            }
        }
    }
}
