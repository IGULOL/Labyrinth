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
        private int rows;
        private int cols;

        private DataGridView dgv;

        private int[,] labirinth; 
        
        public Labirinth(DataGridView dgv, int rows, int cols)
        {
            this.dgv = dgv;

            this.rows = rows;
            this.cols = cols;

            labirinth = new int[rows, cols];

            DataGridViewUtils.ShowDataGridView(dgv, rows, cols);
        }

        public void LabirinthToGrid()
        {
            throw new NotImplementedException();
        }

        public bool GridToLabirinth()
        {
            if ((dgv.ColumnCount != cols) || (dgv.RowCount != rows))
            {
                return false;
            }

            //проверяем наличие одного входа и одного выхода
            for (int i = 0; (i < cols); i++)
            {
                for (int j = 0; (j < rows); j++)
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
