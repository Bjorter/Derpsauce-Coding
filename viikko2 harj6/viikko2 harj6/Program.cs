using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viikko2_harj6
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();

            account.Name = "Terppa";
            account.Funds = 2.5;
            account.Games = 234;

            account.PrintData();
        }
    }
}


