using System;
using System.Collections.Generic;
using System.Text;

namespace GB.AlgorithmsAndDataStructures.Lesson3
{
    public class StructurePointDouble
    {
        public struct point
        {
            public double x;
            public double y;
        }





        /// <summary>
        /// Метод по подсчету расстояния между точками. Точка - структура.
        /// </summary>
        /// <param Первая точка="point1"></param>
        /// <param Вторая точка="point2"></param>
        /// <returns></returns>
        static public double PointStructDistance(point point1, point point2)
        {
            double result = 0;

            //Формула подсчета расстояния между точками - квадратный корень из суммы квадратов разницы координат.
            result = Math.Sqrt(Math.Pow((point1.x - point2.x), 2) + Math.Pow((point1.y - point2.y), 2));

            return result;
        }
    }
}
