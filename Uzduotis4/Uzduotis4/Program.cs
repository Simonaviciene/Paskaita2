using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis4
{
    class Program
    {
        static void Main(string[] args)
        {
            string mokykloPavadinimas = "CodingAcademy";
            var kursoPavadinimas = "IT08";
            int studentuSkaicius = 12;

            DateTime kursoPradziosData = new DateTime(2019, 12, 11);
            DateTime KursoPabaigosData = new DateTime(2020, 02, 29);
            
            double skirtumasTarpPradziosIrPabaigos = (KursoPabaigosData - kursoPradziosData).TotalDays;


            DateTime siandienosData = DateTime.Today;

            Console.WriteLine("Mokyklos pavadinimas: {0}", mokykloPavadinimas);
            Console.WriteLine("Kurso pavadinimas: {0}", kursoPavadinimas);
            Console.WriteLine("Studentu Skaicius: {0}", studentuSkaicius);
            Console.WriteLine("Siandienos data: {0}", siandienosData.ToLongDateString());
            Console.WriteLine("Kurso trukme {0}", skirtumasTarpPradziosIrPabaigos);

            Console.ReadLine(); 
        }
    }
}
