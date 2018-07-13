using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicesData
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public int CustomerID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public Decimal ProductTotal { get; set; }
        public Decimal SalesTax { get; set; }
        public Decimal Shipping { get; set; }
        public Decimal InvoiceTotal { get; set; }



    }
}
