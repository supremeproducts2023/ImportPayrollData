using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class CUSTOMER
    {
        public Decimal? CUSNO { get; set; }

        public string C_TITLE { get; set; }

        public string C_NAME { get; set; }

        public Decimal? OCCUPATION_ID { get; set; }

        public string SPNO { get; set; }

        public DateTime C_BIRTHDAY { get; set; }

        public string C_STATUS { get; set; }

        public string C_SEX { get; set; }

        public string C_MOBILE { get; set; }

        public string C_EMAIL { get; set; }

        public string C_RATING { get; set; }

        public string C_TYPE { get; set; }

        public string C_TAXID { get; set; }

        public string C_AS400ID { get; set; }

        public DateTime C_BUILDDATE { get; set; }

        public Decimal? C_IDCARD { get; set; }

        public string C_RECORDER { get; set; }

        public string SENT_TO_SAP { get; set; }

        public DateTime SENT_TO_DATE { get; set; }

        public string C_UPDATE { get; set; }
    }
}
