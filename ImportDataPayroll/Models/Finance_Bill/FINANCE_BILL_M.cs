using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class FINANCE_BILL_M
    {
        public string BILL_NO { get; set; }
        public Decimal COMPANY { get; set; }
        public string SUPPLIER { get; set; }
        public string PAY_PLACE { get; set; }
        public DateTime? PAY_DATE { get; set; }
        public DateTime? REPORT_DATE { get; set; }
        public string REC_USER { get; set; }
        public DateTime? REC_DATE { get; set; }
        public string LAST_USER { get; set; }
        public DateTime? LAST_DATE { get; set; }
        public string REMARKS { get; set; }
        public string BILL_NOSHOW { get; set; }
        public Decimal PRICE_BEFORE_VAT { get; set; }
        public Decimal PERCENT_VAT { get; set; }
        public Decimal VENDER_ID { get; set; }

    }
}

