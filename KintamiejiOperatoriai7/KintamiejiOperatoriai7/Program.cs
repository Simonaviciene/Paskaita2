using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KintamiejiOperatoriai7
{
    class Program
    {
        static void Main(string[] args)
        {
            int skaicius;
            
            Console.WriteLine("Ivesti pirma skaiciu: ");
            skaicius = Convert.ToInt32(Console.ReadLine());
        
            if (skaicius < 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
                 Console.ReadLine();
        }
    }
}
