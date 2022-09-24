using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class BRAND_EXCHANGE_RATE
    {
        public Decimal? ID { get; set; }

        public string EX_NAME { get; set; }

        public string EX_ABBR { get; set; }

        public Decimal? K { get; set; }

        public string RECUSER_ID { get; set; }

        public DateTime? REC_DATE { get; set; }

        public string LASTUSER_ID { get; set; }

        public DateTime? LAST_DATE { get; set; }

        public Decimal? STATUS { get; set; }

        public DateTime? EFFECTIVE_DATE { get; set; }
    }
}
