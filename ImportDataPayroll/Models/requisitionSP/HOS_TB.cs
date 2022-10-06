using System;                
using System.Collections.Generic;                
using System.Linq;                
using System.Text;                
using System.Threading.Tasks;                
                
namespace ImportDataPayroll.Models                
{                
    class HOS_TB        
    {                
		public 	string 	HOS_ID	 { get; set; }
		public 	string 	HOS_NAME	 { get; set; }
		public 	string 	HOS_ADDR	 { get; set; }
		public 	string 	FLG	 { get; set; }
		public 	string 	REC_USER	 { get; set; }
		public 	DateTime?	REC_DATE	 { get; set; }
		public 	DateTime?	UPDATE_DATE	 { get; set; }
		public 	string 	UPDATE_USER	 { get; set; }
                
    }                
}