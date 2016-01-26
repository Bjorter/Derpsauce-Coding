using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public List<Tyre> Tyres { get; }


        public Vehicle()
        {
            Tyres = new List<Tyre>();
        }


        public void AddTyre(Tyre tyres)
        {
            Tyres.Add(tyres);
        }

        public override string ToString()
        {
            string sVehicle = "Name: " + Name + "\nModel: " + Model + "\nTyres: ";
            foreach(Tyre tyre in Tyres)
            {
                sVehicle += "\n" + tyre.ToString();
            }
            return sVehicle;
        }
    }
}
