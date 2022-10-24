using System;
using System.Collections.Generic;

namespace SRP
{
    // Single Responsibility principle - klasa powinna mieć tylko jedno odpowiedzialność 
    // ; powinna odpowiadać tylko za jedną rzecz na raz
    public class Invoice
    {
        public List<LineItem> LineItems { get; set; }
        public string Vendor { get; set; }
        public string Vendee { get; set; }
        public double Total { get; set; }

        public Invoice(List<LineItem> lineItems, string vendor, string vendee)
        {
            LineItems = lineItems;
            Vendee = vendee;
            Vendor = vendor;
            Total = CalculateTotal();
        }

        private double CalculateTotal()
        {
            double total = 0;
            foreach (var lineItem in LineItems)
            {
                total += lineItem.Price;
            }

            return total;
        }
    }

    public class InvoiceLogger
    {
        private readonly Invoice _invoice;

        public InvoiceLogger(Invoice invoice)
        {
            _invoice = invoice;
        }

        public void LogMessage()
        {
            Console.WriteLine($"Vendee: {_invoice.Vendee}");
            Console.WriteLine($"Vendor: {_invoice.Vendor}");
            Console.WriteLine($"Total: {_invoice.Total}");
        }
    }
}