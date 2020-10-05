using System;

namespace TeachMeSkills_DotNet.Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("imput value");
            int value = int.Parse(Console.ReadLine());
            if ((value &(value - 1)) ==0)
                Console.WriteLine("The number is a power of two");
            else
                Console.WriteLine("Number is not a power of two ");
        }
    }
}
