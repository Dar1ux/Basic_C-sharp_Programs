using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input Assignment
            // Perform these actions and create a console app that includes the following:
            // 1. Asks the user for a number.
            Console.WriteLine("Please neter a number:");

            // 2. Logs that number to a text file.
            using (StreamWriter file = new StreamWriter("user_number.txt", false)) // false indicates not to append to file, so it re-writes it
            {
                file.WriteLine(Console.ReadLine());
            }

            // 3. Prints the text file back to the user.
            using (StreamReader file = new StreamReader("user_number.txt"))
            {
                Console.WriteLine(file.ReadLine());
            }

            Console.ReadLine();
        }
    }
}
