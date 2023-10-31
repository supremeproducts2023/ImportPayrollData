using System;                
using System.Collections.Generic;                
using System.Linq;                
using System.Text;                
using System.Threading.Tasks;                
                
namespace ImportDataPayroll.Models                
{
    class NMRP_PM
    {
        public string P_NO { get; set; }
        public Decimal? BOM_CODE { get; set; }
        public DateTime? P_DATE { get; set; }
        public string P_EMPNO { get; set; }
        public string P_REMARKS { get; set; }
        public string SPEC { get; set; }
        public Decimal? STATUS { get; set; }
        public Decimal? BRANCH { get; set; }
        public DateTime? C_DATE { get; set; }
        public string C_EMPNO { get; set; }
        public string C_REMARKS { get; set; }
        public string REC_USER { get; set; }
        public DateTime? REC_DATE { get; set; }
        public string LAST_USER { get; set; }
        public DateTime? LAST_DATE { get; set; }
        public string KICK_USER { get; set; }
    }                
}