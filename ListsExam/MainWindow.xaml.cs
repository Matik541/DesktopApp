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

namespace ListsExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<ToDoObject> ToDoList { get; set; }
        
        public MainWindow()
        {
            InitializeComponent();

            exampleToDo();
            DataContext = this;
        }

        public void exampleToDo()
        {
            ToDoList = new ObservableCollection<ToDoObject>();
            ToDoList.Add(new ToDoObject("Wyprowadzenie psa", false, "do 4h"));
            ToDoList.Add(new ToDoObject("Podlej kwiatki", true, "teraz"));
            ToDoList.Add(new ToDoObject("Napisz kod", false, "jutro"));
        }
    }
}
