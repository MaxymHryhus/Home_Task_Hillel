namespace Multiplication_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication Table:");

            // Виводимо 
            for (int i = 1; i <= 10; i++)

              {
                for (int j = 1; j <= 10; j++)
                {

                    Console.WriteLine($"{i} * {j} = {i * j}");

                }
                Console.ReadLine();
              }
        }
    }
}
