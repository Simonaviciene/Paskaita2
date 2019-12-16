using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KintamiejiOperatoriai8
{
    class Program
    {
        static void Main(string[] args)
        {
            string vardas = " ";
            string pavarde = " ";

            Console.WriteLine("Ivesti Varda: ");
            vardas = Console.ReadLine();
            Console.WriteLine("Ivesti Pavarde: ");
            pavarde = Console.ReadLine();


            Console.WriteLine("{0} {1}", vardas, pavarde);

            Console.ReadLine();
         }
    }
}
