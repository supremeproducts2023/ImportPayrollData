using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class REQ_GWD_REF
    {
        public Decimal? ID { get; set; }

        public Decimal? REQNO { get; set; }

        public string LOT_NO { get; set; }

        public string SERIAL_NO { get; set; }

        public string REF_NO { get; set; }

        public DateTime? EXPIRE_DATE { get; set; }

        public string REMARK { get; set; }

        public Decimal? ID_BILLNO { get; set; }
    }
}
