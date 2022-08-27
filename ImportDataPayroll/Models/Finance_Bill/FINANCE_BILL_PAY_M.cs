using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class FINANCE_BILL_PAY_M
    {
        public decimal PAY_ID { get; set; }
        public string PAY_NO { get; set; }
        public DateTime? PAY_DATE { get; set; }
        public string LAST_USER { get; set; }
        public DateTime? LAST_DATE { get; set; }
    }
}

