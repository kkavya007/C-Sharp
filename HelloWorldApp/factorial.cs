using System;

namespace Program
{
    class Factorial
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Factorial of {num} is {ComputeFactorial(num)}");
        }

        private static long ComputeFactorial(int n)
        {
            if (n == 0) return 1;
            return n * ComputeFactorial(n - 1);
        }
    }
}