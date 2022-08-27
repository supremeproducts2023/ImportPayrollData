using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    class PAY_INCDED_IMP
    {
        public string IMPORT_CODE { get; set; }
        public string COM_ID { get; set; }
        public string YEARLY { get; set; }
        public string MONTHLY { get; set; }
        public string EMP_NO { get; set; }
        public decimal? INC_ID { get; set; }
        public string TAXCAL { get; set; }
        public string SSOCAL { get; set; }
        public string PVDCAL { get; set; }
        public decimal? AMOUNT { get; set; }
        public string ENTRYUSER { get; set; }
        public string ENTRYDATE { get; set; }
        public string ENTRYTIME { get; set; }
        public string UPDATEUSER { get; set; }
        public string UPDATEDATE { get; set; }
        public string UPDATETIME { get; set; }
        public string REMARKS { get; set; }
        public string IMPORT_DEPT { get; set; }
        public decimal? REC_ID { get; set; }
        public string FLGUSE { get; set; }
    }
}
