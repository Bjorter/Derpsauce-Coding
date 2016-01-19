using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viikko2_harj6
{
    class Account
    {
        public double Funds;

        public int Games;

        public string Name;

        public void PrintData()
        {
            Console.WriteLine("Acccount name: {0}\nYour funds: {1}\nNumber of games owned: {2}", Name, Funds, Games);
        }

    }
}
