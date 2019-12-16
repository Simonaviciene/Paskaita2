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
            int A;
            int B;

            Console.WriteLine("Ivesti pirma skaiciu: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ivesti antra skaiciu: ");
            B = Convert.ToInt32(Console.ReadLine());

            if (A == B)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
             
            Console.WriteLine("(a=b)");
            Console.ReadLine();
        }
    }
}
