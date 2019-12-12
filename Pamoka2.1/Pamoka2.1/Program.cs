using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamoka2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearOfBirth;
            string firstName;

            var lastName = "Pavardenis"; //var-nesvarbu kokio tipo duomenis ivesime, nuskaitys pati programa
            decimal salary = 1999.9m;
            DateTime lastPayDay = DateTime.Today.AddMonths(-1);

            yearOfBirth = 1990;
            firstName = "Vardenis";

            Console.WriteLine("Vardas, Pavarde: {0}, {1}", firstName, lastName);
            Console.WriteLine("Gimimo metai: {0}", yearOfBirth);
            Console.WriteLine("Pajamos: {0}", salary);
            Console.WriteLine("Paskutini karta ismoketa alga: {0}", lastPayDay.ToLongDateString());

            Console.ReadLine();

        }
    }
}
