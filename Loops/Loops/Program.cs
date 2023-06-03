using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number.");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 17;

            do
            {
                switch (number)
                {
                    case 69:
                        Console.WriteLine("You guessed 69. Try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 21:
                        Console.WriteLine("You guessed 21. Try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 17:
                        Console.WriteLine("You guessed 17. That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong. Try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);
 
            Console.ReadLine();
        }
    }
}
