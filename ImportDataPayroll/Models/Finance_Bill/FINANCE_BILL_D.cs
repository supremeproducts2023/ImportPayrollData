using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class FINANCE_BILL_D
    {
        public string BILL_NO { get; set; }
        public decimal ID { get; set; }
        public string INVOICE { get; set; }
        public DateTime? INVOICE_DATE { get; set; }
        public decimal INVOICE_PRICE { get; set; }
        public decimal AMOUNT_TAX1 { get; set; }
        public decimal TAX_RATE1 { get; set; }
        public decimal AMOUNT_TAX2 { get; set; }
        public decimal TAX_RATE2 { get; set; }
    }
}

