using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    public class FaxDevice : IFax
    {

        public int FaxCounter { get; private set; } = 0;

        public void Fax(in IDocument document)
        {
            DateTime date = DateTime.Now;
            string scanName = $"ImageScan{FaxCounter}.jpg";
            Console.WriteLine($"{date} Sent Fax: {scanName}");

            FaxCounter++;
        }
    }
    

}
