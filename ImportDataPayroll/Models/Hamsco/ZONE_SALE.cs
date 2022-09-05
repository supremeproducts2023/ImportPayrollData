using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class ZONE_SALE
    {
        public Decimal? ZONE_ID { get; set; }

        public string ZONE_NAME { get; set; }

        public string ZONE_EMPNO { get; set; }

        public string ZONE_ENGINEER { get; set; }

        public string ZONE_MNGNO { get; set; }

        public string REC_USER { get; set; }

        public DateTime REC_DATE { get; set; }
    }
}
