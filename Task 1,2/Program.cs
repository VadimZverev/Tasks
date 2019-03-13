using System;

namespace Task_1_2
{
    class Program
    {
        static void Main()
        {
            bool _continue = true;
            string str;

            int[] array = { 2, 4, 5, 8, 6, 7, 1, 3, 9 };

            Console.WriteLine("Массив до сортировки:");
            Show(array);

            ArraySort(array);

            Console.WriteLine("Массив после сортировки:");
            Show(array);

            do
            {
                try
                {
                    Console.Write("Введите проверяемое число: ");
                    int value = int.Parse(Console.ReadLine());
                    Console.WriteLine("Содержится ли проверяемое число в массиве: " + Contains(array, value));
                }
                catch (Exception)
                {
                    Console.WriteLine("Некорректный ввод.");
                    continue;
                }

                do
                {
                    Console.WriteLine("Ввести ещё раз? 1 - Да, 2 - Нет");
                    str = Console.ReadLine();
                    if (str != "1" && str != "2")
                    {
                        Console.WriteLine("Некорректный ввод.");
                        continue;
                    }

                    break;

                } while (true);

                _continue = str == "2" ? false : true;
            } while (_continue);
        }

        // Задание 1. Метод сортировки есть в библиотеке System в классе Array, называется метод Sort(),
        // являющийся статическим методом с 16 перегрузками.
        /// <summary>
        /// Сортировка целочисленного массива в порядке возрастания.
        /// </summary>
        /// <param name="array">входной массив для сорортировки.</param>
        static void ArraySort(int[] array)
        {
            int[] arr = array;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array.Length > j + 1)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                }
            }
        }

        // Задание 2. Метод содержится в библиотеке System.Linq, является обобщеным
        // методом расширения интерфейса IEnumerable.
        /// <summary>
        /// Проверка, содержится ли целочисленное число в массиве.
        /// </summary>
        /// <param name="array">проверяемый массив.</param>
        /// <param name="value">проверяемое число.</param>
        /// <returns></returns>
        static string Contains(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return "Да";
                }
            }

            return "Нет";
        }

        /// <summary>
        /// Отображает содержимое массива.
        /// </summary>
        /// <param name="array">Отображаемый массив.</param>
        static void Show(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}
