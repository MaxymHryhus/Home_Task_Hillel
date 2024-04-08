namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Параметри книги
             string nameBook = "Rich dad pool dad";
             string authorBook = " Robert Kiyosaki";
             ushort yearBook = 2005;
             byte costBook = 250;

            // Форматований рядок для виведення інформації
            string infoBook = string.Format("Name: {0}, Author: {1}, Year: {2}, Cost: {3}", nameBook, authorBook, yearBook, costBook);

            // ВИведення інформації в консоль
            Console.WriteLine(infoBook);
            Console.ReadLine();
        }
    }
}
