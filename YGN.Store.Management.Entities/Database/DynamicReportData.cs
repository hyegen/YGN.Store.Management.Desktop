using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGN.Store.Management.Entities.Database
{
    public class DynamicReportData
    {
        public Dictionary<string, object> Data { get; set; } = new Dictionary<string, object>();
    }
}
