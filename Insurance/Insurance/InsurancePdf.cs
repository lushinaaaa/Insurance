using Insurance.Model;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using Microsoft.Win32;
using System;
using System.Linq;
using System.Windows;

namespace Insurance
{
    public class InsurancePdf
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

            iText.Layout.Element.Image img = new iText.Layout.Element.Image(ImageDataFactory.Create(@"..\..\Polis.jpg"))
                 .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                 .SetFixedPosition(0, 0)
                 .ScaleAbsolute(iTextSharp.text.PageSize.A4.Width, iTextSharp.text.PageSize.A4.Height);
            document.Add(img);

            iText.Layout.Element.Image img2 = new iText.Layout.Element.Image(ImageDataFactory.Create(@"..\..\лого.jpg"))
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)
                .ScaleAbsolute(141, 102)
                .SetFixedPosition(47, 700);
            document.Add(img2);

            Paragraph insur = new Paragraph($"{insurance.insurence}")
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)
                .SetFontSize(16)
                .SetFixedPosition(240, 770, 250)
                .SetFont(font);
                document.Add(insur);

            Paragraph date1 = new Paragraph($"Срок страхования с {insurance.start_date.Value.ToString("dd.MM.yyyy")}г. по {insurance.end_date.Value.ToString("dd.MM.yyyy")}г.")
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)
                .SetFontSize(13)
                .SetFixedPosition(250, 703, 300)
                .SetFont(font);
            document.Add(date1);

            Paragraph date2 = new Paragraph($"с {insurance.start_date.Value.ToString("dd.MM.yyyy")}г. по {insurance.end_date.Value.ToString("dd.MM.yyyy")}г.")
               .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)
               .SetFontSize(13)
               .SetFixedPosition(52, 630, 300)
               .SetFont(font);
            document.Add(date2);

            using (InsuranceEntities db = new InsuranceEntities())
            {
                clients cl = db.clients.First(c => c.id == insurance.id_client);

                Paragraph fio = new Paragraph($"{cl.FIO_client}")
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)
                .SetFontSize(14)
                .SetFixedPosition(52, 575, 400)
                .SetFont(font);
                document.Add(fio);
            }

            Paragraph fioS = new Paragraph($"{insurance.car_owner}")
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)
                .SetFontSize(14)
                .SetFixedPosition(52, 528, 400)
                .SetFont(font);
            document.Add(fioS);

            Paragraph model = new Paragraph($"{insurance.car_model}")
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                .SetFontSize(11)
                .SetFixedPosition(80, 468, 80)
                .SetFont(font);
            document.Add(model);

            Paragraph inden = new Paragraph($"{insurance.identification_number}")
               .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)
               .SetFontSize(11)
               .SetFixedPosition(280, 468, 400)
               .SetFont(font);
            document.Add(inden);

            Paragraph reg = new Paragraph($"{insurance.registration_number}")
               .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)
               .SetFontSize(11)
               .SetFixedPosition(482, 468, 400)
               .SetFont(font);
            document.Add(reg);

            Paragraph pts = new Paragraph($"ПТС")
               .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)
               .SetFontSize(11)
               .SetFixedPosition(200, 435, 400)
               .SetFont(font);
            document.Add(pts);

            using (InsuranceEntities db = new InsuranceEntities())
            {
                clients cl = db.clients.First(c => c.id == insurance.id_client);

                Paragraph pts2 = new Paragraph($"{cl.PTS}")
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)
                .SetFontSize(11)
                .SetFixedPosition(490, 435, 400)
                .SetFont(font);
                document.Add(pts2);
            }

            Paragraph n = new Paragraph($"1")
               .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)
               .SetFontSize(11)
               .SetFixedPosition(51, 320, 20)
               .SetFont(font);
            document.Add(n);

            using (InsuranceEntities db = new InsuranceEntities())
            {
                clients cl = db.clients.First(c => c.id == insurance.id_client);

                Paragraph fio2 = new Paragraph($"{cl.FIO_client}")
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)
                .SetFontSize(11)
                .SetFixedPosition(72, 320, 400)
                .SetFont(font);
                document.Add(fio2);
            }

            using (InsuranceEntities db = new InsuranceEntities())
            {
                clients cl = db.clients.First(c => c.id == insurance.id_client);

                Paragraph drive = new Paragraph($"{cl.driving_licence}")
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)
                .SetFontSize(11)
                .SetFixedPosition(385, 320, 400)
                .SetFont(font);
                document.Add(drive);
            }

            using (InsuranceEntities db = new InsuranceEntities())
            {
                insurance_calc calc = db.insurance_calc.First(c => c.id == insurance.id_calculation);

                Paragraph tb = new Paragraph($"{calc.tb}")
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)
                .SetFontSize(11)
                .SetFixedPosition(62, 128, 30)
                .SetFont(font);
                document.Add(tb);

                Paragraph kt = new Paragraph($"{calc.kt}")
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                .SetFontSize(11)
                .SetFixedPosition(117, 128, 20)
                .SetFont(font);
                document.Add(kt);

                Paragraph kbm = new Paragraph($"{calc.kbm}")
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                .SetFontSize(11)
                .SetFixedPosition(160, 128, 20)
                .SetFont(font);
                document.Add(kbm);

                Paragraph kvs = new Paragraph($"{calc.kvs}")
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                .SetFontSize(11)
                .SetFixedPosition(200, 128, 20)
                .SetFont(font);
                document.Add(kvs);

                Paragraph ko = new Paragraph($"{calc.ko}")
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                .SetFontSize(11)
                .SetFixedPosition(243, 128, 20)
                .SetFont(font);
                document.Add(ko);

                Paragraph ks = new Paragraph($"{calc.ks}")
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                .SetFontSize(11)
                .SetFixedPosition(286, 128, 20)
                .SetFont(font);
                document.Add(ks);

                Paragraph q = new Paragraph($"-")
               .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)
               .SetFontSize(11)
               .SetFixedPosition(336, 128, 10)
               .SetFont(font);
                document.Add(q);

                Paragraph km = new Paragraph($"{calc.km}")
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                .SetFontSize(11)
                .SetFixedPosition(369, 128, 20)
                .SetFont(font);
                document.Add(km);

                Paragraph w = new Paragraph($"-")
               .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)
               .SetFontSize(11)
               .SetFixedPosition(421, 128, 10)
               .SetFont(font);
                document.Add(w);

                Paragraph e = new Paragraph($"-")
               .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)
               .SetFontSize(11)
               .SetFixedPosition(463, 128, 10)
               .SetFont(font);
                document.Add(e);

                Paragraph total = new Paragraph($"{calc.total}")
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)
                .SetFontSize(11)
                .SetFixedPosition(512, 128, 200)
                .SetFont(font);
                document.Add(total);
            }

            Paragraph date3 = new Paragraph($"{insurance.start_date.Value.ToString("dd.MM.yyyy")}г.")
              .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)
              .SetFontSize(9)
              .SetFixedPosition(217, 82, 200)
              .SetFont(font);
            document.Add(date3);

            using (InsuranceEntities db = new InsuranceEntities())
            {
                employees emp = db.employees.First(c => c.id == insurance.id_employee);

                Paragraph fio = new Paragraph($"{emp.FIO_insurer}")
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                .SetFontSize(9)
                .SetFixedPosition(400, 30, 120)
                .SetFont(font);
                document.Add(fio);
            }

            Paragraph date4 = new Paragraph($"{insurance.start_date.Value.ToString("dd.MM.yyyy")}г.")
             .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)
             .SetFontSize(9)
             .SetFixedPosition(270, 15, 200)
             .SetFont(font);
            document.Add(date4);

            document.Close();

            App.ShowMessage("Страховой полис сформирован");
        }
    }
}
