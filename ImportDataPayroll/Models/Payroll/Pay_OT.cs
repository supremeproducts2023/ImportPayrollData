using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class PAY_OT
    {
        public decimal? OT_ID { get; set; }
        public string OT_TYPE { get; set; }
        public string OTCAL_TYPE { get; set; }
        public string OT_RANGE { get; set; }
        public string OT_UNIT { get; set; }
        public decimal? FLG { get; set; }
        public string COM_ID { get; set; }
        public string ENTRYUSER { get; set; }
        public string ENTRYDATE { get; set; }
        public string ENTRYTIME { get; set; }
        public string UPDATEUSER { get; set; }
        public string UPDATEDATE { get; set; }
        public string UPDATETIME { get; set; }
        public string EXTCODE1 { get; set; }
        public string EXTCODE2 { get; set; }
        public string EXTDESC { get; set; }
    }
}

