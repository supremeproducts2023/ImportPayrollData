using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class PAY_OFFER_LABORLAW
    {
        public decimal? LABOR_LAWID { get; set; }
        public decimal? QTY_WORKDAY1 { get; set; }
        public decimal? QTY_WORKDAY2 { get; set; }
        public string TYPE_UNIT { get; set; }
        public decimal? QTY_MONTH { get; set; }
        public string ENTRYUSER { get; set; }
        public string ENTRYDATE { get; set; }
        public string ENTRYTIME { get; set; }
        public string UPDATEUSER { get; set; }
        public string UPDATEDATE { get; set; }
        public string UPDATETIME { get; set; }
        public string COM_ID { get; set; }
    }
}
