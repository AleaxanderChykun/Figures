using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;

namespace Figures
{
    class Point
    {
        /// конструктор с параметрами
        /// </summary>
        /// <param name="X">координата X</param>
        /// <param name="Y">координата Y</param>
        /// <param name="symbol">символ точки</param>
        public Point(int X, int Y,char symbol = '*')
        {
           if (!IsWrong(X) & !IsWrong(Y))
           {
               _x = X;
               _y = Y;
               _symbol = symbol;
           }
        }
        /// <summary>
        /// Деструктор
        /// </summary>
        ~Point()
        {
        }
        /// <summary>
        /// копия точки
        /// </summary>
        /// <returns></returns>
        public Point GetCopy()
        {
            Point p = (Point)MemberwiseClone();
            return p;
        }
        /// <summary>
        /// Проверка на неотрицательное число
        /// </summary>
        /// <param name="num">число</param>
        /// <returns></returns>
        public static bool IsWrong(int num)
        {
            if (num < 0)
            {
                Logger.Log.ShowMessage("Error!!! Wrong X or Y");
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Смещение координат
        /// </summary>
        /// <param name="dir">направление смещения</param>
        public void Move(Enums.MovingDirection dir)
        {
            switch (dir)
            {
                case Enums.MovingDirection.Up:
                    {
                        _y -= 1;
                        break;
                    }
                case Enums.MovingDirection.Down:
                    {
                        _y += 1;
                        break;
                    }
                case Enums.MovingDirection.Right:
                    {
                        _x += 1;
                        break;
                    }
                case Enums.MovingDirection.Left:
                    {
                        _x -= 1;
                        break;
                    }
                default:
                    break;
            }
        }
        /// <summary>
        /// Прорисовки точки
        /// </summary>
        public void Draw(bool erased = false)
        {
            Console.SetCursorPosition(X, Y);
            if (erased)
            {
                Console.WriteLine(' ');
            }
            else
            {
                Console.WriteLine((char)Symbol);
            }
        }
        /// <summary>
        /// Затирание точки
        /// </summary>
        public void ErasePoint()
        {
            Draw(true);
        }
        /// <summary>
        /// Properties of posX
        /// </summary>
        public int X
        {
            get
            {
                return _x;
            }
        }
        /// <summary>
        /// Properties of posY
        /// </summary>
        public int Y
        {
            get
            {
                return _y;
            }
        }
        /// <summary>
        /// Properties of symbol
        /// </summary>
        public char Symbol
        {
            get
            {
                return _symbol;
            }
        }
        /// <summary>
        /// координата Х
        /// </summary>
        private int _x;
        /// <summary>
        /// координата У
        /// </summary>
        private int _y;
        /// <summary>
        /// символ
        /// </summary>
        private char _symbol;
    }
}
