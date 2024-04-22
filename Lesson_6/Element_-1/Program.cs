namespace Element__1
{
    /*4) Написати програму, яка виводить всі елементи масиву доки не зустрінеться елемент -1. 
     * Масив заповнити рандомними числами, діапазон чисел від -5 до 5. */

    internal class Program
    {
        private static int GenerateRandomNumber(int min, int max)
        {
            Random random = new Random();
            return (random.Next(min, max));
        }
        static void Main(string[] args)
        {
        
        int[] array = new int[15];   

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = GenerateRandomNumber(-5, 5);
            }
           
            foreach (int i in array)
            {
                
                if (i == -1)
                {
                    break;
                } else
                {
                    Console.Write(i + "\t");
                }
                
            }

            Console.ReadLine();


        }
    }
}
