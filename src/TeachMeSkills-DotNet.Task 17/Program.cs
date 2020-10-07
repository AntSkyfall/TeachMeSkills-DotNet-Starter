using System;

namespace TeachMeSkills_DotNet.Task_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount in Russian rubles ");
            double rusRub = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the rate to convert");
            double rateConvert = double.Parse(Console.ReadLine());

            Console.WriteLine($"Conversion result: { rateConvert * 100/rusRub }" );
        }
    }
}
