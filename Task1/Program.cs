using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Выводим приглашение пользователю ввести число.
            Console.WriteLine("Введите целое число:");

            // Считываем текст с консоли и сохраняем.
            string input = Console.ReadLine();

            // Преобразуем введенный текст в число.
            int number = int.Parse(input);

            // Проверяем на чётность.
            if (number % 2 == 0)
            {
                Console.WriteLine($"Число {number} является чётным.");
            }
            else
            {
                Console.WriteLine($"Число {number} является нечётным.");
            }

            Console.ReadKey();
        }
    }
}