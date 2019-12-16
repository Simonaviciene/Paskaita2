using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KintamiejiOperatoriai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 1;
            int B = 15;

            Console.WriteLine("Reiksmes pries keitima");
            Console.WriteLine();
            Console.WriteLine("A=" + " " + A);
            Console.WriteLine("B=" + " " + B);
            SwapNum(ref A, ref B);
            Console.WriteLine();
            Console.WriteLine("Reiksmes po pakeitimo");
            Console.WriteLine();
            Console.WriteLine("A=" + " " + A);
            Console.WriteLine("B=" + " " + B);
            Console.WriteLine();
            Console.ReadLine();


        }
    }
}
