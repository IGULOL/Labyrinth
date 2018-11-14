using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Labyrinth
{
    class DataGridViewUtils
    {
        //задать матрицу нужного размера
        public static void ShowDataGridView(DataGridView dtv, int n_str, int n_col)
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
            dtv.DataSource = lbr;
            for (int i = 0; i < n_col; i++)
                dtv.Columns[i].Width = 30;

            dtv.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            dtv.AutoResizeColumns();

            dtv.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.AllCells;
            dtv.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }
    }
}
