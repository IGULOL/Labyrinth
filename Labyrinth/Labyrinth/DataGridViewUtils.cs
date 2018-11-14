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
                dgv.Columns[i].Width = 30;
            }
            for (int i = 0; i < n_str; i++)
            {
                dgv.Rows[i].Height = 30;
            }

            dgv.Width = dgv.Columns[0].Width * n_col + n_col;
            dgv.Height = dgv.Rows[0].Height * n_str + n_str;

            
            dgv.DefaultCellStyle.SelectionForeColor = Color.GhostWhite;


        }
    }
}
