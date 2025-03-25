using System;

class Lpr20
{
    static double SolveLinearEquation(double a, double b)
    {
        if (a == 0)
        {
            if (b == 0)
                throw new ArgumentException("Рівняння має безліч рішень.");
            else
                throw new ArgumentException("Рівняння не має розв'язків.");
        }
        return -b / a;
    }

    static void Main()
    {
        while (true)
        {
            try
            {
                Console.Write("Введіть коефіцієнт a (або 'стоп' для виходу): ");
                string inputA = Console.ReadLine();
                if (inputA.ToLower() == "стоп") break;
                double a = Convert.ToDouble(inputA);

                Console.Write("Введіть коефіцієнт b: ");
                string inputB = Console.ReadLine();
                if (inputB.ToLower() == "стоп") break;
                double b = Convert.ToDouble(inputB);

                double root = SolveLinearEquation(a, b);
                Console.WriteLine($"Розв'язок рівняння: x = {root}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка: введене значення не є числом.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Непередбачена помилка: {ex.Message}");
            }
        }
    }
}
