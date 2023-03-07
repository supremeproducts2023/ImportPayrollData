using System;                
using System.Collections.Generic;                
using System.Linq;                
using System.Text;                
using System.Threading.Tasks;

namespace ImportDataPayroll.Models.AddCusotmer       
{
    class LOG_CUS_COMMENT        
    {                
 
        public 	Decimal?	RUN_NUM	 { get; set; }
        public 	Decimal?	ID	 { get; set; }
        public 	Decimal?	CUSNO	 { get; set; }
        public 	string 	C_COMMENT	 { get; set; }
        public 	string 	UPDATE_USER	 { get; set; }
        public 	DateTime?	UPDATE_DATETIME	 { get; set; }
        public 	string 	STATUS_LOG	 { get; set; }
        public 	string 	USER_REQUEST	 { get; set; }
        public 	string 	REMARK	 { get; set; }
        public 	DateTime?	C_COMMENTDATE	 { get; set; }   
    }                
}