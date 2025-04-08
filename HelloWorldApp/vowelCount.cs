using System;
class VowelCount
{
    public static void Run()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine().ToLower();
        int count = 0;

        foreach (char c in input)
        {
            if ("aeiou".Contains(c)) count++;
        }

        Console.WriteLine("Vowel count: " + count);
    }
}
