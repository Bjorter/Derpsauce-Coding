using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viikko2_harj4
{
    class Vehicle
    {
        public string Name;
        public int Speed;
        public int Tyres;

        public void PrintData()
        {
            Console.WriteLine("Name: {0}\nSpeed: {1}\nTyres: {2}", Name, Speed, Tyres);
        }

        public override string ToString()
        {
            return "Name: " + Name + "\nSpeed: " + Speed + " km/h\nTyres: " + Tyres;
        }
    }


}
