using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;

namespace Figures
{

    abstract class Figure :IGrafical2D
    {
        /// <summary>
        /// символ прорисовки по-умолчанию
        /// </summary>
        public const char DEFSYM = '*';
        /// <summary>
        /// конструктор точки отрисовки фигуры
        /// </summary>
        /// <param name="startX">стартовая координата Х</param>
        /// <param name="startY">стартовая координата У</param>
        public Figure(int startX, int startY, char sym = DEFSYM)
        {
            pList = new List<Point>();
            pList.Add(new Point(startX, startY, sym));
        }
        /// <summary>
        /// Получение копии фигуры
        /// </summary>
        /// <returns></returns>
        public Figure GetCopy()
        {
            Figure f = (Figure)MemberwiseClone();
            return f;
        }
        /// <summary>
        /// Перемещение фигуры
        /// </summary>
        /// <param name="direct">направление перемещения</param>
        public void Move(Enums.MovingDirection direct)
        {
            foreach (Point p in pList)
            {
                p.ErasePoint();
            }
            foreach (Point p in pList)
            {
                p.Move(direct);
            }
        }

        /// <summary>
        /// Прорисовка фигуры
        /// </summary>
        public void Draw()
        {
            foreach (Point p in Plist)
            {
                p.Draw();
            }
        }
        /// <summary>
        /// Абстрактный метод вычисления площади
        /// </summary>
        /// <returns></returns>
        public abstract double Area();
        /// <summary>
        /// Абстрактный метод вычисления периметра
        /// </summary>
        /// <returns></returns>
        public abstract double Perimeter();
        /// <summary>
        /// свойства для чтения списка
        /// </summary>
        public List<Point> Plist
        {
            get
            {
                return pList;
            }
        }
        /// <summary>
        /// список точек
        /// </summary>
        protected List<Point> pList;

        

    }
}
