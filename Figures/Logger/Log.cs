using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class Log
    {
        /// <summary>
        /// Сообщение
        /// </summary>
        /// <param name="message"></param>
        public static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        /// <summary>
        /// Сообщение в указанной точке
        /// </summary>
        /// <param name="posX">position X</param>
        /// <param name="posY">position Y</param>
        /// <param name="text">text</param>
        public static void ShowTextInPos(int posX, int posY,string text)
        {
            Console.SetCursorPosition(posX, posY);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 80; j++)
                {
                    Console.SetCursorPosition(posX + j, posY + i);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(posX, posY);
            Console.WriteLine(text);
        }
        /// <summary>
        /// меню выбора фигур
        /// </summary>
        public static void MenuOfFigures(int posX, int posY)
        {
            ShowTextInPos(posX, posY, "Выберите фигуру:");
            ShowTextInPos(posX, posY + 1, "1 - Line");
            ShowTextInPos(posX, posY + 2, "2 - Elipse");
            ShowTextInPos(posX, posY + 3, "3 - Circle");
            ShowTextInPos(posX, posY + 4, "4 - Triangle");
            ShowTextInPos(posX, posY + 5, "5 - Rectangle");
            ShowTextInPos(posX, posY + 6, "6 - Square");
            ShowTextInPos(posX, posY + 7, "7 - Circle in square");
            ShowTextInPos(posX, posY + 8, "8 - Show All Figures");
        }
        /// <summary>
        /// Установка цвета
        /// </summary>
        /// <param name="c"></param>
        public static void SetForegroundColor(ConsoleColor c)
        {
            Console.ForegroundColor = c;
        }
        /// <summary>
        /// Установка цвета по-умолчанию
        /// </summary>
        public static void SetDefColor()
        {
            Console.ForegroundColor = ConsoleColor.White; ;
        }
    }
}
