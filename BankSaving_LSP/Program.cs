using System;

namespace BankSaving_LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            SalarySavingAccount salarySavingAccount = new SalarySavingAccount();
            RegularSavingAccount regularSavingAccount = new RegularSavingAccount();
            regularSavingAccount.CalculateInterest();
            salarySavingAccount.CalculateInterest();
        }
    }
}
