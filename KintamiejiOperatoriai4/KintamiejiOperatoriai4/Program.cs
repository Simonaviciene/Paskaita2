using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KintamiejiOperatoriai4
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

           
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(++A);
            Console.WriteLine(--B);

            Console.ReadLine();
        }
    }
}
