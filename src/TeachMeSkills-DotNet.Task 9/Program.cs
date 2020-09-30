using System;

namespace TeachMeSkills_DotNet.Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("imput value ");
            int value = int.Parse(Console.ReadLine());
            if (value % 2 == 0)
            Console.WriteLine("even");
            else
                Console.WriteLine("odd");
        }
    }
}
