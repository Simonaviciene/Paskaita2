using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kintamieji1
{
    class Program
    {
        static void Main(string[] args)
        {
            string mokykloPavadinimas = "CodingAcademy";
            var kursoPavadinimas = "IT08";
            int studentuSkaicius = 12;

            DateTime siandienosData = DateTime.Today;

            Console.WriteLine("Mokyklos pavadinimas: {0}", mokykloPavadinimas);
            Console.WriteLine("Kurso pavadinimas: {0}", kursoPavadinimas);
            Console.WriteLine("Studentu Skaicius: {0}", studentuSkaicius);
            Console.WriteLine("Siandienos data: {0}", siandienosData.ToLongDateString());

            Console.ReadLine();









        }
    }
}
