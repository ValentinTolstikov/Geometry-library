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
        /// <summary>
        /// Функция, позволяющая вычислить площадь треугольника по сторонам.
        /// </summary>
        /// <param name="SideA"></param>
        /// <param name="SideB"></param>
        /// <param name="SideC"></param>
        /// <returns></returns>
        public static double GetArea(double SideA, double SideB, double SideC)
        {
            if (IsExist(SideA, SideB, SideC))
            {
                
            }

            double Per = GetPerimeter(SideA, SideB, SideC);
            if (double.IsNaN(Per))
            {
                return double.NaN;
            }
            double HalfPer = Per / 2;

            return Math.Sqrt(HalfPer*((HalfPer-SideA)*(HalfPer-SideB)*(HalfPer-SideC)));
        }

        public static double GetPerimeter(double SideA, double SideB, double SideC)
        {
            if (SideA <= 0 || SideB <= 0 || SideC <= 0)
            {
                return double.NaN;
            }

            return (SideA+SideB+SideC)/2;
        }

        public static bool IsExist(double SideA, double SideB, double SideC)
        {
            return (SideA + SideB > SideC) && (SideA + SideC > SideB) && (SideB + SideC > SideA);
        }
    }
}
