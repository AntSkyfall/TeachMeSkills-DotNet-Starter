using System;

namespace TeachMeSkills_DotNet.Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 2;
            int value2 = 2;
            Console.WriteLine("addition " + value1 + value2);
            Console.WriteLine("subtraction " + (value1 - value2));
            Console.WriteLine("multiplication " + value1 * value2);
            Console.WriteLine("Division " + value1 / value2);
            Console.WriteLine("the remainder " + value1 % value2);
        }
    }
}
