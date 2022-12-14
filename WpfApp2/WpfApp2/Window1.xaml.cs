using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public IEnumerable<string> StrColection { get; set; }
        public ObservableCollection<Food> Foods { get; set; }
        public Food SelectedFood { get; set; }

        public Window1()
        {
            InitializeComponent();

            StrColection = "Ala ma kota Kota Ala ma Ma Ala kota Ala ma kota Kota Ala ma Ma Ala kota Ala ma kota Kota Ala ma Ma Ala kota Ala ma kota Kota Ala ma Ma Ala kota Ala ma kota Kota Ala ma Ma Ala kota Ala ma kota Kota Ala ma Ma Ala kota Ala ma kota Kota Ala ma Ma Ala kota Ala ma kota Kota Ala ma Ma Ala kota Ala ma kota Kota Ala ma Ma Ala kota Ala ma kota Kota Ala ma Ma Ala kota Ala ma kota Kota Ala ma Ma Ala kota Ala ma kota Kota Ala ma Ma Ala kota ".Split(" ").ToList();

            SetupFoods(); // setup data
            DataContext = this; // !!!!!!!!!!!!
        }

        public void SetupFoods()
        {
            Foods = new ObservableCollection<Food>();
            Foods.Add(new Food("1", 1, false));
            Foods.Add(new Food("2", 2, true));
            Foods.Add(new Food("3", 3, false));
            Foods.Add(new Food("4", 4, true));
        }

        private void showSelected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Selected " + SelectedFood.Name, "Selected item");
        }
    }
}
