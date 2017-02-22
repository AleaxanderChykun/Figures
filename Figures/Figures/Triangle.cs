using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;

namespace Figures
{
    class Triangle : Poligon
    {
        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="startX">координата Х вершины </param>
        /// <param name="startY">координата У вершины</param>
        /// <param name="length">высота треугольника</param>
        /// <param name="sym">символ прорисовки</param>
        /// <param name="NumOfSides">количество сторон</param>
        public Triangle(int startX, int startY, int length, char sym = DEFSYM, int NumOfSides = 3)
            : base(startX, startY,length, NumOfSides)
        {
            _heigth = Math.Sqrt(length * length - (length / 2) * (length / 2));
            _baseOfTriang = length;

                for (int i = 0; i < _heigth; i++)
                {
                    Point p = new Point(startX++, startY++, sym);
                    pList.Add(p);
                }
                for (int j = 0; j < _heigth; j++)
                {
                    Point p = new Point(startX, startY, sym);
                    startX -= 2;
                    pList.Add(p);
                }
                for (int k = 0; k < _heigth; k++)
                {
                    Point p = new Point(startX++, startY--, sym);
                    pList.Add(p);
                }
        }
        /// <summary>
        /// переопределенный метод вычисления площади
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            return Math.Round((Heigth*Base/2.0),3);
        }
        /// <summary>
        /// свойства высоты треугольника
        /// </summary>
        public double Heigth
        {
            get
            {
                return _heigth;
            }
        }
        /// <summary>
        /// свойства основания треугольника
        /// </summary>
        public int Base
        {
            get
            {
                return _baseOfTriang;
            }
        }
        /// <summary>
        /// высота
        /// </summary>
        private double _heigth;
        /// <summary>
        /// основание 
        /// </summary>
        private int _baseOfTriang;
    }
}
