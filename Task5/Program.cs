// Задание 5. Игра «Угадай число»

using System;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Выводим приглашение пользователю ввести верхнюю границу.
            Console.Write("Введите максимальное целое число диапазона: ");

            // Считываем текст с консоли, преобразуем в число и сохраняем.
            int maxValue = int.Parse(Console.ReadLine());

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
                int userNumber = int.Parse(userInput);

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