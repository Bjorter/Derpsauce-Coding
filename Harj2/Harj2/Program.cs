using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj2
{
    class Program
    {
        static void Main(string[] args)
        {
            int pisteet;

            Console.WriteLine("Mikä on pistemääräsi? (0-12)");

            pisteet = int.Parse(Console.ReadLine());

            if (pisteet >= 0 && pisteet <= 1) {

                Console.WriteLine("Arvosanasi on 0! Skarppaahan vähän.");
            }
                

            else if (pisteet >= 2 && pisteet <= 3)
            {
                Console.WriteLine("Arvosanasi on 1!");
            }

            else if (pisteet >= 4 && pisteet <= 5)
            {
                Console.WriteLine("Arvosanasi on 2!");
            }

            else if (pisteet >= 6 && pisteet <= 7)
            {
                Console.WriteLine("Arvosanasi on 3!");
            }

            else if (pisteet >= 8 && pisteet <= 9)
            {
                Console.WriteLine("Arvosanasi on 4!");
            }

            else if (pisteet >= 10 && pisteet <= 12)
            {
                Console.WriteLine("Arvosanasi on 5! Onneksi olkoon!");
            }
        }
    }
}
