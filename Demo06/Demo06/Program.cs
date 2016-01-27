using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object from Persons

            Persons myFriends = new Persons();

            // Create a few friends

            Person person1 = new Person { FirstName = "Jussi", LastName = "Jurkka", SocialSecurityNumber = "451348-123F" };
            Person person2 = new Person { FirstName = "Jukka", LastName = "Jooseppi", SocialSecurityNumber = "452348-123A" };
            Person person3 = new Person { FirstName = "Linda", LastName = "Erkkila", SocialSecurityNumber = "851348-123B" };
            Person person4 = new Person { FirstName = "Paul", LastName = "Steiner", SocialSecurityNumber = "451348-123C" };
            Person person5 = new Person { FirstName = "Tero", LastName = "Olafson", SocialSecurityNumber = "987654-123D" };
            Person person6 = new Person { FirstName = "Antti", LastName = "Earthtribe", SocialSecurityNumber = "477778-123E" };
            Person person7 = new Person { FirstName = "Olle", LastName = "Borgson", SocialSecurityNumber = "123546-123G" };
            Person person8 = new Person { FirstName = "Aaaaa", LastName = "Aaaaa", SocialSecurityNumber = "451348-123H" };

            // Add persons to collection

            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);
            myFriends.AddPerson(person4);
            myFriends.AddPerson(person5);
            myFriends.AddPerson(person6);
            myFriends.AddPerson(person7);
            myFriends.AddPerson(person8);

            // Print collection

            myFriends.PrintCollection();

            // Get one person

            Console.WriteLine("Get one person from collection:");
            Person person9 = myFriends.GetPerson(5);
            if (person9 != null)
            {
                Console.WriteLine(person9.ToString());
            } else
            {
                Console.WriteLine("Cannot find person in that position...");
            }

            // Find person with sotu

            Console.WriteLine("Get one person with sotu: 987654-123D...");
            string socialSecurityNumber = "987654-123D";
            myFriends.FindPerson(socialSecurityNumber);
            Person person10 = myFriends.FindPerson(socialSecurityNumber);
            if (person10 != null)
            {
                Console.WriteLine(person10.ToString());
            }
            else
            {
                Console.WriteLine("Person with sotu not found...");
            }


        }
    }
}
