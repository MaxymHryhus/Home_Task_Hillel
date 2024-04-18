namespace Multiplication_table
{
    //3) Доробити таблицю множення - зробити гарний вивід в консоль. 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication Table:");
            for (int i = 1; i <= 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[{i}]");
            for (int j = 0; j <= 10; j++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine("");
            }
           Console.ReadLine();
        }
    }
}