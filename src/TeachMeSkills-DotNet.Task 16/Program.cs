using System;

namespace TeachMeSkills_DotNet.Task_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter height rectangle");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter width rectangle");
            int width = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int a = 0; a < width; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
        }
    }
}
