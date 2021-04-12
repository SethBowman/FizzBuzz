using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number.");
            FizzBuzz();

        
           
        }


        public static void FizzBuzz()

        {
            int number = int.Parse(Console.ReadLine());
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }


            if (number % 3 == 0)
            {
                Console.Write("Buzz");
            }
            else if (number % 5 == 0)
            {
                Console.Write("Fizz");
            }

            else
            {
                Console.WriteLine("Not divisible by 3 or 5.");
            }

        }


    }
}
