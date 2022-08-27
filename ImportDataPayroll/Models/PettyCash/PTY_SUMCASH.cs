using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class PTY_SUMCASH
    {
        public string SC_ID { get; set; }
        public string SC_BALANCE { get; set; }
        public string COM_ID { get; set; }
        public string SC_DATE { get; set; }
        public string SC_STATUS { get; set; }
        public string ENTRYDATE { get; set; }
        public string ENTRYTIME { get; set; }
        public string ENTRYUSER { get; set; }
        public string UPDATEDATE { get; set; }
        public string UPDATETIME { get; set; }
        public string UPDATEUSER { get; set; }
        public string SC_WSTATUS { get; set; }
        public decimal SC_TOTALBALANCE { get; set; }
        public int FLG_STODAY { get; set; }
        public decimal SC_FORMBALANCE { get; set; }
        public string CUSER { get; set; }
        public string CDATE { get; set; }
        public string CTIME { get; set; }
    }
}

