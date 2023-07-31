using System;                
using System.Collections.Generic;                
using System.Linq;                
using System.Text;                
using System.Threading.Tasks;                
                
namespace ImportDataPayroll.Models                
{
    class NBOM_DESCRIPTION
    {
        public Decimal? BOM_CODE { get; set; }
        public string BOM_CODESHOW { get; set; }
        public string BOM_DESC { get; set; }
        public string BOM_DESC2 { get; set; }
        public Decimal? BOM_COST { get; set; }
        public string BOM_UNIT { get; set; }
        public Decimal? BOM_TYPE { get; set; }
        public Decimal? STD_FLAG { get; set; }
        public string MATERIAL { get; set; }
        public string FINISHSURFACE { get; set; }
        public string SUPPLIER { get; set; }
        public string REVISE { get; set; }
        public string PICTURE_PATH { get; set; }
        public string REMARKS { get; set; }
        public Decimal? PRODNO { get; set; }
        public Decimal? COMP_ID { get; set; }
        public string USED_FLAG { get; set; }
        public string REC_USER { get; set; }
        public DateTime? REC_DATE { get; set; }
        public string LAST_USER { get; set; }
        public DateTime? LAST_DATE { get; set; }
        public string SENT_TO_SAP { get; set; }
        public DateTime? SENT_TO_DATE { get; set; }
        public string PK_SAP { get; set; }
        public string PART_NO { get; set; }
        public string DRAWING_NO { get; set; }
    }                
}