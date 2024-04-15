namespace Comparison_of_numbers
{
    internal class Program
    {

        /*1) Необхідно написати консольну програму, де користувач вводитиме з клавіатури 
             2 числа. Числа будуть порівнюватися з наступним виведенням в консоль 
             результату цього порівняння (чи рівні значення, а якщо ні, яке число 
             більше/менше).*/

        static void Main(string[] args)
        {
            // Оголошуємо змінні під два числа
            double firstNumber, secondNumber;

            // Задаємо значення змінних через консоль
            Console.WriteLine("Enter first number: ");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            secondNumber = Convert.ToDouble(Console.ReadLine());

            // Порівнюємо два значення і виводимо результат одразу у консоль
            
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("Number {0} greater number {1}", firstNumber, secondNumber);
            }
            else if (secondNumber > firstNumber)
            {
                Console.WriteLine("Number {0} greater number {1}", secondNumber, firstNumber);
            } else 
            {
                Console.WriteLine("Two numbers are equal");
            }

            Console.ReadLine();
        }
    }
}
