using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class PTY_WDRESERVE_DETAIL
    {
        public string WS_ID { get; set; }
        public string WSD_ID { get; set; }
        public string WSD_D_WD { get; set; }
        public string WSD_TYPE { get; set; }
        public decimal WSD_AMOUNT { get; set; }
        public decimal WSD_BALANCE { get; set; }
        public string ENTRYDATE { get; set; }
        public string ENTRYTIME { get; set; }
        public string ENTRYUSER { get; set; }
        public string UPDATEDATE { get; set; }
        public string UPDATETIME { get; set; }
        public string UPDATEUSER { get; set; }
        public string COM_ID { get; set; }
    }
}

