using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class PAY_LOAN_DETAIL
    {
        public decimal? LOAN_ID { get; set; }
        public string LOAN_TYPE { get; set; }
        public decimal? LOAN_INCLUDEDIVI { get; set; }
        public string LOAN_UP_FLG { get; set; }
        public string ENTRYUSER { get; set; }
        public string ENTRYDATE { get; set; }
        public string ENTRYTIME { get; set; }
        public string UPDATEUSER { get; set; }
        public string UPDATEDATE { get; set; }
        public string UPDATETIME { get; set; }
        public string LOAN_INCLUDE_FLG { get; set; }
        public string COM_ID { get; set; }
        public string FLG_USE { get; set; }
        public string EXTCODE1 { get; set; }
        public string EXTCODE2 { get; set; }
        public string EXTDESC { get; set; }
    }
}
