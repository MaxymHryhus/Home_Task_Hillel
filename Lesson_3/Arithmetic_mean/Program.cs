namespace Arithmetic_mean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Написати програму, яка обчислює середнє арифметичне двох чисел.

            // Оголошуємо змінні під введені дані і їх результат

            double number1, number2;
            double arithmeticMean;

            // Задаємо два числа через консоль

            Console.WriteLine(" Enter your first number: ");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            number2 = Convert.ToDouble(Console.ReadLine());

            // Обчислюємо середнє арифметичне

            arithmeticMean = (number1 + number2) / 2;

            // Виводимо результат в консоль

            Console.WriteLine("Arithmetic mean your numbers: " + arithmeticMean);
            Console.ReadLine();
        }
    }
}
