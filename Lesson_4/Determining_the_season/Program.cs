using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Determining_the_season
{
    internal class Program
    {
        /*2) Написати програму, в якій користувач вводить номер місяця. Якщо місяць 1,2,12 
         * відображає "Зима"; 3,4,5 - «Весна»; 6-8 - «Літо»; 9-11 – «Осінь». У будь-якому 
         * іншому випадку - "Немає такого місяця на цій планеті" .*/

        static void Main(string[] args)
        {
            // Створюємо змінні під пори року (можна і не створювати) і під номерацію місяця

            string winter = "Winter";
            string spring = "Spring";
            string summer = "Summer";
            string autumm = "Autumm";
            byte month_Number = 0;

            // Просимо у користувача ввести номер місяця

            Console.WriteLine("Enter the month number: ");
            month_Number = Convert.ToByte(Console.ReadLine());

            // Визначаємо місяць на основі введених даних 

            switch(month_Number)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Your season is " + winter);
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Your season is " + spring);
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Your season is " + summer);
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Your season is " + autumm);
                    break;  
                default:
                    Console.WriteLine("There is no such month on this planet!");
                    break;
            }

            Console.ReadLine();

        }
    }
}
