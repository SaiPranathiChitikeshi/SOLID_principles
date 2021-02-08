using System;
using System.Collections.Generic;
using System.Text;

namespace BankSaving_LSP
{
    class SalarySavingAccount:ISaving
    {
        double interest = 0, balance = 1000000;
        public double CalculateInterest()
        {
            interest = balance * 0.5;
            Console.WriteLine(interest);
            return interest;
        }
    }
}
