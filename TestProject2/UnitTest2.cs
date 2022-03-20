using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zadanie_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2
{
    [TestClass]
    public class FaxTests
    {
        
        [TestMethod]
        public void Fax_FaxCounter()
        {
            var fax = new MultifunctionalDevice();
            fax.PowerOn();

            IDocument doc1 = new TextDocument("aaa.txt");
            fax.Fax(in doc1);
            IDocument doc2 = new TextDocument("bbb.txt") ;
            fax.Fax(in doc2);

            IDocument doc3 = new ImageDocument("aaa.jpg");
            fax.Print(in doc3);

            fax.PowerOff();
            fax.Print(in doc3);
            fax.Fax(in doc1);
            fax.PowerOn();

            fax.Fax(in doc1);
    
            fax.ScanAndPrint();

            // 4 skany, gdy urządzenie włączone
            Assert.AreEqual(3, fax.FaxCounter);
        }

        [TestMethod]
        public void MultifunctionalDevice_PowerOnCounter()
        {
            var fax = new MultifunctionalDevice();
            fax.PowerOn();
            fax.PowerOn();
            fax.PowerOn();

            IDocument doc1 = new ImageDocument("aaa.jpg"); ;
            fax.Fax(in doc1);
            IDocument doc2 = new TextDocument("aaa.txt");
            fax.Fax(in doc2);

            fax.PowerOff();
            fax.PowerOff();
            fax.PowerOff();
            fax.PowerOn();

            IDocument doc3 = new ImageDocument("aaa.jpg");
            fax.Fax(in doc3);

            fax.PowerOff();
            fax.Fax(in doc3);
            fax.Fax(in doc1);
            fax.PowerOn();

            fax.ScanAndPrint();
            fax.ScanAndPrint();

            // 3 włączenia
            Assert.AreEqual(3, fax.Counter);
        }
    }
}
