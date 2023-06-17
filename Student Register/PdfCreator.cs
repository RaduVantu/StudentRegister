using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using QRCoder;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Student_Register
{
    //this class is used to create the PDF file
    public class PdfCreator
    {
        //new Student and QRCodeGenerator class type instances are created
        private Student studentInfo;
        private QRCodeGenerator qrCodeGenerator = new QRCodeGenerator();        

        //takes the Student type object passed by 'StudentProfile' and stores it in 'studentInfo'
        public PdfCreator(Student student)
        {
            studentInfo = student;
        }

        //creates a .pdf file that stores the QR access code
        public void CreateAndSavePdf(string path)
        {
            //the qrCodeInfo variable is formed from the Student ID and the current date and time
            string qrCodeInfo = studentInfo.StudentId + " on " + DateTime.Now.ToString("dddd, dd MMMM yyyy");

            /*the QR code data is generated using the 'qrCode' value, with medium error correction
            using the QrCoder library, "generate the QR code: https://github.com/codebude/QRCoder"*/
            QRCodeData qrCodeData = qrCodeGenerator.CreateQrCode(qrCodeInfo, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);

            //create bitmap image of 500px size
            Bitmap image = qrCode.GetGraphic(500);

            //transform the image in byte array so we can use it in the pdf file
            byte[] bmpBytes;
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Jpeg);
                bmpBytes = ms.ToArray();
                ms.Close();
            }

            //create the pdf document: https://github.com/QuestPDF/QuestPDF
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.PageColor(Colors.White);

                    page.Content().PaddingVertical(1, Unit.Centimetre).Column(x =>
                        {
                            x.Item().Image(bmpBytes);
                        });
                });
                //and places it in the designated folder (c:\Temporary Codes\)
            }).GeneratePdf(path);
        }
    }
}
