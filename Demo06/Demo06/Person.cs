using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06
{
    /// <summary>
    /// Swaghetti Yolognaise. i.e. cnotains Person properties
    /// </summary>
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocialSecurityNumber { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + SocialSecurityNumber;
        }

    }
}
