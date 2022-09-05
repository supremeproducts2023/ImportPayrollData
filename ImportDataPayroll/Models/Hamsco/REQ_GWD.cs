using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class REQ_GWD
    {
        public Decimal? REQNO { get; set; }

        public string BILLNO { get; set; }

        public DateTime DELIVERY_SEND { get; set; }

        public string NAME_RECEIVED { get; set; }

        public string POSITION_RECEIVED { get; set; }

        public string REMARK_SEND { get; set; }

        public string REMARK { get; set; }

        public Decimal? RESULT_SEND { get; set; }

        public string REC_USER { get; set; }

        public DateTime REC_DATE { get; set; }

        public string EXPECT_DATE { get; set; }

        public DateTime DATE_TO_CUS { get; set; }
    }
}
