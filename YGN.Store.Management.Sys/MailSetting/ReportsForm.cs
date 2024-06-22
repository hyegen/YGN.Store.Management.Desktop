using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using YGN.Store.Management.Business.Abstract;
using YGN.Store.Management.Business.Concrete;
using YGN.Store.Management.DataAccess.Concrete.EntityFramework;
using YGN.Store.Management.DataAccess.Context;
using Font = iTextSharp.text.Font;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace YGN.Store.Management.Sys.MailSetting
{
    public partial class ReportsForm : Form
    {
        MailContentManager mailContentManager = new MailContentManager(new EfMailContentDal());
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            var results = mailContentManager.GetStoredProcedures();
            foreach (var item in results)
            {
                checkedListBoxReports.Items.Add(item);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var selectedProcedure = checkedListBoxReports.SelectedItem.ToString();
           
            var parameters = txtParameters.Text;

            var reportData = ExecuteStoredProcedure(selectedProcedure, parameters);
            var pdfContent = GeneratePdf(selectedProcedure, reportData);

            mailContentManager.SavePdfContent(pdfContent);

            MessageBox.Show("PDF içerik başarıyla kaydedildi.");
        }
        public DataTable ExecuteStoredProcedure(string procedureName, string parameters)
        {
            try
            {
                using (var context = new YGNContext())
                {
                    var sqlParameters = parameters.Split(',')
                        .Select(p =>
                        {
                            var parts = p.Split('=');
                            return new SqlParameter(parts[0], parts[1]);
                        })
                        .ToArray();

                    var command = context.Database.Connection.CreateCommand();
                    command.CommandText = procedureName;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(sqlParameters);

                    var adapter = new SqlDataAdapter((SqlCommand)command);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Hata");
                return null;
            }
           return null;
        }
        public byte[] GeneratePdf(string title, DataTable data)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    Document doc = new Document(PageSize.A4);
                    PdfWriter writer = PdfWriter.GetInstance(doc, ms);
                    doc.Open();

                    var bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    var headingFont = new Font(bf, 18, 3);
                    var normalFont = new Font(bf, 10, 3);
                    var boldFont = new Font(bf, 11, 3);

                    Paragraph heading = new Paragraph(title, headingFont);
                    heading.Alignment = Element.ALIGN_CENTER;
                    doc.Add(heading);

                    doc.Add(new Paragraph(" ", normalFont));

                    PdfPTable table = new PdfPTable(data.Columns.Count);

                    // Header
                    foreach (DataColumn column in data.Columns)
                    {
                        table.AddCell(new PdfPCell(new Phrase(column.ColumnName, boldFont)));
                    }

                    // Rows
                    foreach (DataRow row in data.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            table.AddCell(new Phrase(item.ToString(), normalFont));
                        }
                    }

                    doc.Add(table);

                    doc.Close();
                    return ms.ToArray();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
                return null;
            }
            return null;
        }


    }
}
