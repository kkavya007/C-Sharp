using System;

class SimpleInterest
{
    public static void Run()
    {
        Console.Write("Enter Principal: ");
        double p = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate (%): ");
        double r = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time (years): ");
        double t = Convert.ToDouble(Console.ReadLine());

        double si = (p * r * t) / 100;

        Console.WriteLine("Simple Interest = " + si);
    }
}
