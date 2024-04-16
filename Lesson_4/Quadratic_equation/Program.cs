namespace Quadratic_equation
{
    /*4*) Квадратне рівняння.
Коефіцієнти a, b, c рівняння це рандомні числа.
a * x^2 + b* x + c = 0
D = b ^ 2 - 4 * a * c
В залежності від знаку дискримінанту рівняння може:
1) не мати коренів - D< 0 
2) один корінь - D = 0
3) два корені - D> 0
Виводимо рівняння в консоль, про кількість коренів інформуємо користувача.
Нагадую про написання власних методів, розділення обовязків між методами.
*** (плюсик в карму) якщо рівняння має корені, то вивести їх також в консоль.*/

    internal class Program
    {
        // метод генерації випадкових чисел 
        private static int GenerateRandomNumber(int limit)
        {
            Random rand = new Random();
            return rand.Next(limit);
        }

        //  метод визначення дискримінанта
        private static double Discriminator(double a, double b, double c)
        {
            double D = (b * b) - 4 * a * c;
            return D;
        }

        // метод визначення кореня квадратного рівняння
        private static double Root(double a, double b, double Discriminator)
        {
            double x = (-b + Math.Sqrt(Discriminator)) / (2 * a);
            return x;
        } 
        static void Main(string[] args)

            // коефіцієнти
        {
            double a = GenerateRandomNumber(100);
            double b = GenerateRandomNumber(100);
            double c = GenerateRandomNumber(100);

            double D = Discriminator(a, b, c);

            // Коренні квадратного рівняння
            double root1, root2;

            if ( D > 0 )
            {
            root1 = Root(a, b, D);
            root2 = Root(a, b, D);
                Console.WriteLine("Roots of the equation: x1 = {0}, x2 = {1}", root1, root2);
            } else if ( D == 0 )
            { 
                root1 = Root(a, b, D);
                    Console.WriteLine("The equation has one root" +
                        ": x = {0}", root1);
            } else
            {
                Console.WriteLine("The equation has no roots");
            }
            Console.ReadLine();
        }
    }
}
