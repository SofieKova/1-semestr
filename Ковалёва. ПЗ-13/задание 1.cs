using System;
namespace Loop
{
    class ForLoop
    {
        public static void Main(string[] args)
        {
            int[] myArray = { 15, 23, 4, 36, 40, 19, 45 };
            foreach (int number in myArray)
            if (number > 20 && number < 50)
            Console.WriteLine(number);
        }
    }
}
