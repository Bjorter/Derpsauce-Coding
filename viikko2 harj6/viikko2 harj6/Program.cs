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

            int valinta;

            while (true)
            {
                Console.WriteLine("Haluatko ostaa pelin? (1,99€) \n1:Kyllä\n2.Ei");
                valinta = int.Parse(Console.ReadLine());

                if (valinta == 1)
                {
                    if (account.Funds >= 1.99F)
                    {
                        account.Funds -= 1.99F;
                    }

                    else Console.WriteLine("Rahat eivät riitä!");
                }
            }
        }
    }
}


