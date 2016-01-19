using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viikko2_harj5
{
    class Program
    {
        static void Main(string[] args)
        {
            Students[] students = new Students[5];

            students[0] = new Students();

            students[0].Name = "Tero";
            students[0].Age = 24;
            students[0].School = "JAMK";

            students[1] = new Students();

            students[1].Name = "Antti";
            students[1].Age = 19;
            students[1].School = "JAMK";

            students[2] = new Students();

            students[2].Name = "Balthazar";
            students[2].Age = 230;
            students[2].School = "JAMK";

            students[3] = new Students();

            students[3].Name = "Ragnarok";
            students[3].Age = 5000;
            students[3].School = "JAMK";

            students[4] = new Students();

            students[4].Name = "Kalja";
            students[4].Age = 12390;
            students[4].School = "JAMK";

            for (int i = 0; i < 5; i++)
            {
                students[i].PrintData();
            }
        }
    }
}
