using System;
class Program
{
    static void Main()
    {
        int ii = 1;
        do
        {
            Console.WriteLine("Выберите программу, которую вы хотите запустить:");
            Console.WriteLine("1. Угадай число");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей чила");
            Console.WriteLine("4. Закрыть программу");
            Console.WriteLine("Ваш выбор?");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine("Игра Угадай число (от 0 до 100)");
                Random rnd = new Random();
                int value = rnd.Next(0, 100);
                int iii = 101;
                do
                {
                    Console.WriteLine("Введите число ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num > value)
                    {
                        Console.WriteLine("Надо меньше");
                    }
                    if (num < value)
                    {
                        Console.WriteLine("Надо больше");
                    }
                    iii = num;
                }
                while (iii != value);
                Console.WriteLine("Правильно!!! Загаданное число - " + value);
            }
            if (number == 2)
            {
                for (int i = 1; i < 10; i++)
                {
                    for (int j = 1; j < 10; j++)
                    {
                        Console.Write(i * j + "\t");
                    }
                    Console.WriteLine("");
                }
            }
            if (number == 3)
            {
                Console.Write("Введите число ");
                int num = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= num; i++)
                    if (num % i == 0)
                        Console.Write(i + " ");
                Console.WriteLine("");
            }
            ii = number;
        }
        while (ii <= 3);
    }
}