using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Switching_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано тризначне число. Знайти число, отримане під час прочитання його цифр справа наліво.

            // Задаємо тризначне число через консоль

            int threeDigitNumber;
            int switchingNumber;

            Console.WriteLine("Enter three-digit number:");
            threeDigitNumber = Convert.ToInt32(Console.ReadLine());

            // Розбиваємо число на одиниці, десятки і сотні
            int ones = threeDigitNumber % 10; 
            int tens = (threeDigitNumber / 10) % 10;
            int hundreds = threeDigitNumber / 100;

            // Формуємо зворотній порядок числа
            switchingNumber = (ones * 100) + (tens * 10) + hundreds;

            // Виводимо результат в консоль

            Console.WriteLine("The reverse order of your number: " + switchingNumber);
            Console.ReadLine();

            

            
            

        }
    }
}
