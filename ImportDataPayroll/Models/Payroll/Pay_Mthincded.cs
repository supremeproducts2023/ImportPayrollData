using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class PAY_MTHINCDED
    {
        public decimal? TMTH_ID { get; set; }
        public string EMP_NO { get; set; }
        public string YEARLY { get; set; }
        public string MONTHLY { get; set; }
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
        public string PROCESSID { get; set; }
        public string FLGUSE { get; set; }
        public string FLGSLIP { get; set; }
        public decimal? TOTAL_SSO_C { get; set; }
        public decimal? TOTAL_PVD_C { get; set; }
        public string EXP_ID { get; set; }
        public string PRNBY { get; set; }
        public decimal? TOTAL_SALARY_SSO { get; set; }
        public decimal? TOTAL_AMOUNT_OLD { get; set; }
        public string FLG_R { get; set; }
        public decimal? TOTAL_AMOUNT_TEMP { get; set; }
    }
}
