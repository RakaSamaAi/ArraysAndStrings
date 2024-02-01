using System;

class Program
{
    static void Main(string[] args)
    {
        string originalString = "Hello World! This Is A Test String.";

        string resultString = ConvertToUpper(originalString);

        Console.WriteLine("Исходная строка: " + originalString);
        Console.WriteLine("Результат: " + resultString);
    }

    static string ConvertToUpper(string input)
    {
        char[] charArray = input.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            if (char.IsUpper(charArray[i]))
            {
                charArray[i] = char.ToLower(charArray[i]);
            }
        }

        return new string(charArray);
    }
}
