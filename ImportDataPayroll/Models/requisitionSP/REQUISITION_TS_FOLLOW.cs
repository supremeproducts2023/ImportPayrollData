using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class REQUISITION_TS_FOLLOW
    {
        public Decimal? ID { get; set; }
        public string SERVICE_NO { get; set; }
        public string FOLLOW_DESC { get; set; }
        public DateTime? FOLLOW_DATE { get; set; }
        public string REC_USER { get; set; }
        public string FILE_NAME { get; set; }
    }
}
