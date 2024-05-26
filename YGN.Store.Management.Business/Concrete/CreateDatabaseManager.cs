using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Business.Abstract;
using YGN.Store.Management.DataAccess.Abstract;
using YGN.Store.Management.Entities.Database;

namespace YGN.Store.Management.Business.Concrete
{
    public class CreateDatabaseManager : ICreateDatabaseService
    {
        private readonly ICreateDatabaseDal _createDatabaseDal;

        public CreateDatabaseManager(ICreateDatabaseDal createDatabaseDal)
        {
            _createDatabaseDal = createDatabaseDal;
        }

    
    }
}
