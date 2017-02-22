using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figures
{
    abstract class Poligon : Figure
    {
        /// <summary>
        /// конструктор многоугольника
        /// </summary>
        /// <param name="startX">Координата Х левого верхнего угла</param>
        /// <param name="startY">Координата У левого верхнего угла</param>
        /// <param name="LengthOfSide">Длина стороны</param>
        /// <param name="NumOfSides">Количество сторон</param>
        public Poligon(int startX, int startY, int LengthOfSide, int NumOfSides ):base (startX, startY)
        {
            _numOfSides = NumOfSides;
            _lengthOfSide = LengthOfSide;
        }
        /// <summary>
        /// Деструктор
        /// </summary>
        ~Poligon()
        {
        }
        /// <summary>
        /// Переопределенный метод вычисления периметра
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return NumOfSides * LengthOfSide;
        }
        /// <summary>
        /// Строковое представление площади и периметра эллипса
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Perimeter: {0}\nArea: {1}", Perimeter(), Area());
        }
        /// <summary>
        /// Свойство для чтения количества сторон
        /// </summary>
        public int NumOfSides
        {
            get
            {
                return _numOfSides;
            }
        }
        /// <summary>
        /// Свойство для чтения длины сторон
        /// </summary>
        public int LengthOfSide
        {
            get
            {
                return _lengthOfSide;
            }
        }
        private int _numOfSides;
        private int _lengthOfSide;
    }
}
