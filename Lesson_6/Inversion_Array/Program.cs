namespace Array_inversion
{
    /* 2) Написати програму для інверсії масиву, тобто перевороту його у зворотному порядку. В 
     * цьому завданні недостатньо просто вивести елементи масиву у зворотному порядку. 

    Ідеально написати 2 способами(*вища оцінка буде) - через новий масив та переписавши 
    значення заданного масиву.*/
    internal class Program
    {
        static void Main(string[] args)
        {
             #region Version 1
             int[] array = {1,2,3,4,5};

             // Створюємо новий масив для збереження інверсії

             int[] newArray = new int[array.Length];


             // Переносимо елементи у зворотньому порядку

             for (int i = 0; i < array.Length; i++) 
             {
                 newArray[i] = array[array.Length - 1 - i];
             }

             // Виводимо новий масив

             foreach (int i in newArray)
             {
                 Console.WriteLine(i + " ");
             }

             Console.ReadLine();
             #endregion 
            #region Version2
            int[] array = {1, 2, 3, 4, 5 };

            // переписуємо масив
            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }

            foreach (int i in array)
            {
                Console.WriteLine(i + " ");
            }
            Console.ReadLine();
            #endregion
        }
    }
}