using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class PROD_CHANGE
    {
        public Decimal? ID { get; set; }

        public Decimal? REQNO { get; set; }

        public Decimal? PNO_OLD { get; set; }

        public string PDETAIL_OLD { get; set; }

        public string UNITTYPE { get; set; }

        public Decimal? PNO_NEW { get; set; }

        public string PDETAIL_NEW { get; set; }

        public Decimal? QTY_OLD { get; set; }

        public Decimal? QTY_NEW { get; set; }

        public string GARNO { get; set; }

        public string UNITTYPE_NEW { get; set; }

        public string PRINC_OLD { get; set; }

        public string PRINC_NEW { get; set; }

        public Decimal? REQNO_OLD { get; set; }

        public string BILLNO { get; set; }
    }
}
