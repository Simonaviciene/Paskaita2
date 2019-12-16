using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KintamiejiOperatoriai5
{
    class Program
    {
        static void Main(string[] args)
        {
            double ilgis;
            double plotis;
                
            Console.WriteLine("Ivesti staciakampio ilgi: ");
            ilgis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ivesti staciakampio ploti: ");
            plotis = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Staciakampio plotas:");
            Console.WriteLine(ilgis * plotis);
           

            Console.ReadLine();
        }
    }
}
