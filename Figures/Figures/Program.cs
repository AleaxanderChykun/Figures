using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {                                                          
            int x = 0;
            int y = 0;
            int length = 0;
            char sym = '*';
            bool IsCont = true;
            Figure f = null;
            Image img = new Image(f);

            do
            {
                Console.Clear();
                Log.MenuOfFigures(0,0);
                CreateFigure(ref f, UserInterface.GetFigure(), ref x, ref y, ref sym, ref length,  ref IsCont, ref img);
                
                Console.Clear();
                foreach (Figure fig in img.Fig)
                {
                    fig.Draw();
                }
                if (IsCont)
                {
                    Log.ShowTextInPos(0, 0, "Хотите передвинуть фигуру???(Y - да): ");
                    ConsoleKeyInfo Key = Console.ReadKey();
                    if (Key.Key == ConsoleKey.Y)
                    {
                        Log.ShowTextInPos(0, 0, "Клавиши управления - стрелка вправо, стрелка влево \nВыбор фигуры - Enter \nВыход - Escape ");
                        img.ChooseFigure(img.Fig, ref f);
                        Log.SetDefColor();
                        bool IsMoving = true;
                        do
                        {
                            f.Move(UserInterface.GetMovingDirection(ref IsMoving));
                            f.Draw();
                        } while (IsMoving);
                    }
                }
            } while (IsCont);
        }
        /// <summary>
        /// Метод создания фигуры
        /// </summary>
        /// <param name="f">переменная: фигура</param>
        /// <param name="figure">тип фигуры</param>
        /// <param name="x">стартовая координата Х</param>
        /// <param name="y">стартовая координата У</param>
        /// <param name="sym">символ прорисовки</param>
        /// <param name="length">переменная: длина </param>
        /// <param name="IsCont">продолжать ли программу</param>
        /// <param name="Img">список фигур</param>
        public static void CreateFigure(ref Figure f, Enums.Figures figure, ref int x, ref int y, ref char sym, ref int length,
                                     ref bool IsCont, ref Image img)
        {
            switch (figure)
            {
                case Enums.Figures.Line:
                    {
                        UserInterface.EnteringLine(ref x, ref y, ref sym, ref length);
                        f = new Line(x, y, length, sym);
                        img.Fig.Add(f.GetCopy());
                        break;
                    }
                case Enums.Figures.Elipse:
                    {
                        int radiusSmall = 0;
                        int radiusLarge = 0;
                        UserInterface.EnteringElipse(ref x, ref y, ref radiusSmall, ref radiusLarge, ref sym);
                        f = new Elipse(x, y, radiusSmall, radiusLarge, sym);
                        img.Fig.Add(f.GetCopy());
                        break;
                    }
                case Enums.Figures.Circle:
                    {
                        UserInterface.EnteringCircle(ref x, ref y, ref sym, ref length);
                        f = new Circle(x, y, length, sym);
                        img.Fig.Add(f.GetCopy());
                        break;
                    }
                case Enums.Figures.Triangle:
                    {
                        UserInterface.EnteringTriangle(ref x, ref y, ref sym, ref length);
                        f = new Triangle(x, y, length, sym);
                        img.Fig.Add(f.GetCopy());
                        break;
                    }
                case Enums.Figures.Rectangle:
                    {
                        int width = 0;
                        UserInterface.EnteringRectangle(ref x, ref y, ref length, ref width, ref sym);
                        f = new Rectangle(x, y, length, width, sym);
                        img.Fig.Add(f.GetCopy());
                        break;
                    }
                case Enums.Figures.Square:
                    {
                        UserInterface.EnteringSquare(ref x, ref y, ref length, ref sym);
                        f = new Square(x, y, length, sym);
                        img.Fig.Add(f.GetCopy());
                        break;
                    }
                case Enums.Figures.CircleInSquare:
                    {
                        UserInterface.EnteringSquare(ref x, ref y, ref length, ref sym);
                        f = new CircleInSquare(x, y, length, sym);
                        img.Fig.Add(f.GetCopy());
                        break;
                    }
                case Enums.Figures.ShowAll:
                    {
                        break;
                    }
                case Enums.Figures.Empty:
                    {
                        IsCont = false;
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
