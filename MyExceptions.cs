using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExceptions
{
    public class MyExceptions
    {
        public class ShapeEdgeIsNegativeException : ApplicationException
        {
            public DateTime ErrorTimeStamp { get; set; }
            public ShapeEdgeIsNegativeException() { }
            // Передача сообщения конструктору родительского класса,
            public ShapeEdgeIsNegativeException(string message, DateTime time)
            : base(message)
            {
                ErrorTimeStamp = time;
            }
        }
        public class NotTreangleExecption:ApplicationException
        {
            public DateTime ErrorTimeStamp { get; set; }
            public NotTreangleExecption() { }
            // Передача сообщения конструктору родительского класса,
            public NotTreangleExecption(string message, DateTime time)
            : base(message)
            {
                ErrorTimeStamp = time;
            }
        }
    }
}
