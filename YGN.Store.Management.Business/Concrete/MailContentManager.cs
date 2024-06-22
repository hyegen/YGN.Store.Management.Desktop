using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Business.Abstract;
using YGN.Store.Management.DataAccess.Abstract;

namespace YGN.Store.Management.Business.Concrete
{
    public class MailContentManager : IMailContentService
    {
        private readonly IMailContentDal _mailContentDal;

        public MailContentManager(IMailContentDal mailContentDal)
        {
            _mailContentDal = mailContentDal;
        }

        public List<string> GetStoredProcedures()
        {
            var result = _mailContentDal.GetStoredProcedures();
            if (result != null || result.Count() > 0)
            {
                return result;
            }
            return null;
        }

        public void SavePdfContent(byte[] pdfContent)
        {
            if (pdfContent != null)
            {
                _mailContentDal.SavePdfContent(pdfContent);
            }
            return;
        }
    }
}
