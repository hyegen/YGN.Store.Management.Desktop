using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
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
        public byte[] GeneratePdf(string title, List<DynamicReportData> data)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Document doc = new Document(PageSize.A4);
                PdfWriter writer = PdfWriter.GetInstance(doc, ms);
                doc.Open();

                Paragraph heading = new Paragraph(title, new Font(Font.FontFamily.HELVETICA, 18, Font.BOLD));
                heading.Alignment = Element.ALIGN_CENTER;
                doc.Add(heading);

                doc.Add(new Paragraph(" ", new Font(Font.FontFamily.HELVETICA, 10)));

                if (data.Count > 0)
                {
                    PdfPTable table = new PdfPTable(data[0].Data.Keys.Count);

                    Font boldFont = new Font(Font.FontFamily.HELVETICA, 11, Font.BOLD);

                    // Add table headers
                    foreach (var key in data[0].Data.Keys)
                    {
                        table.AddCell(new PdfPCell(new Phrase(key, boldFont)));
                    }

                    // Add table rows
                    foreach (var item in data)
                    {
                        foreach (var value in item.Data.Values)
                        {
                            table.AddCell(new Phrase(value?.ToString()));
                        }
                    }

                    doc.Add(table);
                }

                doc.Close();
                return ms.ToArray();
            }
        }
    }
}
