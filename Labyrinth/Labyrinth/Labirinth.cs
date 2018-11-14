using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void GridToLabirinth()
        {
            throw new NotImplementedException();
        }
    }
}
