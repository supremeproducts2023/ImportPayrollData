using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class REQ_TS_PROD
    {
        public Decimal? ID { get; set; }

        public string SERVICE_NO { get; set; }

        public string PRODNO { get; set; }

        public Decimal? QTY_PROD { get; set; }

        public string DESC_PROD { get; set; }

        public string FOR_MODEL { get; set; }

        public string EQU_PROD { get; set; }

        public string ORDER_CUS_STOCK { get; set; }

        public Decimal? JOBNO { get; set; }

        public Decimal? IN_STOCK { get; set; }

        public Decimal? UNIT_PRICE { get; set; }

        public string REC_USER { get; set; }

        public DateTime? REC_DATE { get; set; }

        public string LAST_USER { get; set; }

        public DateTime? LAST_DATE { get; set; }
    }
}
