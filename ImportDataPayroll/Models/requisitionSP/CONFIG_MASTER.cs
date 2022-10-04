using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class CONFIG_MASTER
    {
        public Decimal? CONFIG_ID { get; set; }

        public string DETAIL { get; set; }

        public Decimal? NETPRICE { get; set; }

        public Decimal? QTY { get; set; }

        public string UNIT_TYPE { get; set; }

        public string BRAND_ID { get; set; }

        public Decimal? CUSNO { get; set; }

        public Decimal? HOSNO { get; set; }

        public DateTime? EFFECTIVE_DATE { get; set; }
    }
}
