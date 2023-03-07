using System;                
using System.Collections.Generic;                
using System.Linq;                
using System.Text;                
using System.Threading.Tasks;

namespace ImportDataPayroll.Models.AddCusotmer                
{
    class LOG_PERSON_WORKPLACE        
    {                
        public 	Decimal?	RUN_NUM	 { get; set; }
        public 	Decimal?	ID	 { get; set; }
        public 	Decimal?	CUSNO	 { get; set; }
        public 	Decimal?	HOSNO	 { get; set; }
        public 	string 	DEPTNO	 { get; set; }
        public 	string 	C_POSITION	 { get; set; }
        public 	string 	POSTALCODE	 { get; set; }
        public string TEL_NUMBER { get; set; }
        public string FAX_NUMBER { get; set; }
        public 	string 	UPDATE_USER	 { get; set; }
        public 	DateTime?	UPDATE_DATETIME	 { get; set; }
        public 	string 	STATUS_LOG	 { get; set; }
        public 	string 	USER_REQUEST	 { get; set; }
        public 	string 	REMARK	 { get; set; }
                
    }                
}