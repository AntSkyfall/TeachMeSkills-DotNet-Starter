using System;
using System.ComponentModel;

namespace TeachMeSkills_DotNet.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal pi = 3.141592653M;
            Console.WriteLine("Enter radius ");
            decimal r = decimal.Parse(Console.ReadLine());
            decimal result = pi * (r * r);
            Console.WriteLine(result);
        }
    }
}
