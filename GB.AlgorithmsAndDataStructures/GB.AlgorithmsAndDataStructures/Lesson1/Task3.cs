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
        public static int GetFibonacciNumber(int _counter)
        {
            int result;
            if (_counter == 0)
            {
                result = 0;
            }
            else if (_counter == 1)
            {
                result = 1;
            }
            else
            {
                int currentNumber = 1;
                int previousNumber = 0;
                int nextNumber = 0;

                for (int i = 2; i <= _counter; i++)
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
        public static int GetFibonacciNumberRecursion(int _counter)
        {

            int result;
            if (_counter == 0)
            {
                result = 0;
            }
            else if (_counter == 1)
            {
                result = 1;
            }
            else
            {
                result = GetFibonacciNumberRecursion(_counter - 2) + GetFibonacciNumberRecursion(_counter - 1);
            }
            return result;
        }
    }
}
