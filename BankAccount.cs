using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    public class BankAccount
    {
        
        public const string BankCode = "BNK001";
        public readonly DateTime CreatedDate;

        
        private static int _counter = 1000;
        protected int _accountNumber;
        protected decimal _balance;

        private string _fullName;
        private string _nationalID;
        private string _phoneNumber;
        private string _address;

        
        public string FullName
        {
            get => _fullName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Full name cannot be empty");
                _fullName = value;
            }
        }

        public string NationalID
        {
            get => _nationalID;
            set
            {
                if (value.Length != 14)
                    throw new Exception("National ID must be 14 digits");
                _nationalID = value;
            }
        }

        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                if (!value.StartsWith("01") || value.Length != 11)
                    throw new Exception("Phone number is invalid");
                _phoneNumber = value;
            }
        }

        public string Address
        {
            get => _address;
            set => _address = value;
        }

        public decimal Balance
        {
            get => _balance;
            protected set
            {
                if (value < 0)
                    throw new Exception("Balance cannot be negative");
                _balance = value;
            }
        }

        
        public BankAccount()
        {
            _accountNumber = ++_counter;
            CreatedDate = DateTime.Now;
            Balance = 0;
        }

        public BankAccount(string name, string nid, string phone, string address, decimal balance)
            : this()
        {
            FullName = name;
            NationalID = nid;
            PhoneNumber = phone;
            Address = address;
            Balance = balance;
        }

        public BankAccount(string name, string nid, string phone, string address)
            : this(name, nid, phone, address, 0)
        {
        }

        
        public virtual void ShowAccountDetails()
        {
            Console.WriteLine($"Account Number: {_accountNumber}");
            Console.WriteLine($"Name: {FullName}");
            Console.WriteLine($"Balance: {Balance}");
            Console.WriteLine($"Created At: {CreatedDate}");
        }
    }
}
