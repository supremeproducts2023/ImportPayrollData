using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class PAY_EMP_LOAN_TIME
    {
        public decimal LOAN_TIME_ID { get; set; }
        public decimal? EMP_LOAN_ID { get; set; }
        public decimal? TIME_NO { get; set; }
        public string YEARLY { get; set; }
        public string MONTHLY { get; set; }
        public string YEARLY_EFF { get; set; }
        public string MONTHLY_EFF { get; set; }
        public decimal? AMOUNT { get; set; }
        public decimal? INTEREST { get; set; }
        public decimal? TOTAL { get; set; }
        public string STATUS { get; set; }
        public string ENTRYUSER { get; set; }
        public string ENTRYDATE { get; set; }
        public string ENTRYTIME { get; set; }
        public string UPDATEUSER { get; set; }
        public string UPDATEDATE { get; set; }
        public string UPDATETIME { get; set; }
        public string COM_ID { get; set; }
        public string EMPNO { get; set; }
        public string NET { get; set; }
        public decimal? REC_ID { get; set; }
    }
}
