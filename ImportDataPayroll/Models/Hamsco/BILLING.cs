using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class BILLING
    {
        public string BILLNO { get; set; }
        public DateTime? B_DATE { get; set; }
        public string BILL_DETAIL { get; set; }
        public string B_CREDITTERM { get; set; }
        public DateTime? CUS_RECEIVEDATE { get; set; }
        public string RECEIVEBY { get; set; }
        public string RANK { get; set; }
        public Decimal? BILL_TYPE { get; set; }
        public string BILL_APPR { get; set; }
        public string BILL_REMARK { get; set; }
        public string BILL_STATUS { get; set; }
        public Decimal? REQNO { get; set; }
        public string BILL_RECORDER { get; set; }
        public string GARNO { get; set; }
        public string CUS_NAME { get; set; }
        public string CUS_ADDR { get; set; }
        public Decimal? CUSNO { get; set; }
        public string EDIT_VAC { get; set; }
        public string EDIT_OBJECTIVE { get; set; }
        public DateTime? GAR_DATE { get; set; }
        public string REMARK_CONPO { get; set; }
        public Decimal? STKVAT { get; set; }
        public DateTime? EXPORT_FINDATE { get; set; }
    }
}
