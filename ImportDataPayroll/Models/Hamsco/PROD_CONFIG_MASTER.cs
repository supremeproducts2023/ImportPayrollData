using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class PROD_CONFIG_MASTER
    {
        public Decimal? CONFIG_ID { get; set; }

        public string DETAIL { get; set; }

        public Decimal? NETPRICE { get; set; }

        public Decimal? QTY { get; set; }

        public string UNIT_TYPE { get; set; }

        public string RECORD_BY { get; set; }

        public DateTime? RECORD_DATE { get; set; }

        public string BRAND_ID { get; set; }

        public string SET1 { get; set; }

        public Decimal? MASTER_CONFIG { get; set; }

        public Decimal? REFDATA { get; set; }

        public Decimal? VAC { get; set; }

        public Decimal? CONFIG_TYPE { get; set; }

        public string REMARK { get; set; }

        public Decimal? SP_SEMI { get; set; }

        public DateTime? AMBU_SEND_DATE { get; set; }

        public string FILE_STANDARD { get; set; }

        public string FILE_SPECPACK { get; set; }

        public string FILE_TOR { get; set; }

        public string REMARK_MNG { get; set; }

        public string STATUS { get; set; }

        public string APPROVE_BY { get; set; }

        public DateTime? APPROVE_DATE { get; set; }

        public string FLG_MASTER { get; set; }
    }
}
