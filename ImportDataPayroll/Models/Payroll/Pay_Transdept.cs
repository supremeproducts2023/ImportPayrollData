using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class PAY_TRANSDEPT
    {
        public decimal? TRANS_DEPTID { get; set; }
        public string EMPNO { get; set; }
        public string OLD_DEPT { get; set; }
        public string NEW_DEPT { get; set; }
        public string ENTRYUSER { get; set; }
        public string ENTRYDATE { get; set; }
        public string ENTRYTIME { get; set; }
        public string UPDATEUSER { get; set; }
        public string UPDATEDATE { get; set; }
        public string UPDATETIME { get; set; }
        public string TRANDATE { get; set; }
        public string COM_ID { get; set; }
        public string FLGDELETE { get; set; }

    }
}


