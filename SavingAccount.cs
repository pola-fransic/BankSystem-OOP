using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    public class SavingAccount : BankAccount
    {
        public decimal InterestRate { get; set; }

        public override void ShowAccountDetails()
        {
            base.ShowAccountDetails();
            Console.WriteLine($"Interest Rate: {InterestRate}%");
        }

        public decimal CalculateInterest()
        {
            return Balance * InterestRate / 100;
        }
    }
}
