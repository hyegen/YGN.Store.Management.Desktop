
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Core.Entities;

namespace YGN.Store.Management.Entities.Database
{
    public class DatabaseConfig : IEntity
    {

        //public int Id { get; set; }
        //public bool Status { get; set; }
        //public string Message { get; set; }
        public int Id { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string Message { get; set; }
        public bool Status  { get; set; }
    }
}
