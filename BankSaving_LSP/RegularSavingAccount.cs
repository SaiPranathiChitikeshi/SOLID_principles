using System;
using System.Collections.Generic;
using System.Text;

namespace BankSaving_LSP
{
   public class RegularSavingAccount :ISaving
    {
        double interest = 0, balance = 0, amount = 1000000;
     public  double CalculateInterest()
        {
            interest = balance * 0.4;
            if(balance < 1000) interest -= balance * 0.2;
            if(balance < 50000) interest += amount * 0.4;
            Console.WriteLine(interest);
            return interest;
        }
    }
}
