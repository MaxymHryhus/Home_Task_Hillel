namespace Multiplication_table
{
    //3) Доробити таблицю множення - зробити гарний вивід в консоль. 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication Table:");

            // Cтворення таблички множеня з 1 до 5 множника
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write($"{j} x {i} = {i*j}\t");
                }
                Console.WriteLine("");
            }

            Console.WriteLine();

            // Створення таблички множення з 6 до 10 множника
            for (int i = 1;i <= 10; i++)
            {
                for (int j = 6;  j <= 10; j++)
                {
                    Console.Write($"{j} x {i} = {j*i}\t");
                }
                Console.WriteLine();
            }
           Console.ReadLine();
        }
    }
}