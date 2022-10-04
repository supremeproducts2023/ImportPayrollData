using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class ORG_ADDR
    {
        public Decimal? ID { get; set; }

        public Decimal? HOSNO { get; set; }

        public string ADDRESS { get; set; }

        public string CITY { get; set; }

        public string PROVINCE { get; set; }

        public string ZIPCODE { get; set; }

        public string ADDR_TYPE { get; set; }

        public string POSTALCODE { get; set; }

        public string TEL_NUMBER { get; set; }

        public string FAX_NUMBER { get; set; }

        public string ORG_RECORDER { get; set; }

        public DateTime? LAST_DATE { get; set; }

        public string LAST_USER { get; set; }

        public Decimal? STATUS { get; set; }
    }
}
