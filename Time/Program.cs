namespace Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задаємо час у годиннах, хвилинах і секундах
            byte hour = 19; 
            byte minute = 45;
            byte second = 22;

            // Обчислюємо загальний час в секундах
            int timeIinSeconds =(hour * 3600) + (minute * 60) + second;

            // Виводимо результат в консоль
            System.Console.WriteLine("Загальний час в секундах: " + timeIinSeconds);
            System.Console.ReadLine();



        }
    }
}
