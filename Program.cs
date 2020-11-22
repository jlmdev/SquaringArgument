using System;

namespace SquaringArgument
{
    public class Kata
    {
        // Write a static function "Square" here which takes a double
        // and returns the square of that double
        public double Square(double number)
        {
            double result = Math.Pow(number, 2);
            return result;
        }
    }
    class Program
    {
        // Write a static function "Square" here which takes a double
        // and returns the square of that double
        public double Square(double number)
        {
            double result = (double)Math.Pow(number, 2);
            return result;
        }

        static void Main(string[] args)
        {


            Console.WriteLine(Square(4));
        }
    }
}
