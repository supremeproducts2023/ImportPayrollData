using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class FINANCE_BILL_VENDER
    {
        public decimal ID { get; set; }
        public decimal VENDER_NO { get; set; }
        public string VENDER_NAME { get; set; }
        public string LAST_USER { get; set; }
        public DateTime? LAST_DATE { get; set; }
        public string BILL_PERIOD { get; set; }
        public string FIX_PAY_PLACE { get; set; }

    }
}

