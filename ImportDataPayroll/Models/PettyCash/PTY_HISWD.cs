using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class PTY_HISWD
    {
        public int HIS_ID { get; set; }
        public string WS_ID { get; set; }
        public decimal? HIS_AMOUNT { get; set; }
        public decimal? HIS_SUBAMOUNT { get; set; }
        public decimal? HIT_PLUSAMOUNT { get; set; }
        public string ENTRYDATE { get; set; }
        public string ENTRYTIME { get; set; }
        public string UPDATEDATE { get; set; }
        public string UPDATETIME { get; set; }
        public string ENTRYUSER { get; set; }
        public decimal? HIS_SAMOUNT { get; set; }
    }
}

