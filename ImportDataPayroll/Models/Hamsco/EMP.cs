using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class EMP
    {
        public string EMPNO { get; set; }

        public string E_TITLE { get; set; }

        public string E_NAME { get; set; }

        public DateTime HIREDATE { get; set; }

        public string DEPTNO { get; set; }

        public string MNGNO { get; set; }

        public string E_JOB { get; set; }

        public string E_SITUATION { get; set; }

        public DateTime QUITDATE { get; set; }

        public string E_MOBILE { get; set; }

        public string E_PAGER { get; set; }

        public string E_EXTENTION { get; set; }

        public string EMP_RECORDER { get; set; }

        public string S_DEPTNO { get; set; }

        public string E_MAIL { get; set; }

        public string E_NAME_EN { get; set; }

        public string E_NICKNAME { get; set; }

        public DateTime REC_DATE { get; set; }

        public string LAST_USER { get; set; }

        public DateTime LAST_DATE { get; set; }

        public Decimal? POSITION_NO { get; set; }

        public string SENT_TO_SAP { get; set; }

        public DateTime SENT_TO_DATE { get; set; }
    }
}
