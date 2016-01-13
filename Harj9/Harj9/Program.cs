using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj9
{
    class Program
    {
        static void Main(string[] args)
        {
            int yhteen = 0;
            for (int luku = 1; luku != 0;)
            {
                Console.WriteLine("Anna luku: ");
                luku = int.Parse(Console.ReadLine());
                yhteen = yhteen + luku;
            }

            Console.WriteLine("Luvut yhteensä: " + yhteen);
        }
    }
}
