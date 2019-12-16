using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KintamiejiOperatoriai3
{
    class Program
    {
        static void Main(string[] args)
        {
            int skaicius;
            int skaicius1;

            if (skaicius == skaicius1)
            {
                Console.WriteLine("true");
            }
            else 
                {
                    Console.WriteLine("false");
                }
               
            


            Console.WriteLine("Ivesti du skaicius: ");
            skaicius = Convert.ToInt32(Console.ReadLine());
            skaicius1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("skaicius {0}", skaicius);
            Console.WriteLine("skaicius {0}", skaicius1);
            Console.ReadLine();
        }
    }
}
