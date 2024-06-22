using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGN.Store.Management.Business.Abstract
{
    public interface IMailContentService
    {
        void SavePdfContent(byte[] pdfContent);
        List<string> GetStoredProcedures();
    }
}
