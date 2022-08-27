using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class PAY_LOGALERT
    {
        public decimal? ID { get; set; }
        public string D_DATE { get; set; }
        public string T_TIME { get; set; }
        public string DETAIL { get; set; }
        public string COM_ID { get; set; }
        public string EMP { get; set; }
        public string MYEAR { get; set; }
        public string FLG_STATUS { get; set; }
        public decimal? NUM { get; set; }
        public string USERID { get; set; }
        public string LOG_GROUP { get; set; }
    }
}


