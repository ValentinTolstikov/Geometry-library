using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib
{
    public class Circle
    {
        /// <summary>
        /// Функция, позволяющая вычислить площадь круга.
        /// </summary>
        /// <param name="Radius">Радиус круга</param>
        /// <returns>Возвращает площадь, если введенный радиус </returns>
        public static double GetArea(double Radius)
        {
            if (Radius <= 0)
            {
                return double.NaN;
            }
            
            return Math.PI * (Math.Pow(Radius,2));
        }
    }

    public class Triangle
    {
        public static void Get
    }
}
