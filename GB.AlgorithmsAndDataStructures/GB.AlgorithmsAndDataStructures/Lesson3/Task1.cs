using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace GB.AlgorithmsAndDataStructures.Lesson3
{
    class Task1 : ILesson
    {
        string ILesson.Name => "Task3.1";

        string ILesson.Description => "Подсчет расстояния между точками";

        void ILesson.Demo()
        {
            Console.WriteLine("Points  Class               Structure              Ratio");

            MakeTests(1000);
            MakeTests(5000);
            MakeTests(9000);

            Console.ReadKey();
        }


        //создание пары псевдослучайных чисел
        (double, double) GetRandomCoordinates()
        {
            
            Random rnd = new Random(DateTime.Now.Millisecond);
            return (rnd.NextDouble(), rnd.NextDouble());
        }

        //Метод по проведению тестов
        void MakeTests(int numberPoints)
        {
            PointClassDouble[] pointsClassMass = new PointClassDouble[numberPoints];
            StructurePointDouble.point[] pointsStructMass = new StructurePointDouble.point[numberPoints];


            //Для равноценности подсчета расстояний массивы объектов класса и структур будут иметь одинаковые координаты точек
            for (int i = 0; i < numberPoints; i++)
            {
                double xCoordinate = GetRandomCoordinates().Item1;
                double yCoordinate = GetRandomCoordinates().Item2;

                PointClassDouble pointClass = new PointClassDouble(xCoordinate, yCoordinate);
                pointsClassMass[i] = pointClass;

                StructurePointDouble.point pointStruct;
                pointStruct.x = xCoordinate;
                pointStruct.y = yCoordinate;
                pointsStructMass[i] = pointStruct;
            }

            //таймер для подсчета расстояния между точками в рамках класса
            Stopwatch swClass = new Stopwatch();

            swClass.Start();

            for (int i = 0; i < (pointsClassMass.Length - 1); i++)
            {
                for (int j = 1; j < pointsClassMass.Length; j++)
                {
                    double d = PointClassDouble.PointClassDistance(pointsClassMass[i], pointsClassMass[j]);
                }
            }

            swClass.Stop();


            //таймер по подсчетам по структурам
            Stopwatch swStruct = new Stopwatch();

            swStruct.Start();

            for (int i = 0; i < (pointsStructMass.Length - 1); i++)
            {
                for (int j = 1; j < pointsStructMass.Length; j++)
                {
                    double d = StructurePointDouble.PointStructDistance(pointsStructMass[i], pointsStructMass[j]);
                }
            }

            //вывод на консоль в виде строки
            Console.WriteLine($"{numberPoints}   | {swClass.Elapsed} | {swStruct.Elapsed} | {swClass.Elapsed / swStruct.Elapsed}");
        }
    }
}
