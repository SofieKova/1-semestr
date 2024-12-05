using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Yaruzhnaya_and_Kovaleva_IS23
{
    class BasicIO
    {
        static void Main(string[] args)
        {
            string collegeName = "Курский государственный политехнический колледж";
            string contactInfo = "Контактная информация";
            string phoneInfo = "Контактные телефоны: +7 (4712) 37-02-19";
            string faxInfo = "Контактный факс: +7 (4712) 37-02-19";

            Console.WriteLine(collegeName);
            Console.WriteLine();
            Console.WriteLine(contactInfo);
            Console.WriteLine();
            Console.WriteLine(phoneInfo);
            Console.WriteLine(faxInfo);

            Console.ReadKey();
        }
    }
}