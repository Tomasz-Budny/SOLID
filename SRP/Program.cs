using System;
using System.Collections.Generic;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<LineItem> lineItems = new List<LineItem>();
            lineItems.Add(new LineItem("product1", 49.99));
            lineItems.Add(new LineItem("product2", 39.99));
            Invoice invoice = new(lineItems, "John Smith", "Tom Bombadil");

            InvoiceLogger logger = new InvoiceLogger(invoice);
            logger.LogMessage();
        }
    }
}