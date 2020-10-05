using System;

namespace TeachMeSkills_DotNet.Task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumEvenNumber = 0;
            int sumOddNumber = 0;
            int evenNumberCount = 0;
            int oddNumberCount = 0;

            Console.WriteLine("imput the lower range");
            int firstValue = int.Parse(Console.ReadLine());

            Console.WriteLine("imput the limit range");
            int secondValue = int.Parse(Console.ReadLine());

            while (firstValue <= secondValue)
            {
                if (firstValue % 2 == 0)
                {
                    sumEvenNumber += firstValue;
                    evenNumberCount++;
                }

                else
                {
                    sumOddNumber += firstValue;
                    oddNumberCount++;
                }

                firstValue++;
            }
            Console.WriteLine(evenNumberCount + " Even");
            Console.WriteLine(oddNumberCount + " Odd");
            Console.WriteLine(sumOddNumber + " Odd sum");
            Console.WriteLine(sumEvenNumber + " Even sum");
        }
    }
}
