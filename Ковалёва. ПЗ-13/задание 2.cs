using System;

class ForEachLoop
{
    static void Main()
    {
        int sum = 0; 
        int count = 10; 
        int currentOddNumber = 1; 

        for (int i = 0; i < count; i++)
        {
            sum += currentOddNumber; 
            currentOddNumber += 2; 
        }

        Console.WriteLine("Сумма 10 нечетных чисел: " + sum);
    }
}

