using System;
using System.IO;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.IO.Font;
using System.Reflection;
using System.Windows.Forms;

namespace GeneratePdf
{
    public partial class Main : Form
    {
        string test1;
        string test2;



        public Main()
        {
            InitializeComponent();
        }


        public void AddTextToPdf(string inputPath, string outputPath)
        {
            // Uzyskaj strumień do zasobu osadzonego
            using (Stream pdfStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(inputPath))
            {
                if (pdfStream == null)
                {
                    throw new FileNotFoundException($"Zasób {inputPath} nie został znaleziony.");
                }

                // Otwórz istniejący dokument PDF
                PdfDocument pdfDoc = new PdfDocument(new PdfReader(pdfStream), new PdfWriter(outputPath));
                iText.Layout.Document document = new iText.Layout.Document(pdfDoc);

                // Uzyskaj pierwszą stronę dokumentu PDF
                var page = pdfDoc.GetFirstPage();

                // Stwórz obiekt PdfCanvas dla strony
                var canvas = new iText.Kernel.Pdf.Canvas.PdfCanvas(page);

                PdfFont font = PdfFontFactory.CreateFont("C:/Windows/Fonts/arial.ttf", PdfEncodings.IDENTITY_H);

                // Define text to be added
                var text = new Paragraph(test1)
                .SetFontSize(24)
                .SetFont(font)
                .SetBold()
                .SetCharacterSpacing(7.5f)
                .SetFixedPosition(1, 415, 840-152, 140); // Page number, x position, y position, width
                document.Add(text);

                text = new Paragraph(test2)
                    .SetFontSize(26)
                    .SetFont(font)
                    .SetFixedPosition(1, 110, 840 - 342, 140); // Page number, x position, y position, width
                document.Add(text);


                // Close the document
                document.Close();
            }
        }

        private void testPdf_Click_1(object sender, EventArgs e)
        {
            test1 = test1TextBox.Text;
            test2 = test2TextBox.Text;

            string pdfPath1 = "GeneratePdf.BasePDFs.basePdf.pdf";
            string finalPdfOutputPath = "GeneratePdf.Results.result_test.pdf";

            AddTextToPdf(pdfPath1, finalPdfOutputPath);


            PdfPreviewForm previewForm = new PdfPreviewForm(finalPdfOutputPath);
            previewForm.ShowDialog(); // Blokowanie dopóki użytkownik nie zamknie okienka podglądu
        }
    }

}
