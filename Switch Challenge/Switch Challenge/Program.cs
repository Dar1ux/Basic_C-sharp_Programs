using System;


namespace Switch_Challenge
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Pick a number from 1 to 7.");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("The day is Monday");
                    break;
                case 2:
                    Console.WriteLine("The day is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("The day is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("The day is Thursday");
                    break;
                case 5:
                    Console.WriteLine("The day is Friday");
                    break;
                case 6:
                    Console.WriteLine("The day is Saturday");
                    break;
                case 7:
                    Console.WriteLine("The day is Sunday");
                    break;
                default:
                    Console.WriteLine("You chose the number that is out of requested scope.");
                    //Main();
                    break;
            }
            Console.ReadLine();
        }
    }
}
