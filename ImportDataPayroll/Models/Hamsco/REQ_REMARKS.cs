using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class REQ_REMARKS
    {
        public Decimal? ID { get; set; }

        public Decimal? REQNO { get; set; }

        public string REQ_REMARK { get; set; }

        public DateTime REQ_REMARKDATE { get; set; }

        public string RECUSER_ID { get; set; }

        public string REQ_TO { get; set; }
    }
}
