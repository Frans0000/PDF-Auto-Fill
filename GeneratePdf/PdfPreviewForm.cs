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


        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            // Ensure the PdfViewer releases the file and disposes of resources
            if (pdfViewer != null)
            {
                pdfViewer.Document.Dispose();
                pdfViewer.Dispose();
                pdfViewer = null;
            }

            // Optionally, force garbage collection to ensure all resources are freed
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }


    }
}
