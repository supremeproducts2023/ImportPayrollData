using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class PAY_JOB_PERIOD
    {
        public decimal? JOB_REC { get; set; }
        public decimal? JOBNO { get; set; }
        public string EMP_NO { get; set; }
        public string JOBDATE_S { get; set; }
        public string JOBDATE_E { get; set; }
        public string FLG { get; set; }
        public string ENTRYUSER { get; set; }
        public string ENTRYDATE { get; set; }
        public string ENTRYTIME { get; set; }
        public string UPDATEUSER { get; set; }
        public string UPDATEDATE { get; set; }
        public string UPDATETIME { get; set; }
        public string REMARKS { get; set; }
        public string COM_ID { get; set; }
    }
}

