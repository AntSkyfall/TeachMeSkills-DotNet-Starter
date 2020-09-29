using System;

namespace TeachMeSkills_DotNet.Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 14;
            int b = 35;
            int c = 50;
            int d = 100;

            Console.WriteLine("imput value ");
            int imput = int.Parse(Console.ReadLine());
            if (imput <= a)
                Console.WriteLine("interval 0 - 14");
            else if (imput <= b)
                Console.WriteLine("interval 15 - 35");
            else if (imput <= c)
                Console.WriteLine("interval 36 - 50");
            else if (imput <= d)
                Console.WriteLine("interval 51 - 100");
            else
                Console.WriteLine("does not fall within the interval [0 - 100]");



        }
    }
}