namespace Square_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Написати програму, яка обчислює квадрат будь - якого введеного числа
            (бажано використати Math). */

            // Задаємо число через консоль

            double number;

            Console.WriteLine("Enter your number: ");
            number = Convert.ToDouble(Console.ReadLine());

            // Очислємо квадрат введеного числа

            double squareNumber;
            squareNumber = Math.Pow(number, 2);

            // Виводимо результат в консоль

            Console.WriteLine("The square of your number: " + squareNumber);
            Console.ReadLine();
        }
    }
}
