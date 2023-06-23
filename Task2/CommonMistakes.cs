using System;

namespace Task2
{
    internal class CommonMistakes
    {
        /// <summary>
        /// Ошибка. Преобразование текста в число.
        /// </summary>
        void ConvertWithConsoleReadLine()
        {
            Console.Write("Введите количество карт: ");

            int count = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < count; i++)
            {               
                Console.WriteLine($"Введите карту {i + 1}:");

                int value = Convert.ToInt32(Console.ReadLine());
                sum += value;
            }

            Console.WriteLine($"Сумма карт: {sum}");
            Console.ReadKey(true);
        }

        /// <summary>
        /// Решение. Разделить чтение с консоли и преобразование в число.
        /// Проблема. Дублирование кода, огромный switch.
        /// </summary>
        void GiantSwitch(int sum, int i)
        {
            switch (Console.ReadLine())
            {
                case "2":
                    sum += 2;
                    break;
                case "3":
                    sum += 3;
                    break;
                case "4":
                    sum += 4;
                    break;
                case "5":
                    sum += 5;
                    break;
                case "6":
                    sum += 6;
                    break;
                case "7":
                    sum += 7;
                    break;
                case "8":
                    sum += 8;
                    break;
                case "9":
                    sum += 9;
                    break;
                case "10":
                    sum += 10;
                    break;
                case "J":
                    sum += 10;
                    break;
                case "Q":
                    sum += 10;
                    break;
                case "K":
                    sum += 10;
                    break;
                case "T":
                    sum += 10;
                    break;
                default:
                    Console.WriteLine("Такой карты не бывает.");
                    i--;
                    break;
            }
        }

        /// <summary>
        /// Решение. Объединить обработку картинок, оставив для них одно тело case.
        /// Проблема. Разбор цифровых карт с кучей однотипных case.
        /// </summary>
        void SwitchWithManyTooCases(int sum, int i)
        {
            switch (Console.ReadLine())
            {
                case "2":
                    sum += 2;
                    break;
                case "3":
                    sum += 3;
                    break;
                case "4":
                    sum += 4;
                    break;
                case "5":
                    sum += 5;
                    break;
                case "6":
                    sum += 6;
                    break;
                case "7":
                    sum += 7;
                    break;
                case "8":
                    sum += 8;
                    break;
                case "9":
                    sum += 9;
                    break;
                case "10":
                    sum += 10;
                    break;
                case "J":
                case "Q":
                case "K":
                case "T":
                    sum += 10;
                    break;
                default:
                    Console.WriteLine("Такой карты не бывает.");
                    i--;
                    break;
            }
        }

        /// <summary>
        /// Решение. Использовать универсальный метод для разбора картинок.
        /// Проблема. Нет обработки несуществующих цифровых карт.
        /// </summary>
        void ParseDigitalCardsWithoutIntervalCheck(int sum, int i)
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "K":
                case "Q":
                case "J":
                case "T":
                    sum += 10;
                    break;

                default:
                    bool isNumber = int.TryParse(userInput, out int cardValue);

                    if (isNumber)
                    {
                        sum += cardValue;
                    }
                    else
                    {
                        Console.WriteLine("Такой карты не бывает.");
                        i--;
                    }
                    break;
            }
        }

        /// <summary>
        /// Решение. Проверять диапазон после преобразования.
        /// </summary>
        void Solution(int sum, int i)
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "K":
                case "Q":
                case "J":
                case "T":
                    sum += 10;
                    break;

                default:
                    bool isNumber = int.TryParse(userInput, out int cardValue);

                    if (isNumber && cardValue >= 2 && cardValue <= 10)
                    {
                        sum += cardValue;
                    }
                    else
                    {
                        Console.WriteLine("Такой карты не бывает.");
                        i--;
                    }
                    break;
            }
        }
    }
}
