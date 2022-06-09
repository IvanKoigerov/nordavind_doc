using System;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Data.OleDb;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace toPdf
{
    class Program
    {
        static void Main(string[] args)
        {
            String toPosition = "Генеральному директору";
            String toName = "Набильской Надежде Владимировне";
            String fromPosition = "системного администратора";
            String fromName = "Колесова Константина Евгеньевича";
            String numberOfDays = "5";
            String dateFrom = "25.05";
            String date = "24.05";
            String place = "Сочи";
            String workingOutDate = "10.06";

            VacationWithoutPayroll(toPosition, toName, fromPosition, fromName, numberOfDays, dateFrom, date, place);
            VacationWithPayroll(toPosition, toName, fromPosition, fromName, numberOfDays, dateFrom, date, place);
            VacationWithWorkingOut(toPosition, toName, fromPosition, fromName, numberOfDays, dateFrom, date, workingOutDate);
            Console.ReadKey();
        }
        static void VacationWithoutPayroll(String toPosition, String toName, String fromPosition, String fromName, 
                                String numberOfDays, String dateFrom, String date, String place)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.TTF");
            var baseFont = BaseFont.CreateFont(ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            var font = new Font(baseFont, 12);

            var document = new Document(PageSize.A4);
            using (var stream = new FileStream("C:/Users/nikit/OneDrive/Desktop/toPdf/VacationWithoutPayroll.pdf", FileMode.Create))
            {
                PdfWriter.GetInstance(document, stream);
                document.Open();
                Paragraph header = new Paragraph(toPosition + "\n" + "ООО «Нордавинд - Дубна»" + "\n" + toName + "\n" + "от " + fromPosition + "\n" + fromName, font);
                header.Alignment = Element.ALIGN_RIGHT;
                document.Add(header);

                document.Add(new Paragraph("\n"));
                document.Add(new Paragraph("\n"));
                document.Add(new Paragraph("\n"));
                document.Add(new Paragraph("\n"));
                document.Add(new Paragraph("\n"));
                document.Add(new Paragraph("\n"));
                document.Add(new Paragraph("\n"));

                font = new Font(baseFont, 17);
                Paragraph h2 = new Paragraph("Заявление.", font);
                h2.Alignment = Element.ALIGN_CENTER;
                document.Add(h2);

                document.Add(new Paragraph("\n"));

                font = new Font(baseFont, 12);
                Paragraph content = new Paragraph("Прошу предоставить мне не оплачиваемый отпуск на " + numberOfDays + " дней с " + dateFrom + ". \nМесто проведения отпуска: " + place + ".", font);
                h2.Alignment = Element.ALIGN_CENTER;
                document.Add(content);

                document.Add(new Paragraph("\n"));

                font = new Font(baseFont, 12);
                Paragraph dateText = new Paragraph("Дата: " + date, font);
                dateText.Alignment = Element.ALIGN_RIGHT;
                document.Add(dateText);

                document.Close();
            }
        }

        static void VacationWithPayroll(String toPosition, String toName, String fromPosition, String fromName,
                                String numberOfDays, String dateFrom, String date, String place)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.TTF");
            var baseFont = BaseFont.CreateFont(ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            var font = new Font(baseFont, 12);

            var document = new Document(PageSize.A4);
            using (var stream = new FileStream("C:/Users/nikit/OneDrive/Desktop/toPdf/VacationWithPayroll.pdf", FileMode.Create))
            {
                PdfWriter.GetInstance(document, stream);
                document.Open();
                Paragraph header = new Paragraph(toPosition + "\n" + "ООО «Нордавинд - Дубна»" + "\n" + toName + "\n" + "от " + fromPosition + "\n" + fromName, font);
                header.Alignment = Element.ALIGN_RIGHT;
                document.Add(header);

                document.Add(new Paragraph("\n"));
                document.Add(new Paragraph("\n"));
                document.Add(new Paragraph("\n"));
                document.Add(new Paragraph("\n"));
                document.Add(new Paragraph("\n"));
                document.Add(new Paragraph("\n"));
                document.Add(new Paragraph("\n"));

                font = new Font(baseFont, 17);
                Paragraph h2 = new Paragraph("Заявление.", font);
                h2.Alignment = Element.ALIGN_CENTER;
                document.Add(h2);

                document.Add(new Paragraph("\n"));

                font = new Font(baseFont, 12);
                Paragraph content = new Paragraph("Прошу предоставить мне оплачиваемый отпуск на " + numberOfDays + " дней с " + dateFrom + ". \nМесто проведения отпуска: " + place + ".", font);
                h2.Alignment = Element.ALIGN_CENTER;
                document.Add(content);

                document.Add(new Paragraph("\n"));

                font = new Font(baseFont, 12);
                Paragraph dateText = new Paragraph("Дата: " + date, font);
                dateText.Alignment = Element.ALIGN_RIGHT;
                document.Add(dateText);

                document.Close();
            }
        }

        static void VacationWithWorkingOut(String toPosition, String toName, String fromPosition, String fromName,
                                String numberOfDays, String dateFrom, String date, String workingOutDate)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.TTF");
            var baseFont = BaseFont.CreateFont(ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            var font = new Font(baseFont, 12);

            var document = new Document(PageSize.A4);
            using (var stream = new FileStream("C:/Users/nikit/OneDrive/Desktop/toPdf/VacationWithWorkingOut.pdf", FileMode.Create))
            {
                PdfWriter.GetInstance(document, stream);
                document.Open();
                Paragraph header = new Paragraph(toPosition + "\n" + "ООО «Нордавинд - Дубна»" + "\n" + toName + "\n" + "от " + fromPosition + "\n" + fromName, font);
                header.Alignment = Element.ALIGN_RIGHT;
                document.Add(header);

                document.Add(new Paragraph("\n"));
                document.Add(new Paragraph("\n"));
                document.Add(new Paragraph("\n"));
                document.Add(new Paragraph("\n"));
                document.Add(new Paragraph("\n"));
                document.Add(new Paragraph("\n"));
                document.Add(new Paragraph("\n"));

                font = new Font(baseFont, 17);
                Paragraph h2 = new Paragraph("Заявление.", font);
                h2.Alignment = Element.ALIGN_CENTER;
                document.Add(h2);

                document.Add(new Paragraph("\n"));

                font = new Font(baseFont, 12);
                Paragraph content = new Paragraph("Прошу предоставить мне отгул на " + numberOfDays + " дней с " + dateFrom + ". \nС последующей отработкой " + workingOutDate+ ".", font);
                h2.Alignment = Element.ALIGN_CENTER;
                document.Add(content);

                document.Add(new Paragraph("\n"));

                font = new Font(baseFont, 12);
                Paragraph dateText = new Paragraph("Дата: " + date, font);
                dateText.Alignment = Element.ALIGN_RIGHT;
                document.Add(dateText);

                document.Close();
            }
        }
    }
}
