using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class REQ_TS_GAR_PO
    {
        public Decimal? ID { get; set; }

        public string SERVICE_NO { get; set; }

        public string DOC_NO { get; set; }

        public DateTime DOC_DATE { get; set; }

        public string DOC_TYPE { get; set; }

        public string REC_USER { get; set; }

        public DateTime REC_DATE { get; set; }

        public string LAST_USER { get; set; }

        public DateTime LAST_DATE { get; set; }
    }
}
