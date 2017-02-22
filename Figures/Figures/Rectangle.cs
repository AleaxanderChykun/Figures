using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;

namespace Figures
{
    class Rectangle : Poligon
    {
        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="startX">координата Х верхней левой вершины </param>
        /// <param name="startY">координата У верхней левой вершины</param>
        /// <param name="length">Длина</param>
        /// <param name="width">Ширина</param>
        /// <param name="sym">Символ прорисовки</param>
        /// <param name="NumOfSides">количество сторон</param>
        public Rectangle(int startX, int startY, int length ,int width, char sym = DEFSYM, int numOfSides = 4)
            : base(startX, startY, length, numOfSides)
        {
            _width = width;
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(startX++, startY, sym);
                pList.Add(p);
            }
            for (int i = 0; i < width; i++)
            {
                Point p = new Point(startX, startY++, sym);
                pList.Add(p);
            }
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(startX--, startY, sym);
                pList.Add(p);
            }
            for (int i = 0; i < width; i++)
            {
                Point p = new Point(startX, startY--, sym);
                pList.Add(p);
            }
        }
        /// <summary>
        /// Переопределенный метод вычисления периметра
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return NumOfSides / 2 * LengthOfSide + NumOfSides / 2 * Width;
        }
        /// <summary>
        /// переопределенный метод вычисления площади
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            return LengthOfSide * Width;
        }
        /// <summary>
        /// свойства ширины
        /// </summary>
        public int Width
        {
            get
            {
                return _width;
            }
        }
        /// <summary>
        /// ширина
        /// </summary>
        private int _width;
    }
}
