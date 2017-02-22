using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Logger;

namespace Figures
{
    class Image
    {
        /// <summary>
        /// Конструктор картинки
        /// </summary>
        /// <param name="g"></param>
        public Image(IGrafical2D g)
        {
            _g = g;
            figures = new List<Figure>();     
        }
        /// <summary>
        /// Показать характеристики фигуры
        /// </summary>
        /// <param name="_g">переменная интерфейса IGrafical2D</param>
        public void ShowCharacteristicsOfFigure(IGrafical2D _g)
        {
            Log.ShowTextInPos(0, 0, _g.ToString());
        }
        /// <summary>
        /// Выбранная фигура
        /// </summary>
        /// <param name="f">фигура</param>
        public void ChoosedFigure(Figure f)
        {
            Log.SetForegroundColor(ConsoleColor.Red);
            f.Draw();
        }
        /// <summary>
        /// Возвращение цвета фигуры по-умолчанию
        /// </summary>
        /// <param name="f"></param>
        public void PreviosFigure(Figure f)
        {
            if (Fig.Count-1 > 0)
            {
                Log.SetDefColor();
                f.Draw();
            }
        }
        /// <summary>
        /// Проверка и получение следующего индекса
        /// </summary>
        /// <param name="index">проверяемый индекс</param>
        /// <returns></returns>
        public int GetNextIndex(ref int index)
        {
            index++;
            if (index > (figures.Count-1))
            {
                
                return index = 0;
            }
            else
            {
                return index;
            }
        }
        /// <summary>
        /// Проверка и получение предыдущего индекса
        /// </summary>
        /// <param name="index">проверяемый индекс</param>
        /// <returns></returns>
        public int GetPreviosIndex(ref int index)
        {
            index--;
            if (index < 0)
            {
                return index = figures.Count - 1;
            }
            else
            {
                return index;
            }
        }
        /// <summary>
        /// Перебор фигур
        /// </summary>
        /// <param name="fList">список фигур</param>
        /// <param name="fig">фигура</param>
        public void ChooseFigure(List<Figure> fList, ref Figure fig)
        {
            int index = 0;
            
            ChoosedFigure(fList.ElementAtOrDefault(index));
            ConsoleKeyInfo InfoKey;
            bool action = true;
            while (action)
            {
                if (Console.KeyAvailable)
                {
                    InfoKey = Console.ReadKey();
                    switch (InfoKey.Key)
                    {
                        case ConsoleKey.RightArrow:
                            {
                                ChoosedFigure(fList.ElementAtOrDefault(GetNextIndex(ref index)));
                                ShowCharacteristicsOfFigure(fList.ElementAtOrDefault(index));
                                PreviosFigure(fList.ElementAtOrDefault(GetPreviosIndex(ref index)));
                                GetNextIndex(ref index);
                                break;
                            }
                        case ConsoleKey.LeftArrow:
                            {
                                ChoosedFigure(fList.ElementAtOrDefault(GetPreviosIndex(ref index)));
                                ShowCharacteristicsOfFigure(fList.ElementAtOrDefault(index));
                                PreviosFigure(fList.ElementAtOrDefault(GetNextIndex(ref index)));
                                GetPreviosIndex(ref index);
                                break;
                            }
                        case ConsoleKey.Enter:
                            {
                                fig = fList.ElementAtOrDefault(index);
                                action = false;
                                break;
                            }
                        default:
                            break;
                    }
                }
            }
        }
        /// <summary>
        /// свойство получения списка фигур
        /// </summary>
        public List<Figure> Fig
        {
            get
            {
                return figures;
            }
        }
       
        private List<Figure> figures;
        IGrafical2D _g;
    }
}
