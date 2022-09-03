using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class CPII
    {
        public Decimal? CPII_NO { get; set; }
        public string QUOTNO { get; set; }
        public Decimal? REQNO { get; set; }
        public string C_BRAND { get; set; }
        public string C_CONFIG { get; set; }
        public string C_FREESALE { get; set; }
        public string C_SPEC { get; set; }
        public string C_INSTALL { get; set; }
        public string C_SERVOK { get; set; }
        public string C_PLACE { get; set; }
        public string C_SERV_SERV { get; set; }
        public string C_SERV_SELL { get; set; }
        public string C_INTRAIN { get; set; }
        public string C_OUTTRAIN { get; set; }
        public string C_READY { get; set; }
        public string C_DELIVER { get; set; }
        public Decimal? C_CN { get; set; }
        public string R_BRAND { get; set; }
        public string R_CONFIG { get; set; }
        public string R_FREESALE { get; set; }
        public string R_SPEC { get; set; }
        public string R_INSTALL { get; set; }
        public string R_SERVOK { get; set; }
        public string R_PLACE { get; set; }
        public string R_SERV_SELL { get; set; }
        public string R_SERV_SERV { get; set; }
        public string R_INTRAIN { get; set; }
        public string R_OUTRAIN { get; set; }
        public string R_READY { get; set; }
        public string R_DELIVER { get; set; }
        public Decimal? R_CN { get; set; }
        public string CPII_ADJUST { get; set; }
        public string SALE_MNG_APPR { get; set; }
        public string SERVICE_MNG_APPR { get; set; }
        public Decimal? C_USERMANUAL { get; set; }
        public Decimal? R_USERMANUAL { get; set; }
    }
}
