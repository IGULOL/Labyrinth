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
        public static void ShowDataGridView(DataGridView dgv, int n)
        {
            DataTable lbr = new DataTable("labirinth");
            DataColumn[] cols = new DataColumn[n];

            //создание нужного количества ячеек
            for (int i = 0; i < n; i++)
            {
                cols[i] = new DataColumn(i.ToString());
                lbr.Columns.Add(cols[i]);
            }
            for (int i = 0; i < n; i++)
            {
                DataRow newRow;
                newRow = lbr.NewRow();
                lbr.Rows.Add(newRow);
            }

            //установление размера ячеек
            dgv.DataSource = lbr;
            for (int i = 0; i < n; i++)
            {
                dgv.Columns[i].Width = 25;
            }
            for (int i = 0; i < n; i++)
            {
                dgv.Rows[i].Height = 25;
            }

            //настройка размера лабиринта
            dgv.Width = dgv.Columns[0].Width * n + n;
            dgv.Height = dgv.Rows[0].Height * n + n;

            //настройка цвета ячеек
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
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

        //рандомное создание матрицы
        public static void RandomDataGridView(DataGridView dgv, Random rnd)
        {
            //делаем стены
            int n_col = dgv.ColumnCount;
            int n_str = dgv.RowCount;

            for (int i = 0; (i < n_col); i++)
            {
                for (int j = 0; (j < n_str); j++)
                {
                    bool doWall = (rnd.NextDouble() < 0.5);
                    if (doWall)
                    {
                        dgv[i, j].Style.BackColor = Color.Black;
                    }
                    else
                    {
                        dgv[i, j].Style.BackColor = Color.White;
                    }
                }
            }
            //делаем вход и выход
            int x = rnd.Next(1, n_col);
            int y = rnd.Next(1, n_str);
            dgv[x, y].Style.BackColor = Color.Blue;
            do
            {
                x = rnd.Next(1, n_col);
                y = rnd.Next(1, n_str);
                if (dgv[x, y].Style.BackColor != Color.Blue)
                {
                    dgv[x, y].Style.BackColor = Color.DarkBlue;
                }
            } while  (dgv[x, y].Style.BackColor != Color.DarkBlue);
        }
    }
}
