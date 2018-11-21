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

        Point start;
        Point finish;

        Random rnd;

        bool routeIsBuilt;

        public FormName()
        {
            InitializeComponent();
            rnd = new Random();
            routeIsBuilt = false;
        }

        private void FormName_Shown(object sender, EventArgs e)
        {
            InitLabirinth();
        }

        //изменение размера лабиринта
        private void size_ValueChanged(object sender, EventArgs e)
        {
            InitLabirinth();
        }

        //инициализация лабиринта
        private void InitLabirinth()
        {
            start = new Point(-1, -1);
            finish = new Point(-1, -1);
            int N = Convert.ToInt32(size.Value);
            lbr = new Labirinth(dgvLabirinth, N);
        }

        //информация
        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("     Размер n x m: размер будущего лабиринта, где n -\r\n"
                + "количество строк, m - количество столбцов.\r\n\r\n"
                + "     Редактирование лабиринта: \r\n"
                + "a) При выборе 'Стены' позволяет рисовать стены.\r\n"
                + "b) При выборе 'Вход/Выход' позволяет рисовать вход и выход.\r\n\r\n"
                + "     Пояснение цветов лабиринта: \r\n"
                + "a) Черный цвет означает стены.\r\n"
                + "b) Белый цвет - проходы.\r\n"
                + "c) Голубой цвет - вход в лабиринт.\r\n"
                + "c) Синий цвет - выход из лабиринта.\r\n"
                + "d) Зеленый цвет - путь из лабиринта.\r\n"
                + "e) Красный цвет - использование гранат.\r\n\r\n"
                + "     Внимание! В лабиринте может быть неограниченное\r\n"
                + "количество стен, один вход и один выход.\r\n",
                "Информация о работе приложения", MessageBoxButtons.OK);
        }        

        //при нажатии на ячейку
        private void dgvLabirinth_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            //если маршрут был построен, стираем его
            if (routeIsBuilt)
            {
                DataGridViewUtils.ClearWay(dgvLabirinth);
                routeIsBuilt = false;
            }

            var cell = dgvLabirinth[e.ColumnIndex, e.RowIndex];

            //получаем цвет текущей ячейки
            Color color = cell.Style.BackColor;

            //не допускаем нажатия нескольких checkBox'ов
            if (checkedEdit.CheckedItems.Count > 0)
            {
                switch (checkedEdit.SelectedIndex)
                {
                    //стена
                    case 0:
                        color = Color.Black;
                        break;
                    //вход
                    case 1:
                        color = Color.Blue;
                        //если отметка уже была, стираем старую
                        if (start.X != -1)
                        {
                            dgvLabirinth[start.X, start.Y].Style.BackColor = Color.White;                           
                        }
                        start = new Point(cell.ColumnIndex, cell.RowIndex);
                        break;
                    //выход
                    case 2:
                        color = Color.DarkBlue;
                        if (finish.X != -1)
                        {
                            dgvLabirinth[finish.X, finish.Y].Style.BackColor = Color.White;                           
                        }
                        finish = new Point(cell.ColumnIndex, cell.RowIndex);
                        break;
                }
            
                //если в ней было пусто
                if (cell.Style.BackColor == Color.White)
                {
                    cell.Style.BackColor = color;
                }
                else
                {
                    cell.Style.BackColor = Color.White;
                }
            }

            //убираем цвет выбора
            cell.Style.SelectionBackColor = cell.Style.BackColor;
        }

        //выбор checkBox для редактирования лабиринта
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

        //найти путь
        private void btnRun_Click(object sender, EventArgs e)
        {
            if(!DataGridViewUtils.CheckDataGridView(dgvLabirinth))
            {
                MessageBox.Show("В лабиринте должен быть один вход и один выход.",
                "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                routeIsBuilt = lbr.FindWay((int)countGrenades.Value, (int)size.Value, start, finish);
            }
        }

        //видимость элементов при выборе вида создания лабиринта
        private void rbManually_CheckedChanged(object sender, EventArgs e)
        {
            checkedEdit.Visible = rbManually.Checked;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            btnRandom.Visible = !rbManually.Checked;
        }
              
        //создание рандомного лабиринта
        private void btnRandom_Click(object sender, EventArgs e)
        {
            DataGridViewUtils.RandomDataGridView(dgvLabirinth, rnd, ref start, ref finish);          
        }
    }
}
