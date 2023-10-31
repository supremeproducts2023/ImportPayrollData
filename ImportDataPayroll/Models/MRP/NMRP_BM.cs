using System;                
using System.Collections.Generic;                
using System.Linq;                
using System.Text;                
using System.Threading.Tasks;                
                
namespace ImportDataPayroll.Models                
{                
    class NMRP_BM
    {
        public string B_NO { get; set; }
        public DateTime? B_DATE { get; set; }
        public string EMPNO { get; set; }
        public Decimal? STATUS { get; set; }
        public string ROLLBACK_REMARK { get; set; }
        public string DOC_TYPE { get; set; }
        public Decimal? BRANCH_BEGIN { get; set; }
        public Decimal? BRANCH_END { get; set; }
        public string REC_USER { get; set; }
        public DateTime? REC_DATE { get; set; }
        public string LAST_USER { get; set; }
        public DateTime? LAST_DATE { get; set; }
        public DateTime? SENT_TO_DATE { get; set; }         
    }                
}