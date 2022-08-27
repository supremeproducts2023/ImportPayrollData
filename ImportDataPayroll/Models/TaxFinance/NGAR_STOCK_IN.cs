using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class NGAR_STOCK_IN
    {
        public decimal IN_ID { get; set; }
        public decimal GAR_ID { get; set; }
        public decimal PROD_ID { get; set; }
        public string IN_BY { get; set; }
        public decimal QTY { get; set; }
        public string STK_APPROVE { get; set; }
        public string ENTRYUSER { get; set; }
        public string ENTRYDATE { get; set; }
        public string ENTRYTIME { get; set; }
        public string UPDATEUSER { get; set; }
        public string UPDATEDATE { get; set; }
        public string UPDATETIME { get; set; }
        public decimal UNIT_PRICE { get; set; }

    }
}

