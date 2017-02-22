using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;

namespace Figures
{
    class Square:Rectangle
    {
       /// <summary>
       /// конструктор
       /// </summary>
        /// <param name="startX">координата Х верхней левой вершины </param>
        /// <param name="startY">координата У верхней левой вершины </param>
       /// <param name="length">Длина стороны</param>
       /// <param name="Sym">Символ прорисовки</param>
        public Square(int startX,int startY, int length, char Sym = DEFSYM)
            :base(startX,startY,length,length,Sym)
        {
        }
    }
}
