using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Labyrinth
{
    class LabirinthUtils
    {
        //направление
        public enum Direction : int
        {
            None = 0,
            Left = 1,
            Right = 2,
            Up = 3,
            Down = 4
        }

        //направление
        public static Dictionary<Direction, Point> moveTo = new Dictionary<Direction, Point>()
        {
            { Direction.None,   new Point(0, 0) },
            { Direction.Left,   new Point(0,-1) },
            { Direction.Right,  new Point(0, 1) },
            { Direction.Up,     new Point(-1,0) },
            { Direction.Down,   new Point(1, 0) }
        };
       
    }
}
