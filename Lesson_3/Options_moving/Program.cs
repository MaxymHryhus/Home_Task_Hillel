namespace Options_moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*6 *) Дослідити інші способи поміняти місцями значення двох змінних без 
             використання тимчасової змінної та використання суми / множення.*/

            int a, b;

            Console.WriteLine("Enter number a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number b:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("a = {0}, b = {1} ", a, b);
            Console.ReadLine(); 

            // Варіант 1: оператор XOR

           /* a = a ^ b;
            b = a ^ b;
            a = a ^ b;

            Console.WriteLine("a = {0}, b = {1} ", a, b);
            Console.ReadLine();*/

            // Варіант 2: присвоєння значень

            /*(a, b) = (b , a);

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.ReadLine();*/

           
        }
    }
}
