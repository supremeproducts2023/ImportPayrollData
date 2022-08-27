using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataPayroll.Models
{
    public class SearchQueryParameters
    {
        public string paramName { get; set; }
        public SqlDbType sqlType { get; set; }
        public dynamic Value { get; set; }
    }
}
