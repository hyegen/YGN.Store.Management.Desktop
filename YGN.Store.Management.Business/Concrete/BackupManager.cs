using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Business.Abstract;
using YGN.Store.Management.DataAccess.Abstract;
using YGN.Store.Management.Entities.Backup;

namespace YGN.Store.Management.Business.Concrete
{
    public class BackupManager : IBackupService
    {
        private readonly IBackupDal _backupDal;

        public BackupManager(IBackupDal backupDal)
        {
            _backupDal = backupDal;
        }

        public Backup BackupDatabase()
        {
            return _backupDal.BackupDatabase();
        }
    }
}
