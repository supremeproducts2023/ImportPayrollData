using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class PAY_JOB
    {
        public decimal? JOBNO { get; set; }
        public string JOBCODE { get; set; }
        public string JOBNAME { get; set; }
        public string COM_ID { get; set; }
        public string FLG { get; set; }
        public string ENTRYUSER { get; set; }
        public string ENTRYDATE { get; set; }
        public string ENTRYTIME { get; set; }
        public string UPDATEUSER { get; set; }
        public string UPDATEDATE { get; set; }
        public string UPDATETIME { get; set; }
        public string JOB_REMARK { get; set; }

    }
}
