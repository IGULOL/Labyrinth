﻿using System;
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
                + "a) При выборе 'Стены' позволяет рисовать стены.\r\n"
                + "b) При выборе 'Вход/Выход' позволяет рисовать вход и выход.\r\n"
                + "     Пояснение цветов лабиринта: \r\n"
                + "a) Черный цвет означает стены.\r\n"
                + "b) Белый цвет - проходы.\r\n"
                + "c) Голубой цвет - вход в лабиринт.\r\n"
                + "c) Синий цвет - выход из лабиринта.\r\n"
                + "d) Зеленый цвет - путь из лабиринта.\r\n"
                + "e) Красный цвет - использование гранат.\r\n",
                "Информация о работе приложения", MessageBoxButtons.OK);
        }

        //при нажатии на ячейку
        private void dgvLabirinth_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            var cell = dgvLabirinth[e.ColumnIndex, e.RowIndex];

            Color color = cell.Style.BackColor;

            if (checkedEdit.CheckedItems.Count > 0)
            {
                switch (checkedEdit.SelectedIndex)
                {
                    case 0:
                        color = Color.Black;
                        break;
                    case 1:
                        color = Color.Blue;
                        break;
                    case 2:
                        color = Color.DarkBlue;
                        break;
                }
            
                if (cell.Style.BackColor == Color.White)
                {
                    cell.Style.BackColor = color;
                }
                else
                {
                    cell.Style.BackColor = Color.White;
                }
            }

            cell.Style.SelectionBackColor = cell.Style.BackColor;
        }

        //выбор checkBox для редактирования
        private void checkedEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //если уже есть отмеченные, то снимаем выделение
            if (checkedEdit.CheckedItems.Count > 0)
            {
                for (int i = 0; i < checkedEdit.Items.Count; i++)
                {
                    checkedEdit.SetItemChecked(i, false);
                }
                checkedEdit.SetItemChecked(checkedEdit.SelectedIndex, true);
            }
        }
    }
}
