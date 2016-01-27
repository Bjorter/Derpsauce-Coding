using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Läksy06
{
    class Song
    {
        public string Name;

        public string Duration;

        public override string ToString()
        {
            return Name + " " + Duration;
        }
    }
}
