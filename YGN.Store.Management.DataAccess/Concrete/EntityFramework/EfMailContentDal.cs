using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Core.DataAccess.EntityFramework;
using YGN.Store.Management.DataAccess.Abstract;
using YGN.Store.Management.DataAccess.Context;
using YGN.Store.Management.Entities.Concrete;
using YGN.Store.Management.Entities.Database;

namespace YGN.Store.Management.DataAccess.Concrete.EntityFramework
{
    public class EfMailContentDal : EfGenericRepositoryBase<SendMailContent, YGNContext>, IMailContentDal
    {
        public List<DynamicReportData> GetReportData(string storedProcedure, SqlParameter[] parameters)
        {
            using (var context = new YGNContext())
            {
                var reportDataList = new List<DynamicReportData>();

                using (var command = context.Database.Connection.CreateCommand())
                {
                    command.CommandText = storedProcedure;
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    context.Database.Connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var reportData = new DynamicReportData();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                reportData.Data.Add(reader.GetName(i), reader.GetValue(i));
                            }
                            reportDataList.Add(reportData);
                        }
                    }
                    context.Database.Connection.Close();
                }

                return reportDataList;
            }
        }
        public void SavePdfContent(byte[] pdfContent)
        {
            using (var context = new YGNContext())
            {
                var sendMailContent = new SendMailContent
                {
                    Content = pdfContent,
                    CreatedDate = DateTime.Now,
                   
                };

                context.SendMailContents.Add(sendMailContent);
                context.SaveChanges();
            }
        }
        public List<string> GetStoredProcedures()
        {
            using (var context = new YGNContext())
            {
                var storedProcedures = context.Database.SqlQuery<string>(
                    "SELECT name FROM sys.procedures").ToList();
                return storedProcedures;
            }
        }
    }
}
