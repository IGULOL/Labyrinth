using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Labyrinth
{
    class DataGridViewUtils
    {
        //задать лабиринт нужного размера
        public static void ShowDataGridView(DataGridView dgv, int n_str, int n_col)
        {
            DataTable lbr = new DataTable("labirinth");
            DataColumn[] cols = new DataColumn[n_col];

            //создание нужного количества ячеек
            for (int i = 0; i < n_col; i++)
            {
                cols[i] = new DataColumn(i.ToString());
                lbr.Columns.Add(cols[i]);
            }
            for (int i = 0; i < n_str; i++)
            {
                DataRow newRow;
                newRow = lbr.NewRow();
                lbr.Rows.Add(newRow);
            }

            //установление размера ячеек
            dgv.DataSource = lbr;
            for (int i = 0; i < n_col; i++)
            {
                dgv.Columns[i].Width = 25;
            }
            for (int i = 0; i < n_str; i++)
            {
                dgv.Rows[i].Height = 25;
            }

            //настройка размера лабиринта
            dgv.Width = dgv.Columns[0].Width * n_col + n_col;
            dgv.Height = dgv.Rows[0].Height * n_str + n_str;

            //настройка цвета ячеек
            for (int i = 0; i < n_col; i++)
            {
                for (int j = 0; j < n_str; j++)
                {
                    dgv[i, j].Style.BackColor = Color.White;
                    dgv[i, j].Style.SelectionBackColor = Color.GhostWhite;
                }
            }
        }

        //проверить правильность построенного лабиринта
        public static bool CheckDataGridView(DataGridView dgv)
        {
            int n_col = dgv.ColumnCount;
            int n_str = dgv.RowCount;

            int n_in = 0;
            int n_out = 0;

            //проверяем наличие одного входа и одного выхода
            for (int i = 0; (i < n_col); i++)
            {
                for (int j = 0; (j < n_str); j++)
                {
                    if (dgv[i, j].Style.BackColor == Color.Blue)
                    {
                        n_in++;
                    }
                    if (dgv[i, j].Style.BackColor == Color.DarkBlue)
                    {
                        n_out++;
                    }
                }
            }

            return (n_in == 1) && (n_out == 1);
        }
    }
}
