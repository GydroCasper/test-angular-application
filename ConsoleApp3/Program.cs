using System;
using System.Collections.Generic;
using System.Linq;

namespace IG.FirstExercise
{
    class Program
    {
        private const int MAX_NUMBER = 1000;

        private static void Main(string[] args)
        {
            Go(args);

            Console.ReadKey();
        }

        private static void Go(IReadOnlyCollection<string> args)
        {
            if (args == null || args.Count != 2)
            {
                Console.WriteLine("You should pass two numbers as arguments");
                return;
            }

            if (!int.TryParse(args.First(), out var startNumber) || !int.TryParse(args.Last(), out var divider))
            {
                Console.WriteLine("Arguments should be numbers");
                return;
            }

            if (startNumber < 2)
            {
                Console.WriteLine("The first argument should be greater than 1");
                return;
            }

            if (divider == 0)
            {
                Console.WriteLine("The second argument shouldn't be zero");
                return;
            }

            if (startNumber < divider)
            {
                Console.WriteLine("The first argument should be greater than the second one");
                return;
            }

            if (startNumber % divider != 0)
            {
                Console.WriteLine("The first number should be evenly divisible by second number");
                return;
            }

            if (startNumber < 0 || divider < 0)
            {
                Console.WriteLine("Both numbers should be positive");
                return;
            }

            if (startNumber > MAX_NUMBER)
            {
                Console.WriteLine($"The first number should be less than {MAX_NUMBER}");
                return;
            }

            for (var i = startNumber; i > 0; i -= divider)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
