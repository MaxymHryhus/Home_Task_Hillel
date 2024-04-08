namespace Discount;

class Program
{
    static void Main(string[] args)
    {
        // Задаємо вартість товару та відсоток знижки
        double costProduct = 499;
        double discountProduct = 15;
        
        // Обчислюємо величину знижки
        double discountAmount = (costProduct * discountProduct) / 100;

        // Виводимо результат в консоль
        System.Console.WriteLine("Величина знижки: " + discountAmount);
        System.Console.ReadLine();
    }
}
