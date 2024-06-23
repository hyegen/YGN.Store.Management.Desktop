using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using YGN.Store.Management.Entities.Database;

namespace YGN.Store.Management.Common.MaillingHelpers
{
    public class PdfManager
    {
        public byte[] GeneratePdfReport(string reportName, DataTable dataTable)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Document document = new Document(PageSize.A4);
                PdfWriter.GetInstance(document, ms);
                document.Open();

                // Rapor ismini ekle
                Paragraph title = new Paragraph(reportName, new Font(Font.FontFamily.HELVETICA, 18, Font.BOLD));
                title.Alignment = Element.ALIGN_CENTER;
                document.Add(title);

                // Tabloyu oluştur
                PdfPTable table = new PdfPTable(dataTable.Columns.Count);

                // Başlıkları ekle
                foreach (DataColumn column in dataTable.Columns)
                {
                    table.AddCell(column.ColumnName);
                }

                // Veriyi tabloya ekle
                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (var cell in row.ItemArray)
                    {
                        table.AddCell(cell.ToString());
                    }
                }

                document.Add(table);
                document.Close();

                return ms.ToArray();
            }
        }
    }
}
