using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    public class Bank
    {
        public string Name { get; set; }
        public string BranchCode { get; set; }

        public List<Customer> Customers { get; set; }

        public Bank()
        {
            Customers = new List<Customer>();
        }

        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }

        public Customer FindCustomerByNationalID(string nid)
        {
            return Customers.FirstOrDefault(c => c.NationalID == nid);
        }
    }
}