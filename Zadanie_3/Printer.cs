namespace Zadanie_3
{
    public  class Printer : IPrinter
    {

        public int PrintCounter { get; private set; } = 0;

        public void Print(in IDocument document)
        {
            DateTime date = DateTime.Now;

            Console.WriteLine($"{date} Print: {document.GetFileName()}");

            PrintCounter++;
        }
    }

}