namespace New_element_at_the_beginning
{
    /*3) Потрібно додати до масиву елемент на початок. Нехай масив буде на 10 елементів.
   Масив заповнити рандомними числами. Той елемент, що потрібно додати, також взяти рандомно. */

    internal class Program
    {
        private static int GenerateRandomNumber(int min, int max)
        {
            Random random = new Random();
            return (random.Next(min, max));
        }
        static void Main(string[] args)
        {
            int[] array = new int[10];
            
            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = GenerateRandomNumber(-100, 100);
            }

            foreach (int i in array)
            {
                Console.Write(i + "\t");
            }

            int randomElement = GenerateRandomNumber (-100, 100);

            Console.WriteLine("\n");
            Console.WriteLine("New element : " + randomElement + "\n");

            int[] newArray = new int[array.Length +1];

            newArray[0] = randomElement;

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }

            foreach (int element in newArray)
            {
                Console.Write(element + "\t");
            }

            Console.ReadLine();
        }
    }
}
