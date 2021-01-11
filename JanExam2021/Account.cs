using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanExam2021
{
    public abstract class Account
    {
        public string FirstName { get; set; } // first name property
        public string Surname { get; set; } // surname property
        public decimal Balance { get; set; } // balance property
        public DateTime InterestDate { get; set; } // surname property
        public int AccountNumber { get; set; } // account number property

        public decimal Withdraw() // method to withdraw money
        {
            Balance = Balance - TransactionAmount;
            return Balance;
        }
        public decimal Deposit() // method to deposit money
        {
            Balance = Balance + TransactionAmount;
            return Balance;
        }

        public abstract decimal CalculateIntrest(); // absract method to calc interest
    }

    public class CurrentAccount : Account // inherited class
    {
        public decimal InterestRate = 0.03m; // balance property

        public override decimal CalculateIntrest() // override abstract method calc interest
        {
            Balance = Balance + (Balance * InterestRate); // calculate interest and add to balance
            InterestDate = DateTime.Today; // set the interest date to current date
            return Balance;
        }
    }

    public class SavingsAccount : Account // inherited class
    {
        public decimal InterestRate = 0.06m; // balance property

        public override decimal CalculateIntrest() // override abstract method calc interest
        {
            Balance = Balance + (Balance * InterestRate); // calculate interest and add to balance
            InterestDate = DateTime.Today; // set the interest date to current date
            return Balance;
        }
    }
}
