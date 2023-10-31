using System;                
using System.Collections.Generic;                
using System.Linq;                
using System.Text;                
using System.Threading.Tasks;                
                
namespace ImportDataPayroll.Models                
{                
    class NMRP_FM
    {
        public string F_NO { get; set; }
        public DateTime? F_DATE { get; set; }
        public string JOBNO { get; set; }
        public string EMPNO { get; set; }
        public Decimal? STATUS { get; set; }
        public string REC_USER { get; set; }
        public DateTime? REC_DATE { get; set; }
        public string LAST_USER { get; set; }
        public DateTime? LAST_DATE { get; set; }
        public string KICK_USER { get; set; }
    }                
}