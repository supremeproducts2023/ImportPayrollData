using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class PROD_CONFIG_DETAIL
    {
        public Decimal? CONFIG_ID { get; set; }

        public Decimal? PRODNO { get; set; }

        public Decimal? NETPRICE { get; set; }

        public Decimal? QTY { get; set; }

        public string UNIT_TYPE { get; set; }

        public Decimal? NETTOTAL { get; set; }

        public Decimal? K_EXCHANGERATE { get; set; }

        public Decimal? ORDERLIST { get; set; }

        public string CAPABILITY { get; set; }

        public Decimal? PROD_TYPE { get; set; }
    }
}
