using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class PAYMENT_METHOD
    {
        public Decimal? PAYMENT_ID { get; set; }

        public string PAYMENT_NAME { get; set; }

        public string PAYMENT_DESCRIPTION { get; set; }

        public string STATUS { get; set; }
    }
}
