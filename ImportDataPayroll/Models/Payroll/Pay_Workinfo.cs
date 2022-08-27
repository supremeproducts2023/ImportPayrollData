using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class PAY_WORKINFO
    {
        public decimal? INFO_ID { get; set; }
        public string EMPNO { get; set; }
        public string W_MONTH { get; set; }
        public string W_YEAR { get; set; }
        public string W_LATE { get; set; }
        public string W_NOSALARY { get; set; }
        public string W_DAYOFF { get; set; }
        public string W_NOENTRY { get; set; }
        public string W_NOEXIT { get; set; }
        public decimal? B_LATE { get; set; }
        public decimal? B_NOSALARY { get; set; }
        public decimal? B_DAYOFF { get; set; }
        public decimal? B_NOENTRY { get; set; }
        public decimal? B_NOEXIT { get; set; }
        public string COM_ID { get; set; }
        public decimal? ENTRYUSER { get; set; }
        public decimal? ENTRYDATE { get; set; }
        public decimal? ENTRYTIME { get; set; }
        public decimal? UPDATEUSER { get; set; }
        public decimal? UPDATEDATE { get; set; }
        public decimal? UPDATETIME { get; set; }
        public decimal? W_TOTAL { get; set; }
        public string FLGCAL { get; set; }
        public decimal? REC_6001 { get; set; }
        public decimal? CAL_SALARY { get; set; }
        public string DATE_CAL { get; set; }
        public decimal? REC_6002 { get; set; }
        public decimal? REC_6003 { get; set; }
        public decimal? REC_6004 { get; set; }
        public decimal? REC_6005 { get; set; }
        public decimal? REC_ID { get; set; }
        public decimal? B_NOSALARYHALF_M { get; set; }
        public decimal? B_NOSALARY_M { get; set; }

    }
}
