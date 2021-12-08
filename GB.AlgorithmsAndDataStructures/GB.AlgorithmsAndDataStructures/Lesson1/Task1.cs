using System;
using System.Collections.Generic;
using System.Text;

/*
 * Требуется реализовать на C# функцию согласно блок-схеме. Блок-схема описывает алгоритм проверки, простое число или нет.
1. Реализовать в виде консольного приложения.
2. Алгоритм реализовать в отдельном классе согласно блок-схеме.
3. Написать проверочный код (один положительный, один отрицательный сценарий) в отдельной функции и вызывать его при запуске.
4. Код выложить на GitHub.
*/


namespace GB.AlgorithmsAndDataStructures.Lesson1
{
    class Task1 : ILesson
    {
        public string Name => "Task1.1";

        public string Description => "Проверка чисел на простые или непростые.";

        static void Demo()
        {
            int i = 6;
            IsSimple(i);

            i = 5;
            IsSimple(i);
        }

        /// <summary>
        /// Пользовательский интерфейс на проверку введенного числа
        /// </summary>
        static void StartCheck()
        {
            bool menu = true;
            int tryCount = 1;

            while (menu)
            {
                Console.Write("Введите число: ");

                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    menu = false;
                    IsSimple(number);
                }
                catch
                {
                    Console.Write("Неверный ввод. Нажмите любую клавишу, чтобы начать заново.");
                    tryCount++;
                    Console.ReadKey();
                }

                if (tryCount == 3)
                {
                    Console.Write("Неверный ввод. Приложение будет остановлено.");
                    Console.ReadKey();
                    menu = false;
                }
            }
        }

        /// <summary>
        /// Метод проверки число на количество делителей. Если их 2 (1 и само число) - число простое. В обратном случае - непростое.
        /// </summary>
        /// <param Число для проверки="_number"></param>
        static void IsSimple(int _number)
        {
            int d = 0;

            for (int i = 2; i < _number; i++)
            {
                if (_number % i == 0)
                {
                    d++;
                }
            }

            if (d == 0)
            {
                Console.WriteLine($"Число {_number} простое.");
            }
            else
            {
                Console.WriteLine($"Число {_number} непростое.");
            }

            Console.ReadKey();
        }

        void ILesson.Demo()
        {
            throw new NotImplementedException();
        }
    }
}
