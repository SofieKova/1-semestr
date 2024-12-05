using System;

class AverageMethods
{
    public static double Average(int[] numbers)
    {
        ValidateArray(numbers);

        double sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        return sum / numbers.Length;
    }

    public static double Average(float[] numbers)
    {
        ValidateArray(numbers);

        double sum = 0;
        foreach (float number in numbers)
        {
            sum += number;
        }

        return sum / numbers.Length;
    }

    private static void ValidateArray<T>(T[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty.");
        }
    }
}

class Program
{
    static void Main()
    {
        int[] intNumbers = { 1, 2, 3, 4, 5 };
        float[] floatNumbers = { 1.5f, 2.5f, 3.5f };

        try
        {
            double averageInt = AverageMethods.Average(intNumbers);
            Console.WriteLine($"Среднее арифметическое целых чисел: {averageInt}");

            double averageFloat = AverageMethods.Average(floatNumbers);
            Console.WriteLine($"Среднее арифметическое чисел с плавающей запятой: {averageFloat}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
