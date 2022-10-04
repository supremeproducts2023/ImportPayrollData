using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class PRODUCT
    {
        public Decimal? PRODNO { get; set; }

        public string THNAME { get; set; }

        public string ENGNAME { get; set; }

        public string THDESCRIPTION { get; set; }

        public string ENGDESCRIPTION { get; set; }

        public string COMPONENTNAME { get; set; }

        public string MODEL { get; set; }

        public Decimal? PRODPRICE { get; set; }

        public string PROD_TYPE { get; set; }

        public string OBSOLESCENCE { get; set; }

        public DateTime? OBSOLESCENT_DATE { get; set; }

        public string BRAND_ID { get; set; }

        public string P_BRANCHID { get; set; }

        public string AS400PRODNO { get; set; }

        public string PRINC_PRODNO { get; set; }

        public string PROD_COMMENT { get; set; }

        public Decimal? ECRI_GROUPNO { get; set; }

        public string PROD_RECORDER { get; set; }

        public string UNITTYPE { get; set; }

        public string APPROVE_BY { get; set; }

        public string RECUSER_ID { get; set; }

        public DateTime? REC_DATE { get; set; }

        public string LASTUSER_ID { get; set; }

        public DateTime? LAST_DATE { get; set; }

        public DateTime? EFFECTIVE { get; set; }

        public Decimal? FOBPRICE { get; set; }

        public string FOB_PRICEUNIT { get; set; }

        public string PRICE_TYPE { get; set; }

        public Decimal? STATUS { get; set; }

        public string ID_KEEP { get; set; }

        public string SENT_TO_SAP { get; set; }

        public DateTime? SENT_TO_DATE { get; set; }

        public string FOREIGN_ITEM_CODE { get; set; }

        public string FOREIGN_ITEM_NAME { get; set; }

        public Decimal? PARENT_PRODNO { get; set; }

        public string FLAG { get; set; }

        public string DEALER_CODE { get; set; }

        public string DEALER_NAME { get; set; }

        public string DUTY { get; set; }

        public string CLASSIFY { get; set; }

        public Decimal? ITEM_TYPE { get; set; }

        public string FILE_CATALOG { get; set; }

        public string FILE_PIC { get; set; }

        public string FILE_SPEC { get; set; }

        public string FILE_THMANUAL { get; set; }

        public string FILE_ENGMANUAL { get; set; }

        public string FILE_SHOPDRAW { get; set; }

        public string GROUPITEM { get; set; }
    }
}
