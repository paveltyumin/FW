using System;

class Program
{
    static void Main()
    {
        string input = Prompt("Введите элементы массива строк через точку с запятой и пробел (; ): ");
        string[] initialArray = input.Split(new string[] { "; " }, StringSplitOptions.RemoveEmptyEntries);

        string[] resultArray = GetArrayOfThreeSymbols(initialArray);

        Console.WriteLine("Результирующий массив строк:");
        PrintArray(resultArray);

        Console.ReadLine();
    }

    static string Prompt(string message)
    {
        Console.Write(message);
        return Console.ReadLine();
    }

    static string[] GetArrayOfThreeSymbols(string[] array)
    {
        int count = 0;
        string[] result = new string[0];

        foreach (string item in array)
        {
            if (item.Length <= 3)
            {
                count++;
                string[] preresult = new string[count];
                for (int i = 0; i < count - 1; i++)
                {
                    preresult[i] = result[i];
                }
                preresult[count - 1] = item;
                result = preresult;
            }
        }

        return result;
    }

    static void PrintArray(string[] array)
    {
        string mass = "[";
        if (array.Length > 0)
        {
            mass += array[0];
            for (int i = 1; i < array.Length; i++)
            {
                mass += ", " + array[i];
            }
        }
        mass += "]";
        Console.WriteLine(mass);
    }
}
