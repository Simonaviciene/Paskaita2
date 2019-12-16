using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KintamiejiOpetaroriai9
{
    class Program
    {
        static void Main(string[] args)
        {
            string miestoPavadinimas = "Vilnius";
            string gatvesPavadinimas = "S. Zukausko g.";
            int namoNumeris = 21;
            decimal namoPastatymoMetai = 2004m ;

            Console.WriteLine("{0} {1} {2} {3}", miestoPavadinimas, gatvesPavadinimas, namoNumeris);
            Console.ReadLine();
        }
    }
}
