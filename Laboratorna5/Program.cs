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
        if (n == 0)
            {
                Console.WriteLine("Кроків немає (n = 0): тіло циклу не виконувалось, сума ряду дорівнює 0.");
            }
            else
            {
                Console.WriteLine($"Після {n} кроків: π ≈ {piFor:F8}");
                Console.WriteLine($"Math.PI = {Math.PI:F8}, похибка = {Math.Abs(piFor - Math.PI):F8}");
            }

           //ВЕРСІЯ 2: цикл while (той самий алгоритм) =====
            Console.WriteLine();
            Console.WriteLine("=== Версія 2: цикл while ===");

            double piWhile = 0;
            double signW = 1;
            int i = 0;                       // лічильник кроків, початкове значення 0

            while (i < n)
            {
                piWhile += signW * 4.0 / (2 * i + 1);
                signW = -signW;
                i++;                         // крок, що наближає умову до хибності

                if (i % 100 == 0)
                {
                    Console.WriteLine($"Крок {i}: π ≈ {piWhile:F8}, похибка = {Math.Abs(piWhile - Math.PI):F8}");
                }
            }

            if (n == 0)
            {
                Console.WriteLine("Кроків немає (n = 0): тіло циклу не виконувалось.");
            }
            else
            {
                Console.WriteLine($"Після {n} кроків: π ≈ {piWhile:F8}, похибка = {Math.Abs(piWhile - Math.PI):F8}");
            }

            Console.WriteLine(piFor == piWhile
                ? "Обидві версії дали однаковий результат."
                : "Увага: результати версій відрізняються!");

            // ===== РІВЕНЬ Б: квадрат n x n двома вкладеними циклами =====
            Console.WriteLine();
            Console.WriteLine("=== Рівень Б: квадрат ===");

            int size;
            do
            {
                Console.Write("Введіть сторону квадрата (від 3 до 20): ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out size))
                {
                    Console.WriteLine("Помилка: потрібно ввести ціле число.");
                    size = 0;
                }
                else if (size < 3 || size > 20)
                {
                    Console.WriteLine("Помилка: число має бути в межах від 3 до 20.");
                }
            }
            while (size < 3 || size > 20);

            for (int row = 0; row < size; row++)          // зовнішній цикл — рядки
            {
                for (int col = 0; col < size; col++)      // внутрішній цикл — стовпці
                {
                    char symbol;

                    if (row == col || row + col == size - 1)
                    {
                        symbol = '#';                     // діагоналі (найвищий пріоритет)
                    }
                    else if (row == 0 || row == size - 1 || col == 0 || col == size - 1)
                    {
                        symbol = '*';                     // межа квадрата
                    }
                    else
                    {
                        symbol = ' ';                     // решта клітинок
                    }

                    Console.Write(symbol);
                }
                Console.WriteLine();                      // перехід на новий рядок після рядка
            }
    }
}