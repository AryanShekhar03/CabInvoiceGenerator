using System;

namespace CabInvoiceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator");
            InvoiceGeneartor invoiceGeneartor = new InvoiceGeneartor(RideType.Normal);
            double fare = invoiceGeneartor.CalcaulateFare(2.0, 5);
            Console.WriteLine($"Fare : {fare}");
        }
    }
}
