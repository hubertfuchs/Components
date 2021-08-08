using System;
using System.IO;
using Fuchsbau.Components.CrossCutting.DataTypes;
using SpirePdf = Spire.Pdf;
using SpirePdfGraphics = Spire.Pdf.Graphics;
using Fuchsbau.Components.CrossCutting.DataTypes.Attributes;
using Fuchsbau.Components.CrossCutting.Logging.Contract;
using Fuchsbau.Components.Logic.GoodsReceivingManagement.Contract;

namespace Fuchsbau.Components.Logic.GoodsReceivingManagement
{
    [Adapter]
    public class DocumentGenerator : IDocumentGenerator
    {
        private readonly ILogger _logger;

        public DocumentGenerator(
            ILogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public DocumentBase Generate(ImageBase image)
        {
            if (image == null)
            {
                throw new ArgumentNullException(nameof(image));
            }

            var spirePdfDocument = new SpirePdf.PdfDocument();
            var pdfSection = spirePdfDocument.Sections.Add();
            var pdfPage = spirePdfDocument.Pages.Add();
            var pdfImage = SpirePdfGraphics.PdfImage.FromFile(Path.Combine(image.Path, image.File));

            float widthFitRate = pdfImage.PhysicalDimension.Width / pdfPage.Canvas.ClientSize.Width;
            float heightFitRate = pdfImage.PhysicalDimension.Height / pdfPage.Canvas.ClientSize.Height;
            float fitRate = Math.Max(widthFitRate, heightFitRate);
            float fitWidth = pdfImage.PhysicalDimension.Width / fitRate;
            float fitHeight = pdfImage.PhysicalDimension.Height / fitRate;

            pdfPage.Canvas.DrawImage(pdfImage, 30, 30, fitWidth, fitHeight);

            string extension = Path.GetExtension(image.File);
            string pdfFile = image.File.Replace(extension, ".pdf");

            spirePdfDocument.SaveToFile(pdfFile, SpirePdf.FileFormat.PDF);
            spirePdfDocument.Close();

            ComplaintDocument complaintDocument = new ComplaintDocument()
            {
                Path = image.Path,
                File = pdfFile,
            };

            return complaintDocument;
        }
    }
}