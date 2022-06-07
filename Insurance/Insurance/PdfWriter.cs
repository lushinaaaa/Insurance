using Insurance.Model;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Microsoft.Win32;
using System;
using System.Linq;
using System.Windows;

namespace Insurance
{
    public class MyPdfWriter
    {
        public static void PrintPdf(insurance insurance)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Files | *.pdf";
            if (sfd.ShowDialog() == false) return;

            PdfWriter writer = new PdfWriter(sfd.FileName);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);
            pdf.SetDefaultPageSize(PageSize.A4);

            PdfFont font = PdfFontFactory.CreateFont("C:\\Windows\\Fonts\\Arial.ttf");

            iText.Layout.Element.Image img = new iText.Layout.Element.Image(ImageDataFactory.Create(@"..\..\лого.jpg"))
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
            document.Add(img);

            Paragraph header = new Paragraph("Страховая компания")
            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
            .SetFontSize(20)
            .SetFont(font);

            document.Add(header);

            Paragraph check = new Paragraph("ЧЕК")
            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
            .SetFontSize(20)
            .SetFont(font);
            document.Add(check);

            LineSeparator ls = new LineSeparator(new SolidLine());
            document.Add(ls);

            Table table = new Table(4).SetWidth(UnitValue.CreatePercentValue(100));
            table.SetMarginTop(10);
            table.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);

            Cell header1 = new Cell(1, 1)
            .SetBackgroundColor(ColorConstants.GRAY)
            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
            .SetFontSize(12)
            .SetFont(font)
            .Add(new Paragraph("Страховка"));
            table.AddHeaderCell(header1);

            Cell header2 = new Cell(1, 2)
            .SetBackgroundColor(ColorConstants.GRAY)
            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
            .Add(new Paragraph("Начало"))
            .SetFontSize(12)
            .SetFont(font);
            table.AddHeaderCell(header2);

            Cell header3 = new Cell(1, 3)
            .SetBackgroundColor(ColorConstants.GRAY)
            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
            .Add(new Paragraph("Окончание"))
            .SetFontSize(12)
            .SetFont(font);
            table.AddHeaderCell(header3);
            
            Cell cell1 = new Cell(1, 1)
            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
            .Add(new Paragraph(insurance.insurence))
            .SetFontSize(12)
            .SetFont(font);
            table.AddCell(cell1);

            Cell cell2 = new Cell(1, 2)
            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
            .Add(new Paragraph(insurance.start_date.Value.ToString("dd-MM-yyyy")))
            .SetFontSize(12)
            .SetFont(font);
            table.AddCell(cell2);

            Cell cell3 = new Cell(1, 3)
            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
            .Add(new Paragraph(insurance.end_date.Value.ToString("dd-MM-yyyy")))
            .SetFontSize(12)
            .SetFont(font);
            table.AddCell(cell3);

            document.Add(table);

            using (InsuranceEntities db = new InsuranceEntities())
            {
                insurance_calc calc = db.insurance_calc.First(c => c.id == insurance.id_calculation);

                Paragraph total = new Paragraph($"Цена страховки: {calc.total} руб.")
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                .SetFontSize(16)
                .SetFont(font);
                document.Add(total);
            }

            Paragraph date = new Paragraph($"Даты выдачи чека: {DateTime.Now.ToString("dd:MM:yyyy")}")
            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
            .SetFontSize(12)
            .SetFont(font);
            document.Add(date);

            document.Close();

            App.ShowMessage("Чек сохранен в формате PDF");
        }
    }
}
