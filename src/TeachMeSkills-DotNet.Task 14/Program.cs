using System;

namespace TeachMeSkills_DotNet.Task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectangle");
            for (int i = 0; i < 5; i++)
            {

                for (int a = 0; a < 6; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Triangle");
            for (int i = 0; i < 7; i++)
            {

                for (int a = 0; a < i; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("triangle with spaces / romb ");
            for (int i = 0; i < 7; i++)
            {

                for (int a = 7; a > i; a--)
                {
                    Console.Write(" ");
                }
                for (int c = 0; c <= i; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 0; i <= 7; i++)
            {

                for (int a = 7; a > i; a--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
            Console.WriteLine("Equilateral triangle");
            for (int i = 0; i < 7; i++)
            {

                for (int a = 0; a < i; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 7; i > 0; i--)
            {

                for (int a = i; a > 0; a--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
