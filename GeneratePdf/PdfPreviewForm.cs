using PdfiumViewer;
using System.Windows.Forms;
using System;


namespace GeneratePdf
{
    public partial class PdfPreviewForm : Form
    {
        private string pdfFilePath;
        private PdfViewer pdfViewer;
        public PdfPreviewForm(string filePath)
        {
            InitializeComponent();
            pdfFilePath = filePath;
            LoadPdf();
        }
        private void LoadPdf()
        {
            pdfViewer = new PdfViewer();
            pdfViewer.Dock = DockStyle.Fill;
            pdfViewer.Document = PdfDocument.Load(pdfFilePath);
            this.Controls.Add(pdfViewer);
        }

    }
}
