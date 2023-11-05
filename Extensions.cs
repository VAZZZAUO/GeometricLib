using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyExceptions.MyExceptions;

namespace GeometricLib
{
   public  static class Extensions
    {

        /// <summary>
        /// Метод который выбрасывает пользовательскую ошибку ShapeEdgeIsNegativeException, если значение меньше 0.
        /// Используется для геттеров/сеттеров геометрических фигур.
        /// </summary>
        /// <param name="value">Входящее double значение </param>
        /// <returns>value or ShapeEdgeIsNegativeException</returns>
        /// <exception cref="ShapeEdgeIsNegativeException"></exception>
        public static double NotNegative(this double value)
        {
            
            if (value >= 0)
            {
                return value;

            }
            else
            {
                throw new ShapeEdgeIsNegativeException("Edge is Negative", DateTime.Now);
            }
        }

    }
}
