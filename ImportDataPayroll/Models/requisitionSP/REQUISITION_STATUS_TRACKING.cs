using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class REQUISITION_STATUS_TRACKING
    {
        public Decimal? REQNO { get; set; }
        public string OLD_STATUS { get; set; }
        public string NEW_STATUS { get; set; }
        public DateTime? PROCESS_DATE { get; set; }
        public string USERNAME { get; set; }
        public string OS_USER { get; set; }
    }
}
