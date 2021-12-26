using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text;

namespace GB.AlgorithmsAndDataStructures
{
    class Program
    {
        static void Main()
        {

            List<ILesson> lessons = Lesson6.UserOptions.LoadTasks();

            Console.WriteLine("Для запуска задания, укажите его название.");

            foreach (ILesson l in lessons)
            {
                Console.WriteLine($"{l.Name} {l.Description}");
            }

            string userCommand = Console.ReadLine();

            foreach (ILesson l in lessons)
            {
                if (userCommand.ToUpper() == l.Name.ToUpper())
                {
                    l.Demo();
                    break;
                }
            }

            Console.ReadKey();

        }
    }
}
