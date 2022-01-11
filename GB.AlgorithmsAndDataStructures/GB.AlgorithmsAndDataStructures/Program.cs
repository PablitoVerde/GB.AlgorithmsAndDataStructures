using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text;
using System.Reflection;

namespace GB.AlgorithmsAndDataStructures
{
    public class Program
    {
        static void Main()
        {

            // получение данных из сборки, где находятся домашние задания
            var pathToLesson = Directory.GetCurrentDirectory() + @"\Lessons.dll";
            var assembly = Assembly.LoadFile(pathToLesson);
            var type = assembly.GetTypes();
            List<ILesson> listLessons = new List<ILesson>();


            foreach (var t in type)
            {

                if (t.Name.Contains("Task") && t.IsClass)
                {
                    var obj = Activator.CreateInstance(t);

                    ILesson lesson = obj as ILesson;

                    listLessons.Add(lesson);

                }
            }

            bool showmenu = true;

            while (showmenu)
            {
                Console.Clear();

                Console.WriteLine("Для запуска задания, укажите его название.");

                // Получение из сборки только классов, где имеется в названии слово Task (именно в данных классах реализованы домашние задания)
                foreach (ILesson l in listLessons)
                {
                    Console.WriteLine($"{l.Name} | {l.Description}");
                }

                // получение команды от пользователя
                string userCommand = Console.ReadLine();

                ILesson userChoiceTask = listLessons.Find(l => l.Name.ToUpper().Contains(userCommand.ToUpper()));

                userChoiceTask.Demo();

                Console.WriteLine("Хотите продолжить? Y/N");
                string userChoice = Console.ReadLine();

                if (userChoice.ToUpper() == "N")
                {
                    showmenu = false;
                }
                else if (userChoice.ToUpper() != "Y")
                {
                    Console.WriteLine("Команда введена неправильно. Работа программы будет продолжена.");

                }

                Console.ReadKey();
            }
        }
    }
}
