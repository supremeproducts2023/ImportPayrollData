using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class BILL_DETAIL
    {
        public Decimal? REQNO { get; set; }
        public Decimal? PRODNO { get; set; }
        public Decimal? P_QTY { get; set; }
        public Decimal? NETPRICE { get; set; }
        public Decimal? UNIT_LP { get; set; }
        public Decimal? TOTAL_LP { get; set; }
        public Decimal? NETTOTAL { get; set; }
        public string UNITTYPE { get; set; }
        public string P_DETAIL { get; set; }
        public Decimal? BIFO { get; set; }
        public Decimal? ID { get; set; }
        public string BRAND_ID { get; set; }
        public Decimal? CONFIG_ID { get; set; }
        public string MS_PO_CODE { get; set; }
        public string MS_RESERVE_CODE { get; set; }
        public Decimal? REQ_DEPOSIT { get; set; }
        public Decimal? STKPRICEV { get; set; }
        public Decimal? STKNETPRICEV { get; set; }
        public Decimal? STKPRICENV { get; set; }
        public Decimal? STKNETPRICENV { get; set; }
        public Decimal? MAIN_PRODNO { get; set; }
        public Decimal? RENT { get; set; }
    }
}
