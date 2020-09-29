using System;

namespace TeachMeSkills_DotNet.Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите одно слово из предложенных: погода; дождь; снег; солнце; слякоть; лёд; облачно; осадки; градус; гроза.");
            string word = Console.ReadLine();
            switch (word)
            {
                case "погода":
                    Console.WriteLine("weather");
                    break;
                case "дождь":
                    Console.WriteLine("rain");
                    break;
                case "снег":
                    Console.WriteLine("snow");
                    break;
                case "солнце":
                    Console.WriteLine("the sun");
                    break;
                case "слякоть":
                    Console.WriteLine("slush");
                    break;
                case "лёд":
                    Console.WriteLine("ice");
                    break;
                case "облачно":
                    Console.WriteLine("cloudy");
                    break;
                case "осадки":
                    Console.WriteLine("precipitation");
                    break;
                case "градус":
                    Console.WriteLine("degrees");
                    break;
                case "гроза":
                    Console.WriteLine("storm");
                    break;
                default:
                    Console.WriteLine("такого слова в переводчике нет.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
