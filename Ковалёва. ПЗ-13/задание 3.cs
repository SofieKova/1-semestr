using System;

class ForEachLoop 
{
    static void Main()
    {
        // Внешний цикл для переменной x от 2 до 8
        for (int x = 2; x <= 8; x++)
        {
            // Внутренний цикл для переменной y от 2 до 5
            for (int y = 2; y <= 5; y++)
            {
                // Вычисляем значение функции z(x, y) = x^y
                double z = Math.Pow(x, y);

                // Выводим результат
                Console.WriteLine($"z({x}, {y}) = {z}");
            }
        }
    }
}


