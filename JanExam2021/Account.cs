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
        public int InterestRate { get; set; } // surname property

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
}
