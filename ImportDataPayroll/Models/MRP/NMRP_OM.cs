using System;                
using System.Collections.Generic;                
using System.Linq;                
using System.Text;                
using System.Threading.Tasks;                
                
namespace ImportDataPayroll.Models                
{                
    class NMRP_OM
    {
        public string JOBNO { get; set; }
        public Decimal? REQNO { get; set; }
        public DateTime? REQDATE { get; set; }
        public string EMPNO { get; set; }
        public Decimal? CUSHOS_NO { get; set; }
        public string DEPTNO { get; set; }
        public string JOB_NAME { get; set; }
        public Decimal? STATUS { get; set; }
        public DateTime? O_DATE { get; set; }
        public string O_EMPNO { get; set; }
        public string O_REMARKS { get; set; }
        public DateTime? MS_CLOSE_DATE { get; set; }
        public string MS_CLOSE_EMPNO { get; set; }
        public string MS_CLOSE_REMARKS { get; set; }
        public DateTime? ACC_CLOSE_DATE { get; set; }
        public string ACC_CLOSE_EMPNO { get; set; }
        public string ACC_CLOSE_REMARKS { get; set; }
        public string REC_USER { get; set; }
        public DateTime? REC_DATE { get; set; }
        public string LAST_USER { get; set; }
        public DateTime? LAST_DATE { get; set; }
        public string AMBU1 { get; set; }
        public string AMBU2 { get; set; }
        public string AMBU3 { get; set; }
        public string AMBU4 { get; set; }
        public string KICK_USER { get; set; }
        public string BOI_FLG { get; set; }              
    }                
}