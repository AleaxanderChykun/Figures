using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;

namespace Figures
{
    class CircleInSquare:Rectangle
    {
        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="startX">координата Х верхней левой вершины</param>
        /// <param name="startY">координата У верхней левой вершины</param>
        /// <param name="length">длина стороны</param>
        /// <param name="SymSquare">символ прорисовки квадрата</param>
        /// <param name="SymCircle">символ прорисовки окружности</param>
        public CircleInSquare(int startX, int startY, int length, char SymSquare = DEFSYM,char SymCircle = DEFSYM)
            : base(startX, startY, length, length, SymSquare)
        {
            _radius = length / 2;
            int p0X = startX + length / 2;
            int p0Y = startY + length / 2;
            int startPY = p0Y;
            for (int i = 1; i <= _radius; i++) //прорисовка окружности
            {
                Point p = new Point(p0X + (int)Math.Sqrt((double)(_radius * _radius - i * i)), p0Y, SymCircle);
                pList.Add(p);
                p = new Point(p0X - (int)Math.Sqrt((double)(_radius * _radius - i * i)), p0Y, SymCircle);
                pList.Add(p);
                p0Y++;
            }
            p0Y = startPY;
            for (int j = 1; j <= _radius; j++)
            {
                Point p = new Point(p0X + (int)Math.Sqrt((double)(_radius * _radius - j * j)), p0Y, SymCircle);
                pList.Add(p);
                p = new Point(p0X - (int)Math.Sqrt((double)(_radius * _radius - j * j)), p0Y, SymCircle);
                pList.Add(p);
                p0Y--;
            }
        }
        /// <summary>
        /// вычисление периметра окружности
        /// </summary>
        /// <returns></returns>
        public double PerimeterOfCircle()
        {
            return 2 * Math.Round(Math.PI, 3) * _radius;
        }
        /// <summary>
        /// вычисление площади окружности
        /// </summary>
        /// <returns></returns>
        public double AreaOfCircle()
        {
            return Math.Round(Math.PI, 3) * _radius * _radius;
        }
        /// <summary>
        /// Строковое представление площадей и периметров фигур
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Perimeter of square: {0}  Area of square: {1}\nPerimeter of circle: {2}  Area of circle: {3}\n", 
                Perimeter(), Area(),PerimeterOfCircle(),AreaOfCircle());
        }
        /// <summary>
        /// радиус
        /// </summary>
        private int _radius;
        
    }
}
