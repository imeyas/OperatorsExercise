using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The code below is for exercise 1
            int a = 4;
            int b = 17;
            int quotient = b / a;
            int remainder = b % a;

            Console.WriteLine($"{b} / {a} is {quotient} and the remainder is {remainder}", a, b, quotient, remainder); //Division and Nodulus

            Console.WriteLine(9 * 5); // Multiplication

            Console.WriteLine(11 + 6); // Addition

            Console.WriteLine(11 - 4); // Subtraction

            // The code below is for exercise 2

            double radius;
            Console.WriteLine("What is the radius of your circle?");
            radius = double.Parse(Console.ReadLine());
            //double area = Math.PI * (Math.Pow(radius, 2));
            double area = AreaOfCircle(radius);
            Console.WriteLine($"The area of your circle with {radius} as radius is {area}");

            Console.WriteLine($"The answer to K from bonus is 16"); // Answer to the bonus exercise
        }

        public static double AreaOfCircle(double radius)
        {
            double area = Math.PI * (Math.Pow(radius, 2));
            return area;
           
        }
    }
}