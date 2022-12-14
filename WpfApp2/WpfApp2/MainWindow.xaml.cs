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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IEnumerable<string> StrColection { get; set; }
        public ObservableCollection<Class1> Class1s { get; set; }
        public Class1 SelectedClass { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            StrColection = "Ala ma kota Kota Ala ma Ma Ala kota Ala ma kota Kota Ala ma Ma Ala kota Ala ma kota Kota Ala ma Ma Ala kota Ala ma kota Kota Ala ma Ma Ala kota Ala ma kota Kota Ala ma Ma Ala kota Ala ma kota Kota Ala ma Ma Ala kota Ala ma kota Kota Ala ma Ma Ala kota Ala ma kota Kota Ala ma Ma Ala kota Ala ma kota Kota Ala ma Ma Ala kota Ala ma kota Kota Ala ma Ma Ala kota Ala ma kota Kota Ala ma Ma Ala kota Ala ma kota Kota Ala ma Ma Ala kota ".Split(" ").ToList();
            DataContext = this; // !!!!!!!!!!!!
            SetClass1s();
            SelectedClass = Class1s[0];
        }
        public void SetClass1s()
        {
            Class1s = new ObservableCollection<Class1>();
            Class1s.Add(new Class1("name1", "desc1", "cat1", 1));
            Class1s.Add(new Class1("name2", "desc2", "cat2", 2));
            Class1s.Add(new Class1("name3", "desc3", "cat3", 3));
            Class1s.Add(new Class1("name4", "desc4", "cat4", 4));
            Class1s.Add(new Class1("name5", "desc5", "cat5", 5));
        }

        private void showSelected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Selected " + SelectedClass.Name, "Selected item");
        }

        private void addNew(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(newScore.Text, out int score))
                Class1s.Add(new Class1(newName.Text, newDescription.Text, newCategory.Text, score));
            else
                MessageBox.Show("Invalid Score!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void editSelected(object sender, RoutedEventArgs e)
        {
            SelectedClass.Name = newName.Text;
            SelectedClass.Description = newDescription.Text;
            SelectedClass.Category = newCategory.Text;
            if (int.TryParse(newScore.Text, out int score))
              SelectedClass.Score = score;
            else
                MessageBox.Show("Invalid Score!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

        }
    }
}
