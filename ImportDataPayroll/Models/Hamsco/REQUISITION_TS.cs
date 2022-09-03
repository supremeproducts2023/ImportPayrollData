using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class REQUISITION_TS
    {
        public string SERVICE_NO { get; set; }
        public string BRAND_ID { get; set; }
        public string SER_TYPE { get; set; }
        public string IMPO_TYPE { get; set; }
        public string STATUS_REQ { get; set; }
        public string EQU_NAME { get; set; }
        public string EQU_MODEL { get; set; }
        public string EQU_SN { get; set; }
        public Decimal? HOSNO { get; set; }
        public string INVOICE_NO { get; set; }
        public DateTime? INVOICE_DATE { get; set; }
        public string PROBLEM { get; set; }
        public string ACTION { get; set; }
        public string NEED { get; set; }
        public string REMARK { get; set; }
        public string RE_RECBY { get; set; }
        public DateTime? RE_RECDATE { get; set; }
        public string MD_RECBY { get; set; }
        public DateTime? MD_RECDATE { get; set; }
        public string MGR_RECBY { get; set; }
        public DateTime? MGR_RECDATE { get; set; }
        public string SUP_RECBY { get; set; }
        public DateTime? SUP_RECDATE { get; set; }
        public string ENG_RECBY { get; set; }
        public DateTime? ENG_RECDATE { get; set; }
        public string RECORDER_BY { get; set; }
        public DateTime? RECORDER_DATE { get; set; }
        public Decimal? CUSNO { get; set; }
        public string REMARK_EDIT { get; set; }
        public string LAST_USER { get; set; }
        public DateTime? LAST_DATE { get; set; }
        public string PO_NO { get; set; }
        public string GAR_NO { get; set; }
        public string INVOICE_MS { get; set; }
        public DateTime? PO_DATE { get; set; }
        public DateTime? INVOICE_MS_DATE { get; set; }
        public DateTime? GAR_DATE { get; set; }
        public DateTime? ESTIMATE_DATE { get; set; }
        public string REMARK_COMMENT { get; set; }
    }
}
