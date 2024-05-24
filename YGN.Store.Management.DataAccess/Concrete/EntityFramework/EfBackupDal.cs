using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Core.DataAccess.EntityFramework;
using YGN.Store.Management.DataAccess.Abstract;
using YGN.Store.Management.DataAccess.Context;
using YGN.Store.Management.Entities.Backup;
using YGN.Store.Management.Entities.Concrete;

namespace YGN.Store.Management.DataAccess.Concrete.EntityFramework
{
    public class EfBackupDal : EfGenericRepositoryBase<Backup, YGNContext>, IBackupDal
    {
        public Backup BackupDatabase()
        {
            try
            {
                string backupFolderPath = ConfigurationManager.AppSettings["BackupFolderPath"];
                if (string.IsNullOrEmpty(backupFolderPath))
                {
                    var backup = new Backup
                    {
                        Message = "App.config dosyasında yedekleme klasörü yolu belirtilmemiş"
                    };

                    return backup;
                }

                using (var context = new YGNContext())
                {
                    string backupFileName = $"{DateTime.Now:yyyy.MM.dd - HH.mm}-Tarihli-Yedek.bak";
                    string backupFilePath = Path.Combine(backupFolderPath, backupFileName);

                    string backupQuery = $"BACKUP DATABASE [YGNStoreDb2] TO DISK = '{backupFilePath}'";

                    context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, backupQuery);

                    var backup = new Backup
                    {
                        BackupTime = DateTime.Now,
                        Message = $"{DateTime.Now} Tarihinde Veritabanı Yedeği Başarıyla Alınmıştır.",
                        BackupFolderPath = backupFilePath
                    };
                    return backup;
                }
            }
            catch (Exception ex)
            {
                var error = new Backup
                {
                    Message = ex.Message,
                };
                return error;
            }
        }

    }
}
