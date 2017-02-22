using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;

namespace Figures
{
    class Circle : Elipse
    {
        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="p0X">координата центра окружности Х</param>
        /// <param name="p0Y">координата центра окружности У</param>
        /// <param name="radius">радиус окружности</param>
        /// <param name="sym">символ прорисовки</param>
        public Circle(int p0X, int p0Y, int radius, char sym = DEFSYM)
            : base(p0X, p0Y,radius,radius,sym)
        {
            int startPY = p0Y;
            for (int i = 0; i <= radius; i++)
            {
                Point p = new Point(p0X + (int)Math.Round(Math.Sqrt((double)(radius * radius - i * i))), p0Y, sym);
                pList.Add(p);
                p = new Point(p0X - (int)Math.Round(Math.Sqrt((double)(radius * radius - i * i))), p0Y, sym);
                pList.Add(p);
                p0Y++;
            }
            p0Y = startPY;
            for (int j = 0; j <= radius; j++)
            {
                Point p = new Point(p0X + (int)Math.Round(Math.Sqrt((double)(radius * radius - j * j))), p0Y, sym);
                pList.Add(p);
                p = new Point(p0X - (int)Math.Round(Math.Sqrt((double)(radius * radius - j * j))), p0Y, sym);
                pList.Add(p);
                p0Y--;
            }
        }
    }
}
