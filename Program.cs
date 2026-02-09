using BankSystem;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Bank bank = new()
        {
            Name = "ITI Bank",
            BranchCode = "001"
        };

        Customer c1 = new()
        {
            FullName = "Pola Edward",
            NationalID = "12345678901234",
            DateOfBirth = new DateTime(2003, 5, 1)
        };

        SavingAccount sa = new()
        {
            FullName = c1.FullName,
            InterestRate = 5
        };

        CurrentAccount ca = new() 
        {
            FullName = c1.FullName,
            OverdraftLimit = 2000
        };

        c1.Accounts.Add(sa);
        c1.Accounts.Add(ca);

        bank.AddCustomer(c1);

        foreach (var acc in c1.Accounts)
        {
            acc.ShowAccountDetails();
            Console.WriteLine("----------------");
        }
    }
}
