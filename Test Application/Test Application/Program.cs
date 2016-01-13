using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna joku numero: "); //Sama kuin "cout << "

            int luku;

            luku = int.Parse(Console.ReadLine()); //Sama kuin "cin >> "

            Console.WriteLine("Annoit luvun: " + luku); //Sama kuin "cout << ", ja + on <<
        }
    }
}
