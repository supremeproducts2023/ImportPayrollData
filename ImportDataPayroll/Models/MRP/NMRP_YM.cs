using System;                
using System.Collections.Generic;                
using System.Linq;                
using System.Text;                
using System.Threading.Tasks;                
                
namespace ImportDataPayroll.Models                
{
    class NMRP_YM
    {
        public string Y_NO { get; set; }
        public DateTime? Y_DATE { get; set; }
        public string EMP_NO { get; set; }
        public Decimal? STATUS { get; set; }
        public string ROLLBACK_REMARKS { get; set; }
        public string REC_USER { get; set; }
        public DateTime? REC_DATE { get; set; }
        public string LAST_USER { get; set; }
        public DateTime? LAST_DATE { get; set; }
        public string KICK_USER { get; set; }
        public string GAR_NO { get; set; }
        public Decimal? SUPPLIER_ID { get; set; }
        public Decimal? BRANCH { get; set; }
        public string B_NO { get; set; }
        public string DOC_TYPE { get; set; }
    }                
}