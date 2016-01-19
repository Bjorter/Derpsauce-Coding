using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viikko2_harj5
{
    class Students
    {
        public string Name;
        public int Age;
        public string School;

        public void PrintData()
        {
            Console.WriteLine("Name: {0}\nAge {1}\nSchool: {2}", Name, Age, School);
        }
    }
}
