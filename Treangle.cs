using static MyExceptions.MyExceptions;

namespace GeometricLib
{
    public class Treangle:IShape
    {
        private double _firstEdge;
        private double _secondEdge;
        private double _thirdEdge;
        /// <summary>
        /// Конструктор треугольника.
        /// Возможные пользовательские ошибки:NotTreangleExecption если сумма двух сторон трегуольника меньше длины третьей стороны, 
        /// ShapeEdgeIsNegativeException, если сторона меньше 0.
        /// </summary>
        /// <param name="_firstEdge"></param>
        /// <param name="_secondEdge"></param>
        /// <param name="_thirdEdge"></param>
        /// <exception cref="NotTreangleExecption"></exception>
        public Treangle(double _firstEdge, double _secondEdge, double _thirdEdge)
        {
            FirstEdge = _firstEdge;
            SecondEdge = _secondEdge;
            ThirdEdge = _thirdEdge;

            if(FirstEdge+SecondEdge<=ThirdEdge||SecondEdge+ThirdEdge<=FirstEdge||FirstEdge+ThirdEdge<=SecondEdge)
            { 
                throw new NotTreangleExecption("This is not Treangle because a+b<c",DateTime.Now);
            }
        }

        public double FirstEdge
        {
            get
            {
               return _firstEdge;
            }
            set
            {
                _firstEdge=value.NotNegative();
            }
        }
        
        public double SecondEdge
        {
            get
            {
                return _secondEdge;
            }
            set
            {
                _secondEdge = value.NotNegative();
            }
        }

        public double ThirdEdge
        {
            get
            {
                return _thirdEdge;
            }
            set
            {
                _thirdEdge = value.NotNegative();
            }
        }


        public double Area()
        {
            double a = FirstEdge, b = SecondEdge, c = ThirdEdge;
            double semPerimetr = (a + b + c) * 0.5;
            double area = Math.Sqrt(semPerimetr * (semPerimetr - a) * (semPerimetr - b) * (semPerimetr - c));
            return area;
        }
        public bool IsRightTriangle() 
        {
            double sqrt_a = Math.Pow(FirstEdge,2), sqrt_b = Math.Pow(SecondEdge,2), sqrt_c = Math.Pow(ThirdEdge,2);
            if(sqrt_a + sqrt_b==sqrt_c||sqrt_b+sqrt_c==sqrt_a||sqrt_a+sqrt_c==sqrt_b) 
            {
               return true;
            }
            else 
            {
                return false; 
            }
           
        }

    }

}