using System;

namespace Program
{
    class Calculator
    {
        public static void Run()
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            double result = 0;

            switch (op)
            {
                case '+': result = num1 + num2; break;
                case '-': result = num1 - num2; break;
                case '*': result = num1 * num2; break;
                case '/': result = num2 != 0 ? num1 / num2 : 0; break;
                default: Console.WriteLine("Invalid operator"); return;
            }

            Console.WriteLine("Result: " + result);
        }
    }
}