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
        
        Console.WriteLine();
        Console.WriteLine("=== Версія 1: цикл for ===");

        double piFor = 0;      
        double sign = 1;       

        for (int k = 0; k < n; k++)
        {
            piFor += sign * 4.0 / (2 * k + 1); 
            sign = -sign;                      

            int step = k + 1;                  
            if (step % 100 == 0)              
            {
                Console.WriteLine($"Крок {step}: π ≈ {piFor:F8}, похибка = {Math.Abs(piFor - Math.PI):F8}");
            }
        }
    }
}