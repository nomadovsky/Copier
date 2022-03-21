using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    internal class MultifunctionalDevice: BaseDevice
    {
        Printer printer = new Printer();
        Scanner scanner = new Scanner();
        FaxDevice fax = new FaxDevice();
        public int PrintCounter { get => printer.PrintCounter; }
        public int ScanCounter { get => scanner.ScanCounter; }
        public int FaxCounter { get => fax.FaxCounter; }

        public void Print(in IDocument document)
        {
            if (this.state == 0)
            {
                printer.Print(document);
            }
        }
        public void Scan(out IDocument document, IDocument.FormatType formatType = IDocument.FormatType.PDF)
        {
            document = new PDFDocument("aaa");

            if (this.state == 0)
            {
                scanner.Scan(out document, formatType);
            }
        }

        public void ScanAndPrint()
        {
            if (this.state == 0)
            {
                IDocument document;
                scanner.Scan(out document, IDocument.FormatType.PDF);
                printer.Print(document);
            }

        }

        public void Fax(in IDocument document)
        {
            if (this.state == 0)
            {
                fax.Fax(document);
            }
        }

    }
}
