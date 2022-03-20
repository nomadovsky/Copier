using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[assembly: System.Runtime.CompilerServices.InternalsVisibleToAttribute("TestProject2")]

namespace Zadanie_2
{
    class Copier : BaseDevice, IPrinter, IScanner
    {
        public int PrintCounter { get; private set; } = 0;

        public int ScanCounter { get;  private set; } = 0;




        public void Print(in IDocument document)
        {
            if (this.state == 0)
            {
                DateTime date = DateTime.Now;

                Console.WriteLine($"{date} Print: {document.GetFileName()}");

                PrintCounter++;
            }
            

        }

        public void Scan(out IDocument document, IDocument.FormatType formatType = IDocument.FormatType.PDF)
        {
            if (formatType == IDocument.FormatType.PDF) { document = new PDFDocument("aaa"); }
            else if (formatType == IDocument.FormatType.JPG) { document = new ImageDocument("aaa"); }
            else { document = new TextDocument("aaa"); }

            if (this.state == 0)
            {
                DateTime date = DateTime.Now;
                string scanName = $"{document.GetFormatType()}Scan{ScanCounter}.{document.GetFormatType().ToString().ToLower()}";
                Console.WriteLine($"{date} Scan: {scanName}");

                ScanCounter++;
            }
        }

        public void ScanAndPrint()
        {
            if (this.state == 0)
            {
                DateTime date = DateTime.Now;
                string scanName = $"ImageScan{ScanCounter}.jpg";
                Console.WriteLine($"{date} Scan: {scanName}");
                Console.WriteLine($"{date} Print: {scanName}");


                ScanCounter++;
                PrintCounter++;
            }

        }


    }
}
