using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Business.Abstract;
using YGN.Store.Management.Common.DatabaseHelpers;
using YGN.Store.Management.Common.MaillingHelpers;
using YGN.Store.Management.DataAccess.Abstract;
using YGN.Store.Management.DataAccess.Context;
using YGN.Store.Management.Entities.Concrete;
using YGN.Store.Management.Entities.Views;

namespace YGN.Store.Management.Business.Concrete
{
    public class ReportManager : IReportService
    {
        private readonly IReportDal _reportDal;
        private readonly DatabaseHelper _databaseHelper;
        private readonly PdfManager _pdfManager;
        private readonly YGNContext _context;

        public ReportManager(IReportDal reportDal)
        {
            _reportDal = reportDal;
            _databaseHelper = new DatabaseHelper();
            _pdfManager = new PdfManager();
            _context = new YGNContext();
        }

        public List<StockAmountView> GetStockAmountEachItem()
        {
            var result = _reportDal.GetStockAmountEachItem();
            if (result.Count() <= 0 || result == null)
            {
                return null;
            }
            return result;
        }
        public void SaveReportToDatabase(string reportName, string storedProcedureName, SqlParameter[] parameters = null)
        {
            DataTable data = _databaseHelper.ExecuteStoredProcedure(storedProcedureName, parameters);

            byte[] pdfData = _pdfManager.GeneratePdfReport(reportName, data);

            var report = new Report
            {
                ReportName = reportName,
                BinaryData = pdfData
            };

            _context.Reports.Add(report);
            _context.SaveChanges();
        }
    }
}
