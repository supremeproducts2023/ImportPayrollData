using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class PTY_WITHDRAWALS_DAILY
    {
        public int WD_ID { get; set; }
        public string WD_DATE { get; set; }
        public string TYPENO { get; set; }
        public string WD_PAYTO { get; set; }
        public string WD_PO { get; set; }
        public decimal WD_AMOUNT { get; set; }
        public string WD_COMMENT { get; set; }
        public string WSS_ID { get; set; }
        public string WD_BC_DATE { get; set; }
        public string WD_BC_BANK { get; set; }
        public string WD_BC_TRANFERTO { get; set; }
        public string WD_BC_TRANFERFROM { get; set; }
        public string WD_M_DATE { get; set; }
        public string WD_M_EMP { get; set; }
        public string WD_M_PLATE { get; set; }
        public decimal WD_M_OIL { get; set; }
        public decimal WD_M_PENALTY { get; set; }
        public decimal WD_M_MOTORCYCLE { get; set; }
        public decimal WD_M_MD_MOTORCYCLE { get; set; }
        public decimal WD_M_OTHER { get; set; }
        public string ENTRYDATE { get; set; }
        public string ENTRYTIME { get; set; }
        public string ENTRYUSER { get; set; }
        public string UPDATEDATE { get; set; }
        public string UPDATETIME { get; set; }
        public string UPDATEUSER { get; set; }
        public string WD_PAYTO_TYPE { get; set; }
        public string WD_ADVANCE { get; set; }
        public string WD_RECEIPT { get; set; }
        public string WD_STATUS { get; set; }
        public string WD_COMMENT_RETURN { get; set; }
        public string WD_COMMENT_EDIT { get; set; }
        public int WD_ID_REF { get; set; }
        public string WD_PAYTO_BILL { get; set; }
        public string WD_BILL { get; set; }
        public string TYPE_DETAIL { get; set; }
        public string WD_DATE_REF { get; set; }
    }
}

