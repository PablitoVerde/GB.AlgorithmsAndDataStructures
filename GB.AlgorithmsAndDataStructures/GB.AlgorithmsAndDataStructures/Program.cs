using System;
using System.Collections.Generic;

namespace GB.AlgorithmsAndDataStructures
{
    class Program
    {
       static List<ILesson> lessons = new List<ILesson>()
        {
            new Lesson1.Task1(),
            new Lesson1.Task2(),
            new Lesson1.Task3()
        };

        static void Main()
        {

            Console.WriteLine("Для запуска задания, укажите его название.");

            foreach(ILesson l in lessons)
            {
                Console.WriteLine($"{l.Name} {l.Description}");
            }

            string userCommand = Console.ReadLine();

            foreach (ILesson l in lessons)
            {
                if (userCommand==l.Name)
                {
                    l.Demo();
                    break;
                }
            }

            Console.ReadKey();

        }
    }
}
