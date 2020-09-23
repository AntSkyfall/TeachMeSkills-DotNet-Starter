using System;

namespace TeachMeSkills_DotNet_Starter.Task_6
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                double operand1, operand2;
                string sign;

                try
                {
                    Console.WriteLine("imput first value ");
                    operand1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("imput second value ");
                    operand2 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("incorrect input");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("select operation '+' '-' '/' '*' ");
                sign = Console.ReadLine();

                switch (sign)
                {
                    case "+":
                        Console.WriteLine(operand1 + operand2);
                        break;

                    case "-":
                        Console.WriteLine(operand1 - operand2);
                        break;

                    case "*":
                        Console.WriteLine(operand1 * operand2);
                        break;

                    case "/":

                        if (operand1 == 0)
                            Console.WriteLine("Cannot be divided by zero");
                        else
                            Console.WriteLine(operand1 / operand2);

                        Console.WriteLine(operand1 / operand2);
                        break;

                    default:
                        Console.WriteLine("incorrect input");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
