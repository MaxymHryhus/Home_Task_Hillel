namespace Switching_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Дано тризначне число. Знайти число, отримане під час перестановки першої 
             та другої цифр заданого числа.*/

            int threeDigitNumber;
            int newThreeDigitNumber;

            //Задаємо тризначне число через консоль

            Console.WriteLine("Enter your three-digit numer: ");
            threeDigitNumber = Convert.ToInt32(Console.ReadLine());

            // Розбиваємо число на одиниці, десятки і сотні

             int ones = threeDigitNumber % 10;
             int tens = (threeDigitNumber / 10) % 10;
             int hundrets = threeDigitNumber / 100;

            // Переставляємо першу та другу цифру

            newThreeDigitNumber = (tens * 100) + (hundrets * 10) + ones;

            // Виводимо результат в консоль

            Console.WriteLine(" Your new number: " + newThreeDigitNumber);
            Console.ReadLine();
        }
    }
}
