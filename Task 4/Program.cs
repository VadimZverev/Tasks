using System;

namespace Task_4
{
    class Program
    {
        // Рекурсивный метод.
        public static ulong FactR(ulong value)
        {
            ulong result;

            if (value == 1)
            {
                return 1;
            }

            result = FactR(value - 1) * value;

            return result;
        }

        // Итерационный метод.
        public static ulong FactI(ulong value)
        {
            ulong result = 1;

            for (ulong i = 1; i <= value; i++)
            {
                result *= i;
            }

            return result;
        }

        static void Main()
        {
            int number;   // Выбор используемого метода.
            ulong value;  // Выбор факториала.
            string str;   // Строка для проверки выхода из приложения.

            do
            {

                do
                {
                    try
                    {
                        Console.WriteLine("Выберете метод поиска факториала числа: 1 - Рекурсивный, 2 - Итерационный");

                        number = Convert.ToInt32(Console.ReadLine());

                        if (number != 1 && number != 2)
                        {
                            throw new Exception();
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Необходимо выбрать метод поиска факториала числа!");
                        continue;
                    }

                    break;

                } while (true);

                do
                {
                    try
                    {
                        Console.Write("Введите число от 1 до 65: ");

                        value = ulong.Parse(Console.ReadLine());

                        if (value < 1 || value > 65)
                        {
                            throw new Exception();
                        }

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Необходимо ввести число в заданном диапозоне чисел!");
                        continue;
                    }

                    break;

                } while (true);

                if (number == 1)
                {
                    Console.WriteLine($"Факториал числа {value} рекурсивным методом равен {FactR(value)}");
                }
                else if (number == 2)
                {
                    Console.WriteLine($"Факториал числа {value} итерационным методом равен {FactI(value)}");
                }

                do
                {
                    Console.WriteLine("Начать сначало? 1 - Да, 2 - Нет");

                    str = Console.ReadLine();

                    if (str != "1" && str != "2")
                    {
                        Console.WriteLine("Некорректный ввод.");
                        continue;
                    }
                    break;

                } while (true);

                if (str == "2")
                {
                    break;
                }

            } while (true);
        }
    }
}
