﻿using System;

namespace CabInvoiceGenerator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to cab invoice generator!");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double fare = invoiceGenerator.CalculateFare(2.0, 5);
            Console.WriteLine("Fare : " + fare);
        }
    }
}
