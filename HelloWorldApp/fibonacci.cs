using System;

class Fibonacci
{
    public static void Run()
    {
        Console.Write("Enter number of terms: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int a = 0, b = 1, next;
        Console.Write("Fibonacci Series: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            next = a + b;
            a = b;
            b = next;
        }
    }
}
