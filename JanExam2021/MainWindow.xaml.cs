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

namespace JanExam2021
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CurrentAccount A1 = new CurrentAccount(); // current account 1
            A1.AccountNumber = 0001;
            A1.FirstName = "Daniel";
            A1.Surname = "McGinn";
            CurrentAccount A2 = new CurrentAccount(); // current account 2 
            A2.AccountNumber = 0002;
            A2.FirstName = "John";
            A2.Surname = "Stockton";

            SavingsAccount A3 = new SavingsAccount(); // savings account 1
            A3.AccountNumber = 0003;
            A3.FirstName = "Bruce";
            A3.Surname = "Tully";
            SavingsAccount A4 = new SavingsAccount(); // savings account 2
            A4.AccountNumber = 0004;
            A4.FirstName = "Mary";
            A4.Surname = "McKeown";
        }
    }
}
