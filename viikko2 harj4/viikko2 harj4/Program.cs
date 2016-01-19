using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viikko2_harj4
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();

            vehicle.Name = "Audi";
            vehicle.Speed = 120;
            vehicle.Tyres = 4;

            vehicle.PrintData();
            Console.WriteLine(vehicle.ToString());
        }
    }
}
