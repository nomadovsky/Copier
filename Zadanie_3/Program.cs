

using Zadanie_3;

var xerox = new Copier();
xerox.PowerOn();
IDocument doc1 = new PDFDocument("aaa.pdf");
xerox.Print(in doc1);
xerox.Print(in doc1);

IDocument doc2;
xerox.Scan(out doc2);

//xerox.ScanAndPrint();

var fax = new MultifunctionalDevice();
fax.PowerOn();
fax.Print(in doc1);
fax.Scan(out doc2);
fax.ScanAndPrint();
fax.Fax(in doc1);
fax.Fax(in doc1);
fax.Fax(in doc1);

System.Console.WriteLine(xerox.Counter);
System.Console.WriteLine(xerox.PrintCounter);
System.Console.WriteLine(xerox.ScanCounter);

Console.WriteLine("~~~~Fax: ");
System.Console.WriteLine(fax.Counter);
System.Console.WriteLine(fax.PrintCounter);
System.Console.WriteLine(fax.ScanCounter);
System.Console.WriteLine(fax.FaxCounter);