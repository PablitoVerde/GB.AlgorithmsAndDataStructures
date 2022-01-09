using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;
using System.Reflection;

namespace GB.AlgorithmsAndDataStructures.Lesson3
{
    public class Task1 : ILesson, IBenchmark
    {
        public string Name => "Task3.1";

        public string Description => "Подсчет расстояния между точками";

        public void Demo()
        {
            Console.WriteLine("Points  Class               Structure              Ratio");

            // Вывод тестовых данных в консоль. Подсчет ведется 3 - 1000 точек, 5000 и 25000. Был сделан выбор в пользу краткости записи.
            int n = 1000;
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine($"{n} | {StopWatchClassPoint(MakeMass(n).Item1).Elapsed} | {StopWatchStructPoint(MakeMass(n).Item2).Elapsed} | {StopWatchClassPoint(MakeMass(n).Item1).Elapsed / StopWatchStructPoint(MakeMass(n).Item2).Elapsed}");
                n = n * 5;
            }

            MakeBenchMarkTests();

            Console.ReadKey();
        }

        //создание пары псевдослучайных чисел
        (double, double) GetRandomCoordinates()
        {

            Random rnd = new Random(DateTime.Now.Millisecond);
            return (rnd.NextDouble(), rnd.NextDouble());
        }

        /// <summary>
        /// Метод по созданию двух массивов: объектов класса и элементов из структуры
        /// </summary>
        /// <param Длина массива="numberPoints"></param>
        /// <returns></returns>
        (PointClassDouble[], StructurePointDouble.point[]) MakeMass(int numberPoints)
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

            return (pointsClassMass, pointsStructMass);
        }

        /// <summary>
        /// Метод "упаковка" для подсчета скорости вычислений с помощью таймера. Для объектов класса.
        /// </summary>
        /// <param Массив="pointsClassMass"></param>
        /// <returns></returns>
        Stopwatch StopWatchClassPoint(PointClassDouble[] pointsClassMass)
        {
            //таймер для подсчета расстояния между точками в рамках класса

            Stopwatch swClass = new Stopwatch();

            swClass.Start();

            MakeTestsClassPoint(pointsClassMass);

            swClass.Stop();

            return swClass;
        }

        /// <summary>
        /// Метод "упаковка" для подсчета скорости вычислений с помощью таймера. Для элементов из структуры.
        /// </summary>
        /// <param Массив="pointsStructMass"></param>
        /// <returns></returns>
        Stopwatch StopWatchStructPoint(StructurePointDouble.point[] pointsStructMass)
        {
            Stopwatch swClass = new Stopwatch();

            swClass.Start();

            MakeTestsStructurePoint(pointsStructMass);

            swClass.Stop();

            return swClass;
        }

        /// <summary>
        /// Подсчет расстояния между точками на примере объектов класса
        /// </summary>
        /// <param Массив объектов класса="pointsClassMass"></param>
        void MakeTestsClassPoint(PointClassDouble[] pointsClassMass)
        {
            for (int i = 0; i < (pointsClassMass.Length - 1); i++)
            {
                for (int j = 1; j < pointsClassMass.Length; j++)
                {
                    double d = PointClassDouble.PointClassDistance(pointsClassMass[i], pointsClassMass[j]);
                }
            }
        }

        /// <summary>
        /// Подсчет расстояния между точками на примере объектов структуры
        /// </summary>
        /// <param Массив элементов структуры="pointsStructMass"></param>
        public void MakeTestsStructurePoint(StructurePointDouble.point[] pointsStructMass)
        {
            for (int i = 0; i < (pointsStructMass.Length - 1); i++)
            {
                for (int j = 1; j < pointsStructMass.Length; j++)
                {
                    double d = StructurePointDouble.PointStructDistance(pointsStructMass[i], pointsStructMass[j]);
                }
            }
        }

        //Реализация интерфейса для тестов
        public void MakeBenchMarkTests()
        {
            BenchmarkSwitcher.FromAssembly(Assembly.GetExecutingAssembly()).Run();
            MakeBenchMarkTestClass();
            MakeBenchMarkTestStruct();
        }

        //Метод упаковка для анализа скорости подсчета для класса
        [Benchmark]
        public void MakeBenchMarkTestClass()
        {
            MakeTestsClassPoint(MakeMass(1000).Item1);
        }

        //Метод упаковка для анализа скорости подсчета для структуры
        [Benchmark]
        public void MakeBenchMarkTestStruct()
        {
            MakeTestsStructurePoint(MakeMass(1000).Item2);
        }
    }
}
