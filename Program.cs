using System;

class Program
{
    static void Main(string[] args)
    {
        // Введите строки в массив
        Console.WriteLine("Введите элементы массива строк, разделяя их пробелом:");
        string[] inputArray = Console.ReadLine().Split();

        // Создаем новый массив для хранения строк, длина которых меньше или равна 3
        string[] resultArray = FilterArray(inputArray);

        // Выводим результат
        Console.WriteLine("Результат:");
        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }
    }

    static string[] FilterArray(string[] inputArray)
    {
        // Определяем длину нового массива
        int count = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив
        string[] resultArray = new string[count];
        int index = 0;

        // Заполняем новый массив
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                resultArray[index++] = str;
            }
        }

        return resultArray;
    }
}
