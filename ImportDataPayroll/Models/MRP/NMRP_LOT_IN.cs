using System;                
using System.Collections.Generic;                
using System.Linq;                
using System.Text;                
using System.Threading.Tasks;                
                
namespace ImportDataPayroll.Models                
{
    class NMRP_LOT_IN
    {
        public Decimal? IN_ID { get; set; }
        public Decimal? BRANCH { get; set; }
        public Decimal? BOM_CODE { get; set; }
        public Decimal? STATUS { get; set; }
        public Decimal? DOC_RUN { get; set; }
        public string DOC_TYPE { get; set; }
        public string LOT { get; set; }
        public string SERIAL { get; set; }
        public Decimal? COST { get; set; }
        public Decimal? QTY { get; set; }
        public string GAR { get; set; }
        public string PRODUCE_FOR { get; set; }
        public string GWD_USER { get; set; }
        public DateTime? GWD_DATE { get; set; }
        public Decimal? STK_ORDER { get; set; }
        public string STK_USER { get; set; }
        public DateTime? STK_DATE { get; set; }
        public Decimal? IN_ID_M { get; set; }
        public string GARNO { get; set; }
        public Decimal? RM_RUN { get; set; }
        public string T_NO { get; set; }
        public string CHANGE_NO { get; set; }
        public DateTime? STK_COMMIT { get; set; }
    }                
}