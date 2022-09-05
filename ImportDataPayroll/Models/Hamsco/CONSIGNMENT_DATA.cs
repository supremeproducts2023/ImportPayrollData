using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class CONSIGNMENT_DATA
    {
        public Decimal? CONSI_NO { get; set; }

        public Decimal? HOSNO { get; set; }

        public DateTime CONSI_DATE { get; set; }

        public string PURPOSE { get; set; }

        public string EMPNO { get; set; }

        public string APPRV_BY { get; set; }

        public Decimal? CONSI_STATUS { get; set; }

        public string DE_PICKED_BY { get; set; }

        public DateTime DE_PICKED_DATE { get; set; }

        public string DE_CHECK_BY { get; set; }

        public DateTime DE_CHECK_DATE { get; set; }

        public string DE_RECEIVE_BY { get; set; }

        public DateTime DE_RECEIVE_DATE { get; set; }

        public string RE_DELIVER_BY { get; set; }

        public DateTime RE_DELIVER_DATE { get; set; }

        public string RE_RECEIVE_BY { get; set; }

        public DateTime RE_RECEIVE_DATE { get; set; }

        public string RE_CK_BY { get; set; }

        public DateTime RE_CK_DATE { get; set; }

        public string SALE_RECBY { get; set; }

        public DateTime SALE_RECDATE { get; set; }

        public string DE_STK_RECBY { get; set; }

        public DateTime DE_STK_RECDATE { get; set; }

        public string RE_STK_RECBY { get; set; }

        public DateTime RE_STK_RECDATE { get; set; }

        public string DE_GO_RECBY { get; set; }

        public DateTime DE_GO_RECDATE { get; set; }

        public string RE_GO_RECBY { get; set; }

        public DateTime RE_GO_RECDATE { get; set; }

        public string REMARKS { get; set; }

        public string REMARK_CANCEL { get; set; }

        public DateTime TURN_DATE { get; set; }

        public Decimal? STATUS_BY_GWD { get; set; }

        public string MNG_RECBY { get; set; }

        public DateTime MNG_RECDATE { get; set; }
    }
}
