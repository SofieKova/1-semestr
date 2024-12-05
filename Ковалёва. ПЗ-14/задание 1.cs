using System;

namespace Циклы
{
    class Program
    {
        static double[] a = new double[1000];

        static void Main(string[] args)
        {
            int n = InputA();  
            Console.WriteLine("Сумма_F: {0}", sumF(n));
            Console.WriteLine("Сумма_W: {0}", sumW(n));
            Console.WriteLine("Сумма_D: {0}", sumD(n));
            Console.WriteLine("Произведение_F: {0}", multyF(n));
            Console.WriteLine("Произведение_W: {0}", multyW(n));
            Console.WriteLine("Произведение_D: {0}", multyD(n));
            Console.ReadKey();
        }

        static int InputA()
        {
            int n;
            Console.Write("Введите количество элементов: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = Convert.ToDouble(Console.ReadLine());
            }
            return n;
        }

        static double sumF(int n)
        {
            double s = 0;
            for (int k = 0; k < n; k++)
                s += a[k]; 
            return s;
        }

        static double sumW(int n)
        {
            double s = 0;
            int k = 0;
            while (k < n)
            {
                s += a[k];  
                k++;
            }
            return s;
        }

        static double sumD(int n)
        {
            double s = 0;
            int k = 0;
            do
            {
                s += a[k];  
                k++;
            } while (k < n); 
            return s;
        }

        static double multyF(int n)
        {
            double p = 1;
            for (int k = 0; k < n; k++)
                p *= a[k];  
            return p;
        }

        static double multyW(int n)
        {
            double p = 1;
            int k = 0;
            while (k < n)
            {
                p *= a[k];  
                k++;
            }
            return p;
        }

        static double multyD(int n)
        {
            double p = 1;
            int k = 0;
            do
            {
                p *= a[k];  
                k++;
            } while (k < n);  
            return p;
        }
    }
}

