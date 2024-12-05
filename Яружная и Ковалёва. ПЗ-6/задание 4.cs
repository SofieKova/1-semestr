using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Yaruzhnaya_and_Kovaleva
{
    class BasicIO
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер телефона (11 цифр):");
            string phoneNumber = Console.ReadLine();

            string formattedNumber = FormatPhoneNumber(phoneNumber);

            Console.WriteLine(formattedNumber);
        }

        static string FormatPhoneNumber(string phoneNumber)
        {
            // Проверяем, что номер состоит из 11 цифр
            if (phoneNumber.Length != 11 || !ulong.TryParse(phoneNumber, out _))
            {
                return "Неверный номер телефона. Введите 11 цифр.";
            }

            // Форматируем номер
            string formatted = $"+7 ({phoneNumber.Substring(1, 4)}) {phoneNumber.Substring(5, 2)}-{phoneNumber.Substring(7, 2)}-{phoneNumber.Substring(9, 2)}";
            return formatted;
        }
    }
}
















