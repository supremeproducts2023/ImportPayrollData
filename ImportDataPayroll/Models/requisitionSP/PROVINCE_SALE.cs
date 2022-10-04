using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class PROVINCE_SALE
    {
        public Decimal? PROV_ID { get; set; }

        public string PROV_NAME { get; set; }

        public string PROV_ABBR { get; set; }

        public string REC_USER { get; set; }

        public DateTime? REC_DATE { get; set; }

        public Decimal? ZONE_ID { get; set; }

        public string PROV_NAME_EN { get; set; }

        public string PROV_ZONE { get; set; }

        public string ZONE_TS { get; set; }

        public string ID_AS400 { get; set; }

        public string ID_B1 { get; set; }
    }
}
