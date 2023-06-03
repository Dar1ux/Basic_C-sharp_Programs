using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Challenge
{
    class Program
    {
        static void Main()
        {
            int num1 = 20;
            int num2 = 5;
            int result;
            result = num1 + num2;
            Console.WriteLine(num1.ToString() + " + " + num2.ToString() + " = " + result.ToString()); 
            result = num1 - num2;
            Console.WriteLine(num1 + " - " + num2 + " = " + result); // Implicit conversion to String is performed on integer variables.
            result = num1 * num2;
            Console.WriteLine(num1 + " * " + num2 + " = " + result);
            result = num1 / num2;
            Console.WriteLine(num1 + " / " + num2 + " = " + result);
            Console.ReadLine();
        }
    }
}
