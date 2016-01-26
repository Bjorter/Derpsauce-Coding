using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            // create tyre
            Tyre tyre = new Tyre { Name = "Nokia", Model = "Hakkapeliitta", TyreSize = "205R16"};

            // create a car

            Vehicle car = new Vehicle { Name = "Porsche", Model = "1991" };
            car.AddTyre(tyre); // car contains tyres...
            car.AddTyre(tyre); // car contains tyres...
            car.AddTyre(tyre); // car contains tyres...
            car.AddTyre(tyre); // car contains tyres...

            Console.WriteLine(car.ToString());

            /*Vehicle mitsu = new Vehicle();

            Vehicle toyota = new Vehicle();

            Vehicle mersu = new Vehicle();*/
        }
    }
}
