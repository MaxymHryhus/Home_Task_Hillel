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

        // метод визначення кореня x1 квадратного рівняння
        private static double Root1(double a, double b, double Discriminator)
        {
            double x1 = (-b + Math.Sqrt(Discriminator)) / (2 * a);
            return x1;
        } 

        // метод визначення корення х2 квадратного рівняння
        
        private static double Root2(double a, double b, double Discriminator)
        {
            double x2 = (-b - Math.Sqrt(Discriminator)) / (2 * a);
            return x2;
        }

        // метод виведення у консоль першого рівнння
        private static void Print1(double b, double D, double a) 
        {
            Console.WriteLine("- {0} + √{1} / (2 * {2})", b, D, a);
        }

        // метод виведення у консоль другого рівнння
        private static void Print2(double b, double D, double a)
        {
            Console.WriteLine("- {0} - √{1} / (2 * {2})", b, D, a);
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
                Print1(a, b, D);
                Print2(a, b, D);
                root1 = Root1(a, b, D);
                root2 = Root2(a, b, D);
                Console.WriteLine("Roots of the equation: x1 = {0}, x2 = {1}", root1, root2);
            } else if ( D == 0 )
            {
                Print1(a, b, D);
                root1 = Root1(a, b, D);
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
