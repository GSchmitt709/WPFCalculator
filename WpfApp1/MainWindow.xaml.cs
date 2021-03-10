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

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int calc0 = 0;
        public int calc1 = 0;
        public int calc2 = 0;
        public int calcATM = 1;
        public string typecalc = "";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void NumberButton(int x)
        {
            if (calcATM == 1)
            {
                if (calc1 != 0)
                {
                    string strint = Convert.ToString(calc1);
                    strint += Convert.ToString(x);
                    calc1 = Convert.ToInt32(strint);
                }
                else
                {
                    calc1 = x;
                }
                calcLabel.Content = calc1;
            }
            else
            {
                if (calc2 != 0)
                {
                    string strint = Convert.ToString(calc2);
                    strint += Convert.ToString(x);
                    calc2 = Convert.ToInt32(strint);
                }
                else
                {
                    calc2 = x;
                }
                calcLabel.Content = calc2;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {// RESET
            calc0 = 0;
            calc1 = 0;
            calc2 = 0;
            calcLabel.Content = calc0;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NumberButton(1);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NumberButton(2);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            NumberButton(3);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            NumberButton(4);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            NumberButton(5);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            NumberButton(6);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            NumberButton(7);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            NumberButton(8);
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            NumberButton(9);
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {// +
            typecalc = "+";
            calc0 = calc1;
            calcATM = 2;
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {// -
            typecalc = "-";
            calc0 = calc1;
            calcATM = 2;
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {// *
            typecalc = "*";
            calc0 = calc1;
            calcATM = 2;
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {// /
            typecalc = "/";
            calc0 = calc1;
            calcATM = 2;
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {// =
            if (calcATM == 2)
            {
                switch (typecalc)
                {
                    case "+":
                        calc0 += calc2;
                        calcLabel.Content = calc0;
                        calcATM = 1;
                        calc1 = calc0;
                        calc2 = 0;
                        calc0 = 0;
                        break;
                    case "-":
                        calc0 -= calc2;
                        calcLabel.Content = calc0;
                        calcATM = 1;
                        calc1 = calc0;
                        calc2 = 0;
                        calc0 = 0;
                        break;
                    case "*":
                        calc0 *= calc2;
                        calcLabel.Content = calc0;
                        calcATM = 1;
                        calc1 = calc0;
                        calc2 = 0;
                        calc0 = 0;
                        break;
                    case "/":
                        calc0 /= calc2;
                        calcLabel.Content = calc0;
                        calcATM = 1;
                        calc1 = calc0;
                        calc2 = 0;
                        calc0 = 0;
                        break;
                    default:
                        break;
                }
            }
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {// 0
            NumberButton(0);
        }
    }
}
