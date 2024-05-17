using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Entities.Backup;

namespace YGN.Store.Management.Business.Abstract
{
    public interface IBackupService
    {
        Backup BackupDatabase();
    }
}
