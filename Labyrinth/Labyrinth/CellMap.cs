using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth
{
    //ячейка карты движений
    struct CellMap
    {
        public int Value { get; set; }      //значение волны
        public int Grenades { get; set; }   //сколько гранат на этом шаге использовано
    }
}
