using System;

class Calculator
{
    static void Main()
    {
        int chipi;
        double A1, B2;
        bool exit = false;

        do
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложить 2 числа");
            Console.WriteLine("2. Вычесть первое из второго");
            Console.WriteLine("3. Перемножить два числа");
            Console.WriteLine("4. Разделить первое на второе");
            Console.WriteLine("5. Возвести в степень N первое число");
            Console.WriteLine("6. Найти квадратный корень из числа");
            Console.WriteLine("7. Найти 1 процент от числа");
            Console.WriteLine("8. Найти факториал числа");
            Console.WriteLine("9. Выйти из программы");

            if (int.TryParse(Console.ReadLine(), out chipi))
            {
                switch (chipi)
                {
                    case 1:
                        Console.Write("Введите первое число: ");
                        A1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        B2 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Результат: {A1 + B2}");
                        break;
                    case 2:
                        Console.Write("Введите первое число: ");
                        A1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        B2 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Результат: {A1 - B2}");
                        break;
                    case 3:
                        Console.Write("Введите первое число: ");
                        A1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        B2 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Результат: {A1 * B2}");
                        break;
                    case 4:
                        Console.Write("Введите первое число: ");
                        A1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        B2 = double.Parse(Console.ReadLine());
                        if (B2 != 0)
                        {
                            Console.WriteLine($"Результат: {A1 / B2}");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: деление на ноль.");
                        }
                        break;
                    case 5:
                        Console.Write("Введите число: ");
                        A1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите степень: ");
                        int N = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Результат: {Math.Pow(A1, N)}");
                        break;
                    case 6:
                        Console.Write("Введите число: ");
                        A1 = double.Parse(Console.ReadLine());
                        if (A1 >= 0)
                        {
                            Console.WriteLine($"Результат: {Math.Sqrt(A1)}");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: невозможно извлечь корень из отрицательного числа.");
                        }
                        break;
                    case 7:
                        Console.Write("Введите число: ");
                        A1 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Результат: {A1 / 100}");
                        break;
                    case 8:
                        Console.Write("Введите число: ");
                        A1 = double.Parse(Console.ReadLine());
                        double factis = 1;
                        for (int i = 1; i <= A1; i++)
                        {
                            factis *= i;
                        }
                        Console.WriteLine($"Результат: {factis}");
                        break;
                    case 9:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Ошибка: недопустимая операция.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ошибка: введите целое число.");
            }
        } while (!exit);
    }
}