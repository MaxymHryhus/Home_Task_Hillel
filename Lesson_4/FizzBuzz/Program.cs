namespace FizzBuzz
{
    internal class Program
    {
        /*3*) Напишіть програму, яка приймає від користувача число від 1 до 100. 
         * При цьому якщо число кратне трьом, програма повинна виводити слово Fizz, а якщо 
         * кратно п'яти - слово Buzz. Якщо число кратно п'ятнадцяти, програма повинна 
         * виводити слово FizzBuzz. Завдання може здатися очевидним, але потрібно отримати 
         * найбільш просте та красиве рішення.*/

        // Створюємо до кожного ключевого слова свій власний метод
        static bool IsFizzBuzz (int number)
        {
            return number % 15 == 0;
        }
        static bool IsFizz (int number)
        {
            return number % 3 == 0;
        }
        static bool IsBuzz (int number)
        {
            return (number % 5 == 0);
        }
        static void Main(string[] args)
        {
            // Отримуємо число від користувача
            
            Console.WriteLine("Уnter your number from 1 to 100: ");
            byte number = Convert.ToByte(Console.ReadLine());

            // Визначаємо ключове слово за допомогою тернарного оператора

            string keyword = IsFizzBuzz(number) ? "FizzBuzz" : IsFizz(number) ? "Fizz" : IsBuzz(number) ? "Buzz" : "Eror!";

            // Виводимо результат в консоль

            Console.WriteLine(keyword);
            Console.ReadLine();
            
        }
    }
}
