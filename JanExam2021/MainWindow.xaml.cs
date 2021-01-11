/*========================================================================
   # Tristan Reilly
   # S00199625
   # 11/01/2021
   # January Exam OOP
   =======================================================================*/

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
using System.Collections.ObjectModel;

namespace JanExam2021
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Account> accounts = new ObservableCollection<Account>(); // create collection for employees
        ObservableCollection<Account> filteredAccounts = new ObservableCollection<Account>(); // create collection for filtering
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
            A1.Balance = 22000.20m;
            CurrentAccount A2 = new CurrentAccount(); // current account 2 
            A2.AccountNumber = 0002;
            A2.FirstName = "John";
            A2.Surname = "Stockton";
            A2.Balance = 1000m;

            SavingsAccount A3 = new SavingsAccount(); // savings account 1
            A3.AccountNumber = 0003;
            A3.FirstName = "Bruce";
            A3.Surname = "Tully";
            A3.Balance = 5000m;
            SavingsAccount A4 = new SavingsAccount(); // savings account 2
            A4.AccountNumber = 0004;
            A4.FirstName = "Mary";
            A4.Surname = "McKeown";
            A4.Balance = 100000m;

            // add objects to collection
            accounts.Add(A1);
            accounts.Add(A2);
            accounts.Add(A3);
            accounts.Add(A4);

            LBox.ItemsSource = accounts; // listbox shows the collect accounts
        }

        private void LBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Account selectedAccount = LBox.SelectedItem as Account;

            if (selectedAccount != null) // ensure selected item isnt null
            {
                // assign values to textblocks
                FNTBlock.Text = selectedAccount.FirstName;
                SNTBlock.Text = selectedAccount.Surname;
                BTBlock1.Text = selectedAccount.Balance.ToString();
                BTBlock2.Text = selectedAccount.Balance.ToString();
                IDTBlock.Text = selectedAccount.InterestDate.ToString();

                if (selectedAccount is CurrentAccount)
                {
                    ATTBlock.Text = "Current";
                }
                else if (selectedAccount is SavingsAccount)
                {
                    ATTBlock.Text = "Savings";
                }
            }
        }

        private void DepositButton_Click(object sender, RoutedEventArgs e)
        {
            Account selectedAccount = LBox.SelectedItem as Account; // use selcted account
            selectedAccount.TransactionAmount = Convert.ToDecimal(TBox.Text); // get transaction amount from tbox
            selectedAccount.Deposit(); // call deposit method
            BTBlock2.Text = selectedAccount.Balance.ToString(); //display new balance in balance block 2
        }

        private void WithDrawButton_Click(object sender, RoutedEventArgs e)
        {
            Account selectedAccount = LBox.SelectedItem as Account; // use selcted account
            selectedAccount.TransactionAmount = Convert.ToDecimal(TBox.Text);// get transaction amount from tbox
            selectedAccount.Withdraw(); // call withdraw method
            BTBlock2.Text = selectedAccount.Balance.ToString();//display new balance in balance block 2
        }

        private void CBox1_Checked(object sender, RoutedEventArgs e)
        {
            filteredAccounts.Clear(); // clear list
            LBox.ItemsSource = null; // set the List box to display nothing

            if (CBox1.IsChecked == true && CBox2.IsChecked == false) // check which boxes are checked
            {
                foreach (Account account in accounts) // each current is added to filtered list
                {
                    if (account is CurrentAccount)
                        filteredAccounts.Add(account);
                }

                LBox.ItemsSource = filteredAccounts; // get list box to display filtered list
            }
            else if (CBox1.IsChecked == true && CBox1.IsChecked == true) // if both boxes checked
            {
                LBox.ItemsSource = accounts; // get list box to display filtered list
            }
        }

        private void CBox2_Checked(object sender, RoutedEventArgs e)
        {
            filteredAccounts.Clear(); // clear list
            LBox.ItemsSource = null; // set the List box to display nothing

            if (CBox1.IsChecked == false && CBox2.IsChecked == true) // check which boxes are checked
            {
                foreach (Account account in accounts) // each current is added to filtered list
                {
                    if (account is SavingsAccount)
                        filteredAccounts.Add(account);
                }

                LBox.ItemsSource = filteredAccounts; // get list box to display filtered list
            }
            else if (CBox1.IsChecked == true && CBox1.IsChecked == true) // if both boxes checked
            {
                LBox.ItemsSource = accounts; // get list box to display filtered list
            }
        }
    }
}
