using System;
class Palindrome
{
    public static void Run()
    {
        Console.Write("Enter a word: ");
        string input = Console.ReadLine();
        string reversed = new string(input.Reverse().ToArray());

        if (input.Equals(reversed, StringComparison.OrdinalIgnoreCase))
            Console.WriteLine("It's a palindrome!");
        else
            Console.WriteLine("Not a palindrome.");
    }
}
