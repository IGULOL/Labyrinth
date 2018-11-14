using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* 7. Волновой алгоритм в лабиринте. Поиск пути выхода. N стенок можно разрушить (1<= n <= 10)
        b. найти путь с минимальным количеством используемых гранат*/

namespace Labyrinth
{
    public partial class FormName : Form
    {
        Labirinth lbr;

        public FormName()
        {
            InitializeComponent();
        }

        private void btnCreateLabirinth_Click(object sender, EventArgs e)
        {
            int rows = Convert.ToInt32(numericUpDownRows.Value);
            int cols = Convert.ToInt32(numericUpDownCols.Value);

            lbr = new Labirinth(dgvLabirinth, rows, cols);
        }
    }
}
