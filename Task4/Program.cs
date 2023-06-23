﻿using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Выводим приглашение пользователю ввести длину последовательности.
            Console.Write("Введите длину последовательности: ");

            // Считываем текст с консоли, преобразуем в число и сохраняем.
            int count = int.Parse(Console.ReadLine());

            // Минимальное число в последовательности.
            // Инициализируем максимально возможным.
            int minNumber = int.MaxValue;

            // Цикл для обработки каждого числа.
            for (int i = 0; i < count; i++)
            {
                // Выводим приглашение пользователю ввести очередное число.
                Console.Write("Введите число: ");

                // Считываем текст с консоли, преобразуем в число и сохраняем.
                int inputNumber = int.Parse(Console.ReadLine());

                // Если введенное число меньше текущего найденного минимума последовательности,
                // то сохраняем его в качестве нового минимума.
                if (inputNumber < minNumber)
                {
                    minNumber = inputNumber;
                }
            }

            // Выводим результат и делаем задержку перед выходом из программы.
            Console.WriteLine($"Минимальное число последовательности: {minNumber}");
            Console.ReadKey(true);
        }
    }
}