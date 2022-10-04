using System;                
using System.Collections.Generic;                
using System.Linq;                
using System.Text;                
using System.Threading.Tasks;                
                
namespace ImportDataPayroll.Models                
{                
    class PO_MASTER
    {                
        public 	string 	PO_NO	 { get; set; }
		public 	DateTime?	PO_DATE	 { get; set; }
		public 	Decimal?	SUPPLIER_ID	 { get; set; }
		public 	string 	YOUR_REF	 { get; set; }
		public 	string 	OUR_REF	 { get; set; }
		public 	string 	DESPATCH_TO	 { get; set; }
		public 	string 	DELIVERY_TIME	 { get; set; }
		public 	string 	PAYMENT	 { get; set; }
		public 	string 	DISCOUNT_PERCENT	 { get; set; }
		public 	Decimal?	DISCOUNT_BAHT	 { get; set; }
		public 	string 	PO_REMARK	 { get; set; }
		public 	string 	PO_STATUS	 { get; set; }
		public 	string 	REC_USER	 { get; set; }
		public 	DateTime?	REC_DATE	 { get; set; }
		public 	string 	LAST_USER	 { get; set; }
		public 	DateTime?	LAST_DATE	 { get; set; }
		public 	string 	FLAG_VAT	 { get; set; }
		public 	string 	FOR_REF	 { get; set; }
		public 	string 	ACCID	 { get; set; }
		public 	string 	COSTID	 { get; set; }
		public 	string 	PO_FILE	 { get; set; }
		public 	string 	PO_FILE2	 { get; set; }
		public 	string 	PO_FILE3	 { get; set; }
		public 	string 	REDHEAD	 { get; set; }
		public 	string 	REDHEADSPECIAL	 { get; set; }
		public 	string 	PO_TYPE	 { get; set; }
		public 	DateTime?	APPROVE_DATE	 { get; set; }
		public 	DateTime?	E_MAIL_DATE	 { get; set; }
		public 	DateTime?	PORTSQL	 { get; set; }
		public 	string 	PAYCODE	 { get; set; }
		public 	string 	REF_PO_NO	 { get; set; }
		public 	string 	PO_COMPANY	 { get; set; }
		public 	DateTime?	DELIVERY_DATE	 { get; set; }
		public 	string 	BOI_FLG	 { get; set; }    
    }                
}