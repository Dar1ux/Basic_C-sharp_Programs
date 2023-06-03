using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            if (name == "Jesse")
            {
                Console.WriteLine("Your name is Jesse.");
            }
            else if (name == "Darius")
            {
                Console.WriteLine("Your name is Darius.");
            }
            else
            {
                Console.WriteLine("Your name is not Darius or Jesse.");
            }

            if (name != "Robert")
            {
                Console.WriteLine("Your name is not Robert.");
            }

            Console.WriteLine("What is your age?");
            string temp = Console.ReadLine();
            int age = Convert.ToInt16(temp);

            if (age <= 12)
            {
                Console.WriteLine("You are a child.");
            }
            else if (age > 19)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a teenager.");
            }

            string canVote = age >= 18 ? "You can vote." : "You cannot vote yet.";
            Console.WriteLine(canVote);

            Console.ReadLine();
        }
    }
}
