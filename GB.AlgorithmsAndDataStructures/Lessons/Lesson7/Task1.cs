using System;
using System.Collections.Generic;
using System.Text;

/*
    Задача на количество вариантов
    У исполнителя «Калькулятор» две команды, которым присвоены номера:
    Прибавь 1.
    Умножь на 2.
    P(1) = 1;
    P(N) = P(N – 1) + P(N / 2), при N > 1, если N кратно 2;
    P(N) = P(N – 1), при N > 1, если N не кратно 2.
*/

namespace GB.AlgorithmsAndDataStructures.Lesson7
{
    class Task1 : ILesson
    {
        public string Name => "Task7.1";

        public string Description => "Задача на количество вариантов";

        public void Demo()
        {
            Console.WriteLine("Задача на количество вариантов. Будет проведен подсчет от 1 до 100");

            for (int i = 1; i <= 100; i++)
            {
                int variants = GetVariantsCount(i);
                Console.WriteLine($"Для числа {i} существует вариантов подбора: {variants}");
            }
        }

        /// <summary>
        /// Метод подсчета количества вариантов. Используется рекурсия.
        /// </summary>
        /// <param Число="number"></param>
        /// <returns></returns>
        public int GetVariantsCount(int number)
        {
            int result = 0;

            if (number == 1)
            {
                result = 1;
            }
            else if (number % 2 == 0)
            {
                result = GetVariantsCount(number - 1) + GetVariantsCount(number / 2);
            }
            else if (number % 2 == 1)
            {
                result = GetVariantsCount(number - 1);
            }

            return result;
        }
    }
}
