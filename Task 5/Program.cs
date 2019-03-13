using System;

namespace Task_5
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            do
            {
                Console.Write("Введите скобочную последовательность: ");
                string str = Console.ReadLine();

                Console.WriteLine($"Является ли строка правильной скобочной последовательностью: {IsCorrectBracketSequence(str)}");

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

        public static bool IsCorrectBracketSequence(string str)
        {
            int openParenthesis = 0, closeParenthesis = 0,
                openSquareBracket = 0, closeSquareBracket = 0,
                openCurlyBrace = 0, closeCurlyBrace = 0;

            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case '(':
                        openParenthesis++;
                        if (str[i + 1] == ']' || str[i + 1] == '}')
                        {
                            return false;
                        }
                        break;
                    case ')':
                        closeParenthesis++;
                        break;
                    case '[':
                        openSquareBracket++;
                        if (str[i + 1] == ')' || str[i + 1] == '}')
                        {
                            return false;
                        }
                        break;
                    case ']':
                        closeSquareBracket++;
                        break;
                    case '{':
                        openCurlyBrace++;
                        if (str[i + 1] == ')' || str[i + 1] == ']')
                        {
                            return false;
                        }
                        break;
                    case '}':
                        closeCurlyBrace++;
                        break;
                }
            }

            if (openCurlyBrace == 0 &&
                openParenthesis == 0 &&
                openSquareBracket == 0)
            {
                return false;
            }

            if (openParenthesis != closeParenthesis ||
                openSquareBracket != closeSquareBracket ||
                openCurlyBrace != closeCurlyBrace)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
