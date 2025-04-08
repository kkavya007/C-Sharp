using System;

namespace Program
{
    class PrimeCheck
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isPrime = number > 1;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine(isPrime ? "Prime" : "Not Prime");
        }
    }
}