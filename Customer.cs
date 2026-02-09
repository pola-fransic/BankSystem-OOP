using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    public class Customer
    {
        private static int _idCounter = 1;

        public int CustomerID { get; }
        public string FullName { get; set; }
        public string NationalID { get; set; }
        public DateTime DateOfBirth { get; set; }

        public List<BankAccount> Accounts { get; set; }

        public Customer()
        {
            CustomerID = _idCounter++;
            Accounts = new List<BankAccount>();
        }
    }
}