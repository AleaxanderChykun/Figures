using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Logger;

namespace Figures
{
    class UserInterface
    {
        /// <summary>
        /// Выбор фигуры
        /// </summary>
        /// <returns></returns>
        public static Enums.Figures GetFigure()
        {
            Enums.Figures f = Enums.Figures.Empty;
            ConsoleKeyInfo InfoKey;
            bool action = true;
            while (action)
            {
                if (Console.KeyAvailable)
                {
                    InfoKey = Console.ReadKey();
                    switch (InfoKey.Key)
                    {
                        case ConsoleKey.D1:
                            {
                                f = Enums.Figures.Line;
                                action = false;
                                break;
                            }
                        case ConsoleKey.D2:
                            {
                                f = Enums.Figures.Elipse;
                                action = false;
                                break;
                            }
                        case ConsoleKey.D3:
                            {
                                f = Enums.Figures.Circle;
                                action = false;
                                break;
                            }
                        case ConsoleKey.D4:
                            {
                                f = Enums.Figures.Triangle;
                                action = false;
                                break;
                            }
                        case ConsoleKey.D5:
                            {
                                f = Enums.Figures.Rectangle;
                                action = false;
                                break;
                            }
                        case ConsoleKey.D6:
                            {
                                f = Enums.Figures.Square;
                                action = false;
                                break;
                            }
                        case ConsoleKey.D7:
                            {
                                f = Enums.Figures.CircleInSquare;
                                action = false;
                                break;
                            }
                        case ConsoleKey.D8:
                            {
                                f = Enums.Figures.ShowAll;
                                action = false;
                                break;
                            }
                        case ConsoleKey.Escape:
                            {
                                f = Enums.Figures.Empty;
                                action = false;
                                break;
                            }
                        default:
                            break;
                    }
                }
                Thread.Sleep(300);
            }
            return f;
        }

        /// <summary>
        /// Выбор направления передвижения
        /// </summary>
        /// <param name="IsMoving">будет ли осуществляться передвижение</param>
        /// <returns></returns>
        public static Enums.MovingDirection GetMovingDirection(ref bool IsMoving)
        {
            Enums.MovingDirection direct = Enums.MovingDirection.Empty;
            ConsoleKeyInfo InfoKey;
            bool action = true;
            while (action)
            {
                if (Console.KeyAvailable)
                {
                    InfoKey = Console.ReadKey();
                    switch (InfoKey.Key)
                    {
                        case ConsoleKey.Escape:
                            {
                                IsMoving = false;
                                action = false;
                                break;
                            }
                        case ConsoleKey.UpArrow:
                            {
                                direct = Enums.MovingDirection.Up;
                                action = false;
                                break;
                            }
                        case ConsoleKey.DownArrow:
                            {
                                direct = Enums.MovingDirection.Down;
                                action = false;
                                break;
                            }
                        case ConsoleKey.RightArrow:
                            {
                                direct = Enums.MovingDirection.Right;
                                action = false;
                                break;
                            }
                        case ConsoleKey.LeftArrow:
                            {
                                direct = Enums.MovingDirection.Left;
                                action = false;
                                break;
                            }
                        default:
                            break;
                    }
                }
            }
            return direct;
        }
        /// <summary>
        /// Ввод линии
        /// </summary>
        /// <param name="x">стартовая координата Х</param>
        /// <param name="y">стартовая координата У</param>
        /// <param name="sym">Символ прорисовки линии</param>
        /// <param name="length">Длина линии</param>
        /// <param name="dir">Направление прорисовки</param>
        public static void EnteringLine(ref int x, ref int y, ref char sym, ref int length)
        {
            Console.Clear();
            Log.ShowMessage("startX: ");
            x = int.Parse(Console.ReadLine());
            Log.ShowMessage("startY: ");
            y = int.Parse(Console.ReadLine());
            Log.ShowMessage("Длина:");
            length = int.Parse(Console.ReadLine());
            Log.ShowMessage("Каким символом рисовать?: ");
            sym = char.Parse(Console.ReadLine());
        }
        /// <summary>
        /// Ввод окружности
        /// </summary>
        /// <param name="x">координата центра Х</param>
        /// <param name="y">координата центра У</param>
        /// <param name="sym">символ прорисовки</param>
        /// <param name="length">радиус</param>
        public static void EnteringCircle(ref int x, ref int y, ref char sym, ref int length)
        {
            Console.Clear();
            Log.ShowMessage("Координата X центра окружности: ");
            x = int.Parse(Console.ReadLine());
            Log.ShowMessage("Координата Y центра окружности: ");
            y = int.Parse(Console.ReadLine());
            Log.ShowMessage("Введите радиус: ");
            length = int.Parse(Console.ReadLine());
            Log.ShowMessage("Каким символом рисовать?: ");
            sym = char.Parse(Console.ReadLine());
        }
        /// <summary>
        /// Ввод треугольника
        /// </summary>
        /// <param name="x">Координата верхней точки Х</param>
        /// <param name="y">Координата верхней точки У</param>
        /// <param name="sym">Символ прорисовки</param>
        /// <param name="length">Высота треугольника</param>
        public static void EnteringTriangle(ref int x, ref int y, ref char sym, ref int length)
        {
            Console.Clear();
            Log.ShowMessage("Координата X вершины: ");
            x = int.Parse(Console.ReadLine());
            Log.ShowMessage("Координата Y вершины: ");
            y = int.Parse(Console.ReadLine());
            Log.ShowMessage("Длина стороны: ");
            length = int.Parse(Console.ReadLine());
            Log.ShowMessage("Каким символом рисовать?: ");
            sym = char.Parse(Console.ReadLine());
        }
        /// <summary>
        /// Ввод прямоугольника
        /// </summary>
        /// <param name="x">Координата верхнего левого угла Х</param>
        /// <param name="y">Координата верхнего левого угла У</param>
        /// <param name="length">Длина прямоугольника</param>
        /// <param name="width">Ширина прямоугольника</param>
        /// <param name="sym">Символ прорисовки</param>
        public static void EnteringRectangle(ref int x, ref int y,  ref int length, ref int width, ref char sym)
        {
            Console.Clear();
            Log.ShowMessage("Координата Х левого верхнего угла: ");
            x = int.Parse(Console.ReadLine());
            Log.ShowMessage("Координата Y левого верхнего угла: ");
            y = int.Parse(Console.ReadLine());
            Log.ShowMessage("Длина прямоугольника: ");
            length = int.Parse(Console.ReadLine());
            Log.ShowMessage("Ширина прямоугольника: ");
            width = int.Parse(Console.ReadLine());
            Log.ShowMessage("Каким символом рисовать?: ");
            sym = char.Parse(Console.ReadLine());
        }
        /// <summary>
        /// Ввод квадрата
        /// </summary>
        /// <param name="x">Координата верхнего левого угла Х</param>
        /// <param name="y">Координата верхнего левого угла У</param>
        /// <param name="length">Длина стороны</param>
        /// <param name="sym">Символ прорисовки</param>
        public static void EnteringSquare(ref int x, ref int y, ref int length, ref char sym)
        {
            Console.Clear();
            Log.ShowMessage("Координата Х левого верхнего угла: ");
            x = int.Parse(Console.ReadLine());
            Log.ShowMessage("Координата Y левого верхнего угла: ");
            y = int.Parse(Console.ReadLine());
            Log.ShowMessage("Длина стороны квадрата: ");
            length = int.Parse(Console.ReadLine());
            Log.ShowMessage("Каким символом рисовать?: ");
            sym = char.Parse(Console.ReadLine());
        }
        /// <summary>
        /// Ввод эллипса
        /// </summary>
        /// <param name="x">координата центра Х</param>
        /// <param name="y">координата центра У</param>
        /// <param name="radiusSmall">малый радиус</param>
        /// <param name="radiusLarge">больший радиус</param>
        /// <param name="sym">символ прорисовки</param>
        public static void EnteringElipse(ref int x, ref int y, ref int radiusSmall, ref int radiusLarge, ref char sym)
        {
            Console.Clear();
            Log.ShowMessage("Координата X центра окружности: ");
            x = int.Parse(Console.ReadLine());
            Log.ShowMessage("Координата Y центра окружности: ");
            y = int.Parse(Console.ReadLine());
            Log.ShowMessage("Введите малый радиус: ");
            radiusSmall = int.Parse(Console.ReadLine());
            Log.ShowMessage("Введите больший радиус: ");
            radiusLarge = int.Parse(Console.ReadLine());
            Log.ShowMessage("Каким символом рисовать?: ");
            sym = char.Parse(Console.ReadLine());
        }
    }
}
