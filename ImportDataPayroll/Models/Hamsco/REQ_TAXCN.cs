using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class REQ_TAXCN
    {
        public Decimal? ID { get; set; }

        public string EMPNO { get; set; }

        public Decimal? PERCENT_TAX { get; set; }

        public DateTime START_DATE { get; set; }

        public DateTime END_DATE { get; set; }

        public string RECUSER_ID { get; set; }

        public string REC_DATE { get; set; }

        public Decimal? STATUS { get; set; }
    }
}
