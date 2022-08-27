using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class PAY_DECREASETAX
    {
        public decimal? DECREASE_ID { get; set; }
        public string DECREASE_DETAIL { get; set; }
        public decimal? DECREASE_MAX { get; set; }
        public string FLG { get; set; }
        public string ENTRYUSER { get; set; }
        public string ENTRYDATE { get; set; }
        public string ENTRYTIME { get; set; }
        public string UPDATEUSER { get; set; }
        public string UPDATEDATE { get; set; }
        public string UPDATETIME { get; set; }
        public decimal? DECREASE_PERCENT { get; set; }
        public string COM_ID { get; set; }
        public decimal? REF_ID { get; set; }
    }
}
