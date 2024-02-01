using System;

class Program
{
    static void Main(string[] args)
    {
        char[,] charArray = {
            {'a', 'b', 'c'},
            {'d', 'e', 'f'},
            {'g', 'h', 'i'}
        };

        string str = GetStringFromCharArray(charArray);

        Console.WriteLine("Строка из символов массива: " + str);
    }
    static string GetStringFromCharArray(char[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        string result = "";

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result += array[i, j];
            }
        }

        return result;
    }
}
