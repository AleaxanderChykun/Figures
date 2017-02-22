using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figures
{
    class Elipse : Figure
    {
        /// <summary>
        /// Конструктор эллипса
        /// </summary>
        /// <param name="p0X">координата Х центра</param>
        /// <param name="p0Y">координата У центра</param>
        /// <param name="radiusSmal">длина малого радиуса</param>
        /// <param name="radiusLarge">длина большего радиуса</param>
        /// <param name="sym">Символ прорисовки фигуры</param>
        public Elipse(int p0X, int p0Y, int radiusSmal, int radiusLarge, char sym = DEFSYM):base(p0X, p0Y)
        {
            _rSmal = radiusSmal;
            _rLarge = radiusLarge;
            pList.Add(new Point(p0X + _rLarge, p0Y, sym));
            pList.Add(new Point(p0X - _rLarge, p0Y, sym));
            pList.Add(new Point(p0X, p0Y + _rSmal, sym));
            pList.Add(new Point(p0X, p0Y - _rSmal, sym));
        }
        /// <summary>
        /// Переопределенный метод вычисления площади
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            return Math.Round(Math.PI, 3) * RSmal * RLarge;
        }
        /// <summary>
        /// Переопределенный метод вычисления периметра
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return Math.Round(Math.PI,3) * (RSmal + RLarge);
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
        /// Свойство для чтения для малого радиуса
        /// </summary>
        public int RSmal
        {
            get
            {
                return _rSmal;
            }
        }
        /// <summary>
        /// Свойство для чтения для большего радиуса
        /// </summary>
        public int RLarge
        {
            get
            {
                return _rLarge;
            }
        }
        private int _rSmal;
        private int _rLarge;
    }
}
