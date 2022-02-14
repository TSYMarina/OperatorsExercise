using System;

namespace OperatorsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! We are working with two chosen numhbers today: 17 and 4.");

            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a}/{b} is {quotient}, remainder {remainder}");
            }
        }

    }
}
