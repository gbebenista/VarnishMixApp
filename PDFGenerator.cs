using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;


namespace VarnishMixApp
{

    public class PDFGenerator
    {
        //private static PdfFont helvetica = null;
        public static void Generate(DataTable data)
        {
            string genTime = DateTime.Today.ToShortDateString();
            string filename = "Proporcje " + genTime + " .pdf";

            try
            {

                using (var folderBrowserDialog = new FolderBrowserDialog())
                {
                    DialogResult result = folderBrowserDialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        string filepath = folderBrowserDialog.SelectedPath + "\\" + filename;
                        if (File.Exists(filepath))
                        {
                            MessageBox.Show("Taki plik już istnieje. Proszę usunąć (bądź zmienić nazwę) plik i spróbować ponownie");
                            return;
                        }
                        else
                        {
                            string exportFile = Path.Combine(folderBrowserDialog.SelectedPath, filename);
                            PdfWriter pdfWriter = new PdfWriter(exportFile);
                            PdfDocument pdfDocument = new PdfDocument(pdfWriter);
                            Document document = new Document(pdfDocument);

                            Paragraph header = new Paragraph("Proporcje składników lakieru bla bla")
                               .SetTextAlignment(TextAlignment.CENTER)
                               .SetFontSize(20);

                            document.Add(new Paragraph(genTime));
                            document.Add(header);
                            document.Add(toTable(data));

                            document.Add(header);
                            document.Close();

                            MessageBox.Show("Pomyślnie wygenerowano plik z proporcjami");
                        }
                    }
                }
            }

            catch (Exception e)
            {
                Console.Write(e);
                MessageBox.Show("Wystąpił problem z wygenerowaniem pliku z propoocjami. Proszę spróbować ponownie");
            }

        }


        private static Table toTable(DataTable data)
        {
            //resetFont();
            try
            {
                Table result = new Table(data.Columns.Count);
                result.UseAllAvailableWidth();
                foreach (DataColumn column in data.Columns)
                {
                    result.AddHeaderCell(new Paragraph(column.ColumnName).SetFontSize(11).SetBold());
                }
                foreach (DataRow row in data.Rows)
                {
                    for (int i = 0; i < data.Columns.Count; i++)
                    {
                        result.AddCell(new Paragraph(row[i].ToString()).SetFontSize(8));
                    }

                }
                return result;
            }

            catch(Exception e)
            {
                Console.Write(e.Message);
                return null;
            }
        }

        //private static void resetFont() // funkcja tworzy nową czcionke ponieważ pdffont przypisuje się do dokumentu pdf co uniemożliwia użycia jej w innym pdf'ie
        //{
        //    helvetica = PdfFontFactory.CreateFont(StandardFonts.HELVETICA, "CP1250");
        //}
    }
}
