using System;

public static class LeapYearCheck
{
    public static void Run()
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            Console.WriteLine("Leap year");
        else
            Console.WriteLine("Not a leap year");
    }
}
