using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figures
{
    public interface IGrafical2D
    {
        /// <summary>
        /// Вычисление площади
        /// </summary>
        /// <returns></returns>
        double Area();
        /// <summary>
        /// Вычисление периметра
        /// </summary>
        /// <returns></returns>
        double Perimeter();
    }
}
