using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;

namespace Figures
{
    class Line:Figure
    {
        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="startX">стартовая координата Х</param>
        /// <param name="startY">стартовая координата У</param>
        /// <param name="dir">направление прорисовки линии</param>
        /// <param name="Length">длина линии</param>
        /// <param name="sym">символ прорисовки</param>
        public Line(int startX, int startY, int Length, char sym = DEFSYM)
            : base(startX, startY)
        {
            for (int i = 0; i <= Length; i++)
            {
                Point p = new Point(startX++, startY, sym);
                pList.Add(p);
            }
        }
        /// <summary>
        /// Строковое представление длины линии
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Length: {0}", Perimeter());
        }
        /// <summary>
        /// Переопределенный метод вычисления площади
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            return 0.0;
        }
        /// <summary>
        /// Переопределенный метод вычисления периметра
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return pList.Count-2;
        }

    }
}
