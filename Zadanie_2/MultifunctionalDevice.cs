[assembly: System.Runtime.CompilerServices.InternalsVisibleToAttribute("TestProject2")]

namespace Zadanie_2
{
    class MultifunctionalDevice : Copier, IFax
    {

        public int FaxCounter { get; private set; } = 0;


        public void Fax(in IDocument document)
        {
            if (this.state == 0)
            {
                DateTime date = DateTime.Now;
                string scanName = $"ImageScan{ScanCounter}.jpg";
                Console.WriteLine($"{date} Sent Fax: {scanName}");


                FaxCounter++;
            }
        }
    }

}