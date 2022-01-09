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

            bool showmenu = true;

            while (showmenu)
            {
                Console.Clear();

                Console.WriteLine("Для запуска задания, укажите его название.");

                // Получение из сборки только классов, где имеется в названии слово Task (именно в данных классах реализованы домашние задания)
                foreach (var t in type)
                {

                    if (t.Name.Contains("Task") && t.IsClass)
                    {
                        var obj = Activator.CreateInstance(t);
                        var objName = t.GetProperty("Name", BindingFlags.Instance | BindingFlags.Public);
                        var objDescription = t.GetProperty("Description", BindingFlags.Instance | BindingFlags.Public);

                        Console.WriteLine($"{objName.GetValue(obj)} | {objDescription.GetValue(obj)}");
                    }
                }

                // получение команды от пользователя
                string userCommand = Console.ReadLine();

                //проход списка сущностей из сборки на предмет поиска нужного класса и вызов демонстрационного метода
                foreach (var t in type)
                {

                    if (t.Name.Contains("Task") && t.IsClass)
                    {
                        var obj = Activator.CreateInstance(t);

                        if (t.GetProperty("Name").GetValue(obj).ToString().ToUpper() == userCommand.ToUpper())
                        {
                            var demoMethod = t.GetMethod("Demo");
                            demoMethod.Invoke(obj, null);
                            break;
                        }
                    }
                }

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
