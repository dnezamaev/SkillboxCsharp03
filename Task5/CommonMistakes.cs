﻿using System;

namespace Task5
{
    internal class CommonMistakes
    {
        public static void ErrorOnNotNumberInput()
        {
            Console.Write("Введите максимальное целое число диапазона: ");
            int secretNumber = new Random().Next(Convert.ToInt32(Console.ReadLine()));

            while (true)
            {
                Console.WriteLine("Попробуйте угадать число (пустая строка - выход):");

                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == -1) // ???
                {
                    Console.WriteLine($"Было загадано число {secretNumber}");
                    break;
                }
            }
        }

        public static void CorrectQuitOnEmptyString()
        {
            Console.Write("Введите максимальное целое число диапазона: ");
            int secretNumber = new Random().Next(Convert.ToInt32(Console.ReadLine()));

            while (true)
            {
                Console.WriteLine("Попробуйте угадать число (пустая строка - выход):");
                string userInput = Console.ReadLine();

                if (string.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine($"Было загадано число {secretNumber}");
                    break;
                }

                int userNumber = Convert.ToInt32(userInput);
            }
        }

        public static void MultipleConverts()
        {
            Console.Write("Введите максимальное целое число диапазона: ");
            int secretNumber = new Random().Next(Convert.ToInt32(Console.ReadLine()));

            while (true)
            {
                Console.WriteLine("Попробуйте угадать число (пустая строка - выход):");
                string userInput = Console.ReadLine();

                if (string.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine($"Было загадано число {secretNumber}");
                    break;
                }

                if (Convert.ToInt32(userInput) > secretNumber)
                {
                    Console.WriteLine("Загаданное число меньше.\n");
                }
                else if (Convert.ToInt32(userInput) < secretNumber)
                {
                    Console.WriteLine("Загаданное число больше.\n");
                }
                else
                {
                    Console.WriteLine("Число отгадано!");
                    break;
                }
            }
        }

        public static void Solution()
        {
            // Выводим приглашение пользователю ввести верхнюю границу.
            Console.Write("Введите максимальное целое число диапазона: ");

            // Считываем текст с консоли, преобразуем в число и сохраняем.
            int maxValue = Convert.ToInt32(Console.ReadLine());

            // Создаем генератор псевдослучайных чисел.
            Random rng = new Random();

            // Получаем от него число, которое нужно угадать.
            int secretNumber = rng.Next(maxValue + 1);

            // Цикл угадывания.
            while (true)
            {
                // Выводим приглашение пользователю ввести очередное число.
                Console.WriteLine(
                    $"Введите целое число от 0 до {maxValue} включительно.\n" +
                    $"Для выхода введите пустую строку (просто нажмите Enter).");

                // Считываем текст с консоли и сохраняем.
                string userInput = Console.ReadLine();

                // Сравниваем его с пустой строкой.
                if (string.IsNullOrEmpty(userInput))
                {
                    // Показываем загаданное число и выходим из программы.
                    Console.WriteLine($"Было загадано число {secretNumber}");
                    break;
                }

                // Преобразуем введенный текст в число.
                int userNumber = Convert.ToInt32(userInput);

                // Проверяем больше ли введенное число, чем загаданное.
                if (userNumber > secretNumber)
                {
                    Console.WriteLine("Загаданное число меньше.\n");
                }
                // Проверяем меньше ли введенное число, чем загаданное.
                else if (userNumber < secretNumber)
                {
                    Console.WriteLine("Загаданное число больше.\n");
                }
                // Не больше и не меньше, значит совпадает.
                else
                {
                    // Сообщаем об успехе пользователю и выходим из цикла.
                    Console.WriteLine("Число отгадано!");
                    break;
                }
            }

            // Задержка перед выходом.
            Console.ReadKey(true);

        }
    }
}
