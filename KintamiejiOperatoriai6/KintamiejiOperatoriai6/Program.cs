using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KintamiejiOperatoriai6
{
    class Program
    {
        static void Main(string[] args)
        {
            string TextBox;

            Console.WriteLine("Ivesti teksto eilute: {0}", TextBox);
            {

                if (!string.IsNullOrWhiteSpace(TextBox.Text))
                {
                    Console.WriteLine("Eilute tuscia -> True");
                }  
                else
                {                    {
                    Console.WriteLine("Eilute tuscia -> False");
                }
                
                    Console.ReadLine();
                }
            }   
        }
    }      
}
