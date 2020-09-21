using System;

namespace TeachMeSkills_DotNet.Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double V, S, R, h;
            const double pi = 3.141592653;
            Console.WriteLine("imput radius");
            R = double.Parse(Console.ReadLine());

            Console.WriteLine("imput height");
            h = double.Parse(Console.ReadLine());

            V = pi * Math.Pow(R,2) * h;
            Console.WriteLine("volume = " + V);


            S = 2 * pi * R * (R + h);
            Console.WriteLine("surface area = " + S);




        }
    }
}
