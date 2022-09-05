using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class CONSIGNMENT_PROD
    {
        public Decimal? CONSI_NO { get; set; }

        public Decimal? PRODNO { get; set; }

        public string PROD_DETAIL { get; set; }

        public Decimal? PROD_QTY { get; set; }

        public Decimal? UNIT_PRICE { get; set; }

        public string UNITTYPE { get; set; }

        public string REMARKS { get; set; }

        public Decimal? NUM_TOTAL { get; set; }

        public Decimal? NUM_RETURN { get; set; }

        public string REC_UPDATE { get; set; }

        public DateTime DATE_UPDATE { get; set; }

        public string RETURN_RECORD { get; set; }

        public Decimal? GWD_PLACE { get; set; }

        public Decimal? CHECK_STATUS { get; set; }

        public DateTime DUAL_DATE { get; set; }

        public Decimal? COST { get; set; }

        public string REMARK_STOCK { get; set; }
    }
}
