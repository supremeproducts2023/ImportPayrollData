using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class Pay_advance
    {
        public string ADV_FIN_DATE { get; set; }
        public string ADV_ACC_DATE { get; set; }
        public string ADV_FIN_NO { get; set; }
        public string EMP_NO { get; set; }
        public string ADV_TYPE { get; set; }

        public string S1_ADV_AMOUNT { get; set; }
        public string S1_EMP_NO { get; set; }
        public string S1_EMP_DATE { get; set; }
        public string BANK_CODE { get; set; }
        public string S2_EMP_NO { get; set; }

        public string S2_EMP_DATE { get; set; }
        public string S3_EMP_NO { get; set; }
        public string S3_EMP_DATE { get; set; }
        public string ADV_STATUS { get; set; }
        public string CLR_ID { get; set; }

        public string CLR_AMOUNT { get; set; }
        public string COM_ID { get; set; }
        public string ENTRYUSER { get; set; }
        public string ENTRYDATE { get; set; }
        public string ENTRYTIME { get; set; }

        public string UPDATEUSER { get; set; }
        public string UPDATEDATE { get; set; }
        public string UPDATETIME { get; set; }
        public string ADV_ACC_NO { get; set; }
        public string ADV_ID { get; set; }

        public string S2_REMARK { get; set; }
        public string S3_REMARK { get; set; }
        public string S4_EMP_NO { get; set; }
        public string S4_EMP_DATE { get; set; }
        public string S4_REMARK { get; set; }

        public string EXP_ID { get; set; }
        public string ADV_TRANFER { get; set; }
        public string TAX_RATE { get; set; }
        public string TAX_AMOUNT { get; set; }
        public string REAL_AMOUNT { get; set; }

        public string S1_REMARK { get; set; }
        public DateTime? DATE_PAY { get; set; }
        public string CHECK_ID { get; set; }
        public string ADV_CE { get; set; }
        public string ADV_CCOMPANY { get; set; }

        public string FLG_RECRIVE_DOCCLEAR { get; set; }
        public string RECRIVE_USER { get; set; }
        public string RECRIVE_DATE { get; set; }
        public string RECRIVE_TIME { get; set; }
        public string EMP_NO_RECIVE { get; set; }

        public string TRANSFER_NAME { get; set; }

    }
}
