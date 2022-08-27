using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class PAY_PROVIDENTFUND
    {
        public decimal FUND_ID { get; set; }
        public decimal FOR_EMP { get; set; }
        public decimal FOR_COMPANY { get; set; }
        public string AGEFUND { get; set; }
        public string DENY_FLG { get; set; }
        public string ENTRYUSER { get; set; }
        public string ENTRYDATE { get; set; }
        public string ENTRYTIME { get; set; }
        public string UPDATEUSER { get; set; }
        public string UPDATEDATE { get; set; }
        public string UPDATETIME { get; set; }
        public string COM_ID { get; set; }

    }
}
