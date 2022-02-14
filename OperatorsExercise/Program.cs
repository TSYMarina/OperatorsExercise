using System;

namespace OperatorsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Workingwith2Numbers();
            AreaOfCircle();
            Console.WriteLine("Press any key to continue... Or not :) That is all for one run.");
            Console.ReadLine();
            
        }
        public static void Workingwith2Numbers()
        {
            Console.WriteLine("Hello! We are working with two chosen numbers today: 17 and 4.");
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a}/{b} is {quotient}, remainder {remainder}");
                Console.WriteLine();
            }
        }



        public static void AreaOfCircle()
        {
            Console.WriteLine("What is the area of your circle?");
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.PI * Math.Pow(radius, 2));


        }
    }
   
}
