using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class HOSPITAL
    {
        public Decimal? HOSNO { get; set; }

        public string H_TYPEID { get; set; }

        public string H_TITLE { get; set; }

        public string H_NAME { get; set; }

        public string HF_NAME { get; set; }

        public string H_SIZE { get; set; }

        public string H_CUS { get; set; }

        public string H_EMAIL { get; set; }

        public Decimal? H_AS400ID { get; set; }

        public string AS400_TYPE { get; set; }

        public DateTime H_BUILDDATE { get; set; }

        public string H_RATING { get; set; }

        public string H_DIRECTOR { get; set; }

        public string H_OWNER { get; set; }

        public string H_RECORDER { get; set; }

        public Decimal? H_ZONE { get; set; }

        public string SENT_TO_SAP { get; set; }

        public DateTime SENT_TO_DATE { get; set; }

        public Decimal? PK_SAP { get; set; }

        public string TAX_ID { get; set; }

        public string TAX_BRANCH { get; set; }
    }
}
