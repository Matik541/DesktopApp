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
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void calc(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(Edge1.Text, out double a) && a > 0)
            {
                error.Text = string.Empty;
                Lenght.Text = (4 * a).ToString();
                Area.Text = (a * a).ToString();
                
            }
            else
            {
                error.Text= "Invalid input!";
            }
        }
    }
}
