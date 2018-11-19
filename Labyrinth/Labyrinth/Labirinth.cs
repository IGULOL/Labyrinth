using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Labyrinth
{
    class Labirinth 
    {
        private int size;

        private DataGridView dgv;

        private int[,] labirinth; 
        
        public Labirinth(DataGridView dgv, int size)
        {
            this.dgv = dgv;
            this.size = size;

            labirinth = new int[size, size];

            DataGridViewUtils.ShowDataGridView(dgv, size);
        }

        public void LabirinthToGrid()
        {
            throw new NotImplementedException();
        }

        public bool GridToLabirinth()
        {
            if ((dgv.ColumnCount != size) || (dgv.RowCount != size))
            {
                return false;
            }

            //проверяем наличие одного входа и одного выхода
            for (int i = 0; (i < size); i++)
            {
                for (int j = 0; (j < size); j++)
                {
                    //стена
                    if (dgv[i, j].Style.BackColor == Color.Black)
                    {
                        labirinth[i, j] = -2;
                    }
                    if (dgv[i, j].Style.BackColor == Color.Blue)
                    {
                        labirinth[i, j] = 0;
                    }
                    //финиш
                    if (dgv[i, j].Style.BackColor == Color.DarkBlue)
                    {
                        labirinth[i, j] = -1;
                    }
                }
            }
            return true;
        }
    }
}
