using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class REQ_BETWEEN_MNG
    {
        public Decimal? ID { get; set; }

        public Decimal? REQNO { get; set; }

        public string FROM_MNG { get; set; }

        public string TO_MNG { get; set; }

        public DateTime? SEND_DATE { get; set; }

        public DateTime? APPROVE_DATE { get; set; }
    }
}
