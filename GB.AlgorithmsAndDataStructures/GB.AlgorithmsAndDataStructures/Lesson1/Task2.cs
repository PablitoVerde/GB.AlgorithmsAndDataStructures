using System;
using System.Collections.Generic;
using System.Text;

/*
 * Посчитайте сложность функции
 */

namespace GB.AlgorithmsAndDataStructures.Lesson1
{
    class Task2 : ILesson
    {
        public string Name => "Task1.2";

        public string Description => "Подсчет сложности функции";

        public void Demo()
        {
            Console.WriteLine("Сложность функции составит O(N^3)");
            Console.ReadKey();
        }


        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0; //O(1)
            for (int i = 0; i < inputArray.Length; i++) //O(N)
            {
                for (int j = 0; j < inputArray.Length; j++) //O(N)
                {
                    for (int k = 0; k < inputArray.Length; k++) //O(N)
                    {
                        int y = 0; //O(1)

                        if (j != 0) //O(1)
                        {
                            y = k / j; //O(1)
                        }

                        sum += inputArray[i] + i + k + j + y; //O(1)
                    }
                }
            }

            return sum; //O(1)
        }
    }
}
