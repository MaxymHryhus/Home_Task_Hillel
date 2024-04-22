namespace Number_positive_numbers
{
   /* 1) Задати масив із 10 елементів.Заповнити цей масив рандомними числами від -100 до 100. 
    * Знайти кількість додатніх чисел у масиві.Вивести на екран масив і кількість порахованих 
    * чисел.
{ 5, -9, 8, 7} =>{5, -9, 8, 7} , кількість додатних чисел = 3  
(фігурні дужки і коми, звісно, можна не виводити в консоль!!!)*/
    internal class Program
    {
        // метод генерації випадкових чисел
        private static int GenerateRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        static void Main(string[] args)
        {
            // Створюємо масив з 10 елементів

            int[] numbers = new int[10];

            // заповнюємо масив випадковими числами циклом for

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = GenerateRandomNumber(-100, 100);
            }

            // Створюємо зміну під лічильник додатніх чисел

            int positiveNumbers = 0;

            // Створюємо цикл для виведення поточного масиву і для підрахунку додатніх чисел

            foreach (int number in numbers)
            {
                Console.Write(number + "\t" );

                if( number > 0 ) 
                {
                positiveNumbers++;
                }
            }

            Console.WriteLine("\n");

            // Виводимо кількість додатніх чиел на екран

            Console.WriteLine("The number of positive numbers: " + positiveNumbers);

            Console.ReadLine();
            
        }
    }
}
