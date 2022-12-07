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
    /// Logika interakcji dla klasy Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void program_info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Program was createn while learning C#, Xaml and WPF\n\nVersion: 4.2.0", "About Program", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void author_info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Author: Matik", "About author", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void open_layout(object sender, RoutedEventArgs e)
        {

        }

        private void open_binding(object sender, RoutedEventArgs e)
        {

        }

        private void open_calc(object sender, RoutedEventArgs e)
        {

        }
    }
}
