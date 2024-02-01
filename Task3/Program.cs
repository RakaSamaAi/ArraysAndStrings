using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "level"; // Произвольная строка

        bool isPalindrome = IsPalindrome(input);

        if (isPalindrome)
        {
            Console.WriteLine($"Строка \"{input}\" является палиндромом.");
        }
        else
        {
            Console.WriteLine($"Строка \"{input}\" не является палиндромом.");
        }
    }

    static bool IsPalindrome(string str)
    {
        int length = str.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (str[i] != str[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}
