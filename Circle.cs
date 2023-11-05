using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricLib
{
    public class Circle:IShape
    {
        private double _radius;

        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value.NotNegative();
            }

        }
        /// <summary>
        /// Конструктор Круга.
        /// Возможные пользовательские  ошибки: ShapeEdgeIsNegativeException. Если радиус меньше 0.
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius) 
        { 
        Radius = radius;
        }
        /// <summary>
        /// Метод вычисления площади
        /// </summary>
        /// <returns>double Area</returns>
        public double Area()
        {
            return Math.PI * Math.Pow(Radius,2);
        }
    }
}
