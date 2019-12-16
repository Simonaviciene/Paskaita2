using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KintamiejiOperatoriai10
{
    class Program
    {
        static void Main(string[] args)
        {
            string miestoPavadinimas = "Vilnius";
            string gatvesPavadinimas = "S. Zukausko g.";
            int namoNumeris = 21;
            double namoPastatymoMetai1 = 2004;
            Double namoStatymoPradziosData1 = 2000;
            DateTime namoPastatymoMetai = new DateTime(2004);
            DateTime namoStatymoPradziosData = new DateTime(2000);

            double statybuTrukme = (namoPastatymoMetai - namoStatymoPradziosData).TotalDays;
            

            Console.WriteLine("{0} {1} {2} {3}", miestoPavadinimas, gatvesPavadinimas, namoNumeris, namoPastatymoMetai1);
            Console.WriteLine("Statybu pradzia: {0}", namoStatymoPradziosData1);
            Console.WriteLine("Statybu trukme: {0}", statybuTrukme);
            Console.ReadLine();
        }
    }
}
