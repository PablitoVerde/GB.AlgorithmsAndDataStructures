using System;
using System.Collections.Generic;
using System.Text;

namespace GB.AlgorithmsAndDataStructures.Lesson3
{
    class PointClassDouble
    {
        double Х { get; set; }
        double Y { get; set; }

        public PointClassDouble(double x, double y)
        {
            this.Х = x;
            this.Y = y;
        }

        /// <summary>
        /// Метод подсчета расстояния между двумя точками
        /// </summary>
        /// <param Первая точка="point1"></param>
        /// <param Вторая точка="point2"></param>
        /// <returns></returns>
        static public double PointClassDistance(PointClassDouble point1, PointClassDouble point2)
        {
            double result = 0;

            //Формула подсчета расстояния между точками - квадратный корень из суммы квадратов разницы координат.
            result = Math.Sqrt(Math.Pow((point1.Х - point2.Х), 2) + Math.Pow((point1.Y - point2.Y), 2));

            return result;
        }

    }
}
