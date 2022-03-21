namespace Zadanie_3
{
    public class Scanner : IScanner
    {
        public int ScanCounter { get; private set; } = 0;
        public void Scan(out IDocument document, IDocument.FormatType formatType)
        {
            if (formatType == IDocument.FormatType.PDF) { document = new PDFDocument("aaa"); }
            else if (formatType == IDocument.FormatType.JPG) { document = new ImageDocument("aaa"); }
            else { document = new TextDocument("aaa"); }

            DateTime date = DateTime.Now;
            string scanName = $"{document.GetFormatType()}Scan{ScanCounter}.{document.GetFormatType().ToString().ToLower()}";
            Console.WriteLine($"{date} Scan: {scanName}");

            ScanCounter++;
        }
    }

}