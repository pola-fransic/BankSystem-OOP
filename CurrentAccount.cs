using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    public class CurrentAccount : BankAccount
    {
        public decimal OverdraftLimit { get; set; }

        public override void ShowAccountDetails()
        {
            base.ShowAccountDetails();
            Console.WriteLine($"Overdraft Limit: {OverdraftLimit}");
        }
    }
}