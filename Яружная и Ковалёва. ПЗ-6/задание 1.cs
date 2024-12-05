using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Test
{
    class BasicIO
    {
        static void Main()
        {
            string name = "John Doe";
            int age = 30;
            double salary = 5000.50;

            // Composite Formatting
            string formattedString1 = string.Format("Name: {0}, Age: {1}, Salary: {2:C}", name, age, salary);
            Console.WriteLine(formattedString1);

            // String Interpolation
            string formattedString2 = $"Name: {name}, Age: {age}, Salary: {salary:C}";
            Console.WriteLine(formattedString2);

            // String Concatenation
            string formattedString3 = "Name: " + name + ", Age: " + age + ", Salary: " + salary.ToString("C");
            Console.WriteLine(formattedString3);

            Console.ReadKey();
        }
    }
}














