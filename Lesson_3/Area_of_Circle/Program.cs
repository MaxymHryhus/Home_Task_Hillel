namespace Area_of_Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Користувач вводить радіус круга. Напишіть програму, яка обчислює площу 
        }              цього круга і виводить в консоль результат*/

            // Оголошуємо змінні під введений користувачем радіус і під результат площі

            double r, s; // r - радіус, s - площа


            // Задаємо радіус через консоль

            Console.WriteLine("Enter your radius of the circle: ");
            r = Convert.ToDouble(Console.ReadLine());

            // Обчислюємо площу круга за формулою

            s = (Math.PI * r) * 2;

            // Виводимо результат в консоль

            Console.WriteLine("Area of a circle: " + s);
            Console.ReadLine();
        }
    }
}
