using System;
using static System.Collections.Specialized.BitVector32;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Выберите коменду:");
        Console.WriteLine("1.Сложение");
        Console.WriteLine("2.Вычетание");
        Console.WriteLine("3.Умножение");
        Console.WriteLine("4.Деление");
        Console.WriteLine("5.Возвести в степень");
        Console.WriteLine("6.Квадратный корень");
        Console.WriteLine("7.Найти 1 процент от числа");
        Console.WriteLine("8.Факториал");
        Console.WriteLine("9.Выход");
        int ii = 1;
        do
        {
            Console.WriteLine("Ваше значение?");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine("Первое число:");
                double first = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Второе число:");
                double second = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Результат: ");
                Console.WriteLine(first + second);
            }
            if (number == 2)
            {
                Console.WriteLine("Первое число:");
                double first = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Второе число:");
                double second = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Результат: ");
                Console.WriteLine(first - second);
            }
            if (number == 3)
            {
                Console.WriteLine("Первое число:");
                double first = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Второе число:");
                double second = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Результат: ");
                Console.WriteLine(first * second);
            }
            if (number == 4)
            {
                Console.WriteLine("Первое число:");
                double first = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Второе число:");
                double second = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Результат: ");
                Console.WriteLine(first / second);
            }
            if (number == 5)
            {
                Console.WriteLine("Число:");
                double first = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Степень:");
                double second = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Результат: ");
                Console.WriteLine(Math.Pow(first, second));
            }
            if (number == 6)
            {
                Console.WriteLine("Число:");
                double first = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Результат: ");
                Console.WriteLine(Math.Sqrt(first));
            }
            if (number == 7)
            {
                Console.WriteLine("Число:");
                double first = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Результат: ");
                Console.WriteLine(first / 100);
            }
            if (number == 8)
            {
                Console.WriteLine("Число:");
                int first = Convert.ToInt32(Console.ReadLine());
                int second = 1;
                Console.WriteLine("Результат: ");
                for (int i = 1; i <= first; i++)
                {
                    second = second * i;
                }
                Console.WriteLine(second);
            }
            ii = number;
        }
        while (ii <= 8);
    }
}