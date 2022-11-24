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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy calcWindow.xaml
    /// </summary>
    public partial class calcWindow : Window
    {
        public calcWindow()
        {
            InitializeComponent();
        }

        private void add(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(number1.Text, out int a) && int.TryParse(number2.Text, out int b))
            {
                result.Text = (a + b).ToString();
            }
            else
            {
                MessageBox.Show("Invalid input!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void sub(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(number1.Text, out int a) && int.TryParse(number2.Text, out int b))
            {
                result.Text = (a - b).ToString();
            }
            else
            {
                MessageBox.Show("Invalid input!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void mull(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(number1.Text, out int a) && int.TryParse(number2.Text, out int b))
            {
                result.Text = (a * b).ToString();
            }
            else
            {
                MessageBox.Show("Invalid input!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
        private void div(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(number1.Text, out int a) && int.TryParse(number2.Text, out int b))
            {
                result.Text = (a / b).ToString();
            }
            else
            {
                MessageBox.Show("Invalid input!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
        private void pow(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(number1.Text, out int a) && int.TryParse(number2.Text, out int b))
            {
                result.Text = Math.Pow(a, b).ToString();
            }
            else
            {
                MessageBox.Show("Invalid input!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void sqrt(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(number1.Text, out int a) && int.TryParse(number2.Text, out int b))
            {
                result.Text = Math.Pow(a, 1.0 / b).ToString();
            }
            else
            {
                MessageBox.Show("Invalid input!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
        private void fact(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(number1.Text, out int a))
            {
                int x = int.Parse(number1.Text);
                int sum = int.Parse(number1.Text);
                while (x > 1)
                {
                    sum *= --x;
                }
                result.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }
        private void mod(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(number1.Text, out int a) && int.TryParse(number2.Text, out int b))
            {
                result.Text = (a % b).ToString();
            }
            else
            {
                MessageBox.Show("Invalid input!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
