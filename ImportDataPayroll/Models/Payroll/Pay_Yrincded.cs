using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class PAY_YRINCDED
    {
        public decimal? TYR_ID { get; set; }
        public string EMP_NO { get; set; }
        public string YEARLY { get; set; }
        public decimal? TOTAL_INCOME { get; set; }
        public decimal? TOTAL_DEDUCT { get; set; }
        public decimal? TOTAL_TAX { get; set; }
        public decimal? TOTAL_SSO { get; set; }
        public decimal? TOTAL_PVD { get; set; }
        public decimal? TOTAL_AMOUNT { get; set; }
        public string ENTRYUSER { get; set; }
        public string ENTRYDATE { get; set; }
        public string ENTRYTIME { get; set; }
        public string UPDATEUSER { get; set; }
        public string UPDATEDATE { get; set; }
        public string UPDATETIME { get; set; }
        public string COM_ID { get; set; }
        public decimal? TOTAL_SALARY { get; set; }
        public decimal? TOTAL_SSO_C { get; set; }
        public decimal? TOTAL_PVD_C { get; set; }

    }
}

