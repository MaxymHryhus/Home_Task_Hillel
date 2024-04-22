namespace More_or_less
{

    // 2) Програма загадує число від 1 до 146 (привіт, Random). Користувач намагається вгадати
    // його. У разі неправильної відповіді програма підказує «більше» або «менше»

    internal class Program
    {
        // метод генерації рандомного числа
        private static byte GenerateRandomNumber(byte min, byte max)
        {
            Random rand = new Random();
            return (byte)rand.Next(min, max);
        }
        static void Main(string[] args)
        {
            // генеруємо число від 1 до 146
            byte randomNumber = GenerateRandomNumber(1,146);

            while(true)
            {
                // запит користувачу на введення числа

                Console.WriteLine("Guess the number from 1 to 146: ");
                byte guessedNumber = Convert.ToByte(Console.ReadLine());

                //Console.WriteLine(randomNumber); //для перевірки

                if (guessedNumber > randomNumber)
                {
                    Console.WriteLine("Less!");
                    continue;
                }
                else if (guessedNumber < randomNumber)
                {
                    Console.WriteLine("More!");
                    continue;
                }
                else if (guessedNumber == randomNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You guessed the number!");
                    Console.ReadKey();
                    break;
                }
            }
            
        }
    }
}
