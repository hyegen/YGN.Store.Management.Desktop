using System;
using System.Collections.Generic;
using System.Configuration;
using System.Configuration.Provider;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using YGN.Store.Management.Core.DataAccess.EntityFramework;
using YGN.Store.Management.DataAccess.Abstract;
using YGN.Store.Management.DataAccess.Context;
using YGN.Store.Management.Entities.Concrete;
using YGN.Store.Management.Entities.Database;

namespace YGN.Store.Management.DataAccess.Concrete.EntityFramework
{
    public class EfCreateDatabaseDal : EfGenericRepositoryBase<DatabaseConfig, YGNContext>, ICreateDatabaseDal
    {

    }
}
