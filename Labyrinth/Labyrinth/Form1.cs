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

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("     Размер n x m: размер будущего лабиринта, где n -\r\n"
                + "количество строк, m - количество столбцов.\r\n"
                + "     Редактирование лабиринта: \r\n"
                + "a) начать - при выборе в таблице ячеек, соответствующие\r\n"
                + "ячейки меняют цвет;\r\n"
                + "b) закончить - останавливает редактирование.\r\n"
                + "     Черный цвет означает стену, белый - пустоту (проход).\r\n",
                "Информация о работе приложения", MessageBoxButtons.OK);
        }



        private void dgvLabirinth_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvLabirinth.CurrentCell.Style.BackColor == Color.White)
            {
                dgvLabirinth.CurrentCell.Style.BackColor = Color.Black;
            }
            else 
                if (dgvLabirinth.CurrentCell.Style.BackColor == Color.Black)
                {
                    dgvLabirinth.CurrentCell.Style.BackColor = Color.White;
                }
            
        }

    }
}
