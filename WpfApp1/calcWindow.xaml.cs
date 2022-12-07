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
            if (int.TryParse(number1.Text, out int a) && int.TryParse(number2.Text, out int b))
                result.Text = (a + b).ToString();
            else
                invalidInput();
        }
        private void sub(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(number1.Text, out int a) && int.TryParse(number2.Text, out int b))
                result.Text = (a - b).ToString();
            else
                invalidInput();
        }
        private void mull(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(number1.Text, out int a) && int.TryParse(number2.Text, out int b))
                result.Text = (a * b).ToString();
            else
                invalidInput();
        }
        private void div(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(number1.Text, out int a) && int.TryParse(number2.Text, out int b))
            {
                if (b == 0)
                {
                    invalidInput();
                    return;
                }
                result.Text = (a / b).ToString();
                return;
            }
            invalidInput();
        }
        private void pow(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(number1.Text, out int a) && int.TryParse(number2.Text, out int b))
                result.Text = Math.Pow(a, b).ToString();
            else
                invalidInput();
        }
        private void sqrt(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(number1.Text, out int a) && int.TryParse(number2.Text, out int b))
                result.Text = Math.Pow(a, 1.0 / b).ToString();
            else
                invalidInput();

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
                MessageBox.Show("Invalid input!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);


        }
        private void mod(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(number1.Text, out int a) && int.TryParse(number2.Text, out int b))
            {
                if (b == 0)
                {
                    invalidInput();
                    return;
                }
                result.Text = (a % b).ToString();
                return;
            }
            invalidInput();

        }

        private void getNWD(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(number1.Text, out int a) && int.TryParse(number2.Text, out int b))
            {
                if (a == 0 && b == 0)
                {
                    invalidInput();
                    return;
                }
                result.Text = nwd(a, b).ToString();
                return;
            }
            invalidInput();
        }
        private void getNWW(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(number1.Text, out int a) && int.TryParse(number2.Text, out int b))
            {
                if (a == 0 && b == 0)
                {
                    invalidInput(); 
                    return;
                }
                int x = a * b;
                result.Text = (x / nwd(a, b)).ToString();
                return;
            }
            invalidInput();
        }
        private void isPrime(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(number1.Text, out int a))
            {
                if(a < 2)
                {
                    MessageBox.Show("There is no prime below 2!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                result.Text = (!primeList(a)[a]).ToString();
                return;
            }
            invalidInput();
        }
        private void getPrimes(object sender, RoutedEventArgs e)
        {

            if (int.TryParse(number1.Text, out int a))
            {
                result.Text = "2";
                bool[] primes = primeList(a, true);
                for (int i = 3; i <= a; i++)
                    if (!primes[i])
                        result.Text += ", " + (i).ToString();
                return;
            }
            invalidInput();
        }

        private int nwd(int x, int y)
        {
            while (y != 0)
            {
                int temp = y % x;
                x = y;
                y = temp;
            }
            return x;
        }
        private bool[] primeList(int upTo, bool include = true)
        {
            bool[] primeArray = new bool[upTo + ((include) ? 1 : 0)];
            for (int i = 0; i <= upTo; i++)
                primeArray[i] = false;

            for (int i = 2; i * i <= upTo; i++)
                if (!primeArray[i])
                    for (int j = i * i; j <= upTo; j += i)
                        primeArray[j] = true;

            return primeArray;
        }
        
        private void invalidInput()
        {
            MessageBox.Show("Invalid input!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
