using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;

namespace Figures
{
    class Enums
    {
        /// <summary>
        /// направления прорисовки линий
        /// </summary>
        public enum DrowingDirection : int
        {
            Empty,
            Up,
            Down,
            Right,
            Left,
            DiagRightDown,
            DiagLeftDown,
            DiagRightUp,
            DiagLeftUp
        }
        /// <summary>
        /// направления передвижений
        /// </summary>
        public enum MovingDirection : int
        {
            Empty,
            Up,
            Down,
            Right,
            Left,
        }
        /// <summary>
        /// перечисление фигур
        /// </summary>
        public enum Figures : int
        {
            Empty,
            Line,
            Elipse,
            Circle,
            Triangle,
            Rectangle,
            Square,
            CircleInSquare,
            ShowAll
        }
        
    }
}
