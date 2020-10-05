using System;

namespace TeachMeSkills_DotNet.Task_9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("imput salary ");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the length of service ");
            double lengthOfServiceary = double.Parse(Console.ReadLine());

            if (lengthOfServiceary <= 5)

                Console.WriteLine($"Reward = {salary * 0.10}");

            else if (lengthOfServiceary > 5 && lengthOfServiceary <= 10)

                Console.WriteLine($"Reward = {salary * 0.15}");

            else if (lengthOfServiceary > 10 && lengthOfServiceary <= 15)

                Console.WriteLine($"Reward = {salary * 0.25}");

            else if (lengthOfServiceary > 15 && lengthOfServiceary <= 20)

                Console.WriteLine($"Reward = {salary * 0.35}");

            else if (lengthOfServiceary > 20 && lengthOfServiceary <= 25)
                Console.WriteLine($"Reward = {salary * 0.45}");

            else if (lengthOfServiceary > 25)

                Console.WriteLine($"Reward = {salary * 0.50}");
        }

    }
}
