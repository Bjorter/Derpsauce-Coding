using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Tyre
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string TyreSize { get; set; }



        public override string ToString()
        {
            return "Name: " + Name + "\nModel: " + Model + "\nSize: " + TyreSize;
        }
    }
}
