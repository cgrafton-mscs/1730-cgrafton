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

namespace cgrafton3A
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
            resulttextbox0.Text = Ex3aLoops.Calc0(
                inputtextbox0a.Text, inputtextbox0b.Text, inputtextbox0c.Text);

            resulttextbox1.Text = Ex3aLoops.Calc1(
                inputtextbox1a.Text, inputtextbox1b.Text, inputtextbox1c.Text);

            resulttextbox2.Text = Ex3aLoops.Calc2(
                inputtextbox2a.Text, inputtextbox2b.Text, inputtextbox2c.Text);

            resulttextbox3.Text = Ex3aLoops.Calc3(
                inputtextbox3a.Text, inputtextbox3b.Text, inputtextbox3c.Text);

            resulttextbox4.Text = Ex3aLoops.Calc4(
                inputtextbox4a.Text, inputtextbox4b.Text, inputtextbox4c.Text);

            resulttextbox5.Text = Ex3aLoops.Calc5(
                inputtextbox5a.Text, inputtextbox5b.Text, inputtextbox5c.Text);

            resulttextbox6.Text = Ex3aLoops.Calc6(
                inputtextbox6a.Text, inputtextbox6b.Text);

            resulttextbox7.Text = Ex3aLoops.Calc7(
                inputtextbox7a.Text, inputtextbox7b.Text);

            resulttextbox8.Text = Ex3aLoops.Calc8(
                inputtextbox8a.Text, inputtextbox8b.Text);
        }
    }
}
