using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;

// Реализовать загрузку списка уроков из файла. 

namespace GB.AlgorithmsAndDataStructures.Lesson6
{
    public class UserOptions
    {

        public static List<ILesson> LoadTasks()
        {
            List<ILesson> lessons = new List<ILesson>()
        {
            new Lesson1.Task1(),
            new Lesson1.Task2(),
            new Lesson1.Task3(),
            new Lesson2.Task1(),
            new Lesson3.Task1(),
            new Lesson4.Task1(),
            new Lesson5.Task1()
        };

            //настройки программы хранят список уроков. Файл хранится в папке пользователя, а не в папке приложения
            StringBuilder userOptionsPath = new StringBuilder();
            userOptionsPath.Append(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
            userOptionsPath.Append((@"\GB.AlgorithmsAndDataStructures\"));

            string filePath = userOptionsPath.ToString() + @"\appsettings.json";

            if (File.Exists(filePath))
            {
                //Проверка на "битые" настройки. В случае их неисправности, файл удаляется, настройки создаются "дефолтными"
                try
                {
                    //если пользовательский файл существует, то считываем настройки из него
                    string str = File.ReadAllText(filePath);
                    lessons = JsonSerializer.Deserialize<List<ILesson>>(str);
                }
                catch
                {
                    //Если при считывании настроек произошла ошибка, файл удалятся
                    File.Delete(filePath);
                }
            }
            else
            {
                //Если пути до настроек нет, то он создается сам. В файл будут записаны "дефолтные" настройки
                Directory.CreateDirectory(userOptionsPath.ToString());
                File.Create(filePath).Close();
                string jsonser = JsonSerializer.Serialize(lessons);
                File.WriteAllText(filePath, jsonser);
            }

            return lessons;
        }
    }
}
