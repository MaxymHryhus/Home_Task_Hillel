namespace Password_verification
{

    // 1) Напишіть програму, яка «запитуватиме» правильний пароль, доки він не буде введений.
    // Правильний пароль нехай буде "root". Якщо пароль неправильний, програма повинна
    // сказати "Неправильний пароль!"
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задаємо правильний пароль через константу

            const string Password = "root";

            while (true) 
            {
                // запит на введення паролю

                Console.WriteLine("Enter your password");
                string unverifiedPassword = Console.ReadLine();

                // перевірка на коректність паролю

                if(unverifiedPassword != Password)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid password!");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                } else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Password accepted!");
                    Console.ReadKey();
                    break;
                }
            }
            
            

        }
    }
}
