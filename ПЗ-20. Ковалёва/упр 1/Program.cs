using System;

class Program
{
    static void Main()
    {
        Console.WriteLine($"Сумма введенных чисел: {sum()}");
    }

    static int sum()
    {
        Console.Write("Введите число (или 0 для завершения ввода): ");
        string input = Console.ReadLine(); 

        if (input == "0")
        {
            return 0; 
        }

        int number;

        if (int.TryParse(input, out number)) 
        {
            return number + sum(); 
        }
        else
        {
            Console.WriteLine("Пожалуйста, введите корректное целое число.");
            return sum(); 
        }
    }
}
