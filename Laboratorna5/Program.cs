using System;
namespace Laboratorna5;

class Program
{
    static void Main(string[] args)
    {
        int n;
        do
        {
            Console.Write("Введіть кількість кроків n(ціле число, n >= 0):");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out n))
            {
                Console.WriteLine("Помилка: потрібно ввести ціле число.");
                n = -1;
            }
            else if (n < 0)
            {
                Console.WriteLine("Помилка: n не може бути від'ємним");
            }
        } while (n < 0);
    }
}