using System;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;

            do
            {
                Console.Write("Введите слова через пробел: ");

                string str = Console.ReadLine();
                string[] words = str.Split(new[] { ' ' });

                UniqueWords(words);

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

                if (str == "2")
                {
                    break;
                }

            } while (true);

        }

        public static void UniqueWords(string[] words)
        {
            Console.Write("Уникальные слова в строке: ");

            for (int i = 0; i < words.Length; i++)
            {
                bool unique = false;

                for (int j = words.Length - 1; j >= 0; j--)
                {
                    if (i != j)
                    {
                        if (words[i] == words[j])
                        {
                            break;
                        }
                    }

                    if (j - 1 == -1)
                    {
                        unique = true;
                    }
                }

                if (unique)
                {
                    Console.Write($"{words[i]} ");
                }
            }

            Console.WriteLine();
        }
    }
}
