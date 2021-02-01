using System;
using System.Collections.Generic;
using System.Text;

namespace Invoice_OCP
{
    public class Invoice
    {
        public virtual double GetInvoiceDiscount(double amount)
        {
            //Console.WriteLine(amount - 10);
            return amount - 10;
        }
    }
    public class FinalInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            Console.WriteLine(amount - 50);
            return base.GetInvoiceDiscount(amount) - 50;
        }
    }
    public class ProposedInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            Console.WriteLine(amount - 40);
            return base.GetInvoiceDiscount(amount) - 40;
        }
    }
    public class RecurringInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            Console.WriteLine(amount-30);
            return base.GetInvoiceDiscount(amount) - 30;
        }
    }
}
