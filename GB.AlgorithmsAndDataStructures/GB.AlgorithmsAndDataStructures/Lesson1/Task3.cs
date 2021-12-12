using System;
using System.Collections.Generic;
using System.Text;


/*
 Реализуйте функцию вычисления числа Фибоначчи
1. Реализовать рекурсивную версию и версию без рекурсии (через цикл);
2. Обе реализации сделать методами отдельного класса;
3. На вход методы должны принимать целочисленный параметр, определяющий количество элементов формируемой последовательности.
*/

namespace GB.AlgorithmsAndDataStructures.Lesson1
{
    class Task3 : ILesson
    {
        public string Name => "Task1.3";

        public string Description => "Расчет числа Фибоначчи по порядковому номеру";

        public void Demo()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Число Фибоначчи с индексом {i}. Подсчет через цикл. Число - {GetFibonacciNumber(i)}");
                Console.WriteLine($"Число Фибоначчи с индексом {i}. Подсчет через рекурсию. Число - {GetFibonacciNumberRecursion(i)}");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Метод вычисления числа Фибоначчи через цикл
        /// </summary>
        /// <param порядковый номер элемента="_counter"></param>
        /// <returns></returns>
        public static int GetFibonacciNumber(int counter)
        {
            int result;
            if (counter == 0)
            {
                result = 0;
            }
            else if (counter == 1)
            {
                result = 1;
            }
            else
            {
                int currentNumber = 1;
                int previousNumber = 0;
                int nextNumber = 0;

                for (int i = 2; i <= counter; i++)
                {
                    nextNumber = currentNumber + previousNumber;
                    previousNumber = currentNumber;
                    currentNumber = nextNumber;
                }
                result = nextNumber;
            }
            return result;

        }

        /// <summary>
        /// Метод вычисления числа Фибоначчи через рекурсию
        /// </summary>
        /// <param порядковый номер элемента="_counter"></param>
        /// <returns></returns>
        public static int GetFibonacciNumberRecursion(int counter)
        {

            int result;
            if (counter == 0)
            {
                result = 0;
            }
            else if (counter == 1)
            {
                result = 1;
            }
            else
            {
                result = GetFibonacciNumberRecursion(counter - 2) + GetFibonacciNumberRecursion(counter - 1);
            }
            return result;
        }
    }
}
