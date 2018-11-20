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
        private int N;

        private DataGridView dgv;

        private int[,] labirinth; //матрица лабиринта

        private int[,] map;          //матрица лабиринта
        private CellMap[,] mapMoves; //матрица движений

        private Point start;
        private Point finish;
        
        public Labirinth(DataGridView dgv, int size)
        {
            this.dgv = dgv;
            this.N = size;

            labirinth = new int[size, size];

            DataGridViewUtils.ShowDataGridView(dgv, size);
        }

        public void LabirinthToGrid()
        {
            throw new NotImplementedException();
        }

        public bool GridToLabirinth()
        {
            if ((dgv.ColumnCount != N) || (dgv.RowCount != N))
            {
                return false;
            }

            //проверяем наличие одного входа и одного выхода
            for (int i = 0; (i < N); i++)
            {
                for (int j = 0; (j < N); j++)
                {
                    //стена
                    if (dgv[i, j].Style.BackColor == Color.Black)
                    {
                        labirinth[i, j] = -1;
                    }
                    if (dgv[i, j].Style.BackColor == Color.Blue)
                    {
                        start.X = i;
                        start.Y = j;
                    }
                    //финиш
                    if (dgv[i, j].Style.BackColor == Color.DarkBlue)
                    {
                        finish.X = i;
                        finish.Y = j;
                    }
                }
            }
            return true;
        }
        
        //результат шага
        private Point NextCell(int x, int y, LabirinthUtils.Direction step)
        {
            return new Point(x + LabirinthUtils.moveTo[step].X, y + LabirinthUtils.moveTo[step].Y);
        }

        //разрушить стену
        //очереди с плохими и хорошими ходами
        private void DestroyWall(ref Queue<Point> Qgood, ref Queue<Point> Qbad, ref int CurGrenades)
        {
            Point p;
            CurGrenades++;
            Qgood.Clear();
            while (Qbad.Count > 0)
            {
                p = Qbad.Dequeue();
                mapMoves[p.X, p.Y].Value = -mapMoves[p.X, p.Y].Value;
                Qgood.Enqueue(p);
            }
        }

        //следующая волна
        private void NextWave(ref Queue<Point> Qgood, ref Queue<Point> Qbad, int grenade)
        {
            int x;
            int y;
            LabirinthUtils.Direction move;
            Point p;

            p = Qgood.Dequeue();
            x = p.X;
            y = p.Y;

            for (int i = 0; i < 5; i++)
            {
                move = (LabirinthUtils.Direction)i;
                p = NextCell(x, y, move);
                if (mapMoves[p.X,p.Y].Value == 0)
                {
                    switch (map[p.X, p.Y])
                    {
                        case 0:
                            mapMoves[p.X, p.Y].Value = mapMoves[x, y].Value + 1;
                            mapMoves[p.X, p.Y].Grenades = grenade;
                            Qgood.Enqueue(p);
                            break;
                        case 1:
                            mapMoves[p.X, p.Y].Value = -mapMoves[x, y].Value - 1;
                            mapMoves[p.X, p.Y].Grenades = grenade + 1;
                            Qbad.Enqueue(p);
                            break;
                        default:
                            break;
                    }
                }
            }
        }    
        
        //инициализация карт
        private void InitMap(int size)
        {
            mapMoves = new CellMap[size + 2, size + 2];
            map = new int[size + 2, size + 2];

            for (int i = 0; i < size + 2; i++)
            {
                mapMoves[i, 0].Value = -1;
                mapMoves[i, 0].Grenades = -1;
                mapMoves[0, i].Value = -1;
                mapMoves[0, i].Grenades = -1;
                mapMoves[size + 1, i].Value = -1;
                mapMoves[size + 1, i].Grenades = -1;
                mapMoves[i, size + 1].Value = -1;
                mapMoves[i, size + 1].Grenades = -1;
                map[i, 0] = -1;
                map[0, i] = -1;
                map[i, size + 1] = -1;
                map[size + 1, i] = -1;
            }

            for (int i = 1; i < size + 1; i++)
            {
                for (int j = 1; j < size + 1; j++)
                {
                    mapMoves[i, j].Value = 0;
                    mapMoves[i, j].Grenades = -1;
                    map[i, j] = map[i - 1, j - 1];
                }
            }
        }

        //следующий шаг
        private void NextStep(ref int x, ref int y, int size)
        {
            Point p;
            LabirinthUtils.Direction step;

            bool ok = false;

            step = LabirinthUtils.Direction.None;

            do
            {
                step++;
                p = NextCell(x, y, step);
                if (map[x, y] == 1)
                {
                    ok = (mapMoves[x, y].Grenades - mapMoves[p.X, p.Y].Grenades == 1);
                }
                else
                {
                    ok = (mapMoves[x, y].Value - mapMoves[p.X, p.Y].Value == 1) 
                        && (mapMoves[x, y].Grenades == mapMoves[p.X, p.Y].Grenades);
                }

                if (ok)
                {
                    x = p.X;
                    y = p.Y;
                }
            } while (!ok);
        }

        //найти путь
        public void FindWay(int grenades, int size, Point start, Point finish)
        {
            int curGrenades = grenades;
            Queue<Point> Qgood = new Queue<Point>();
            Queue<Point> Qbad = new Queue<Point>();

            InitMap(size);

            //увеличиваем для движения внутри увеличенных матриц
            start.X++;
            start.Y++;
            finish.X++;
            finish.Y++;

            mapMoves[start.X, start.Y].Value = 1;
            mapMoves[start.X, start.Y].Grenades = 0;

            Qgood.Enqueue(start);
            curGrenades = 0;

            do
            {
                do
                {
                    NextWave(ref Qgood,ref  Qbad, curGrenades);
                } while ((Qgood.Count > 0) && (mapMoves[finish.X, finish.Y].Value) <= 0);
                if (mapMoves[finish.X, finish.Y].Value == 0)
                {
                    if (curGrenades == grenades)
                    {
                        MessageBox.Show("Все плохо", "Плохо", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        DestroyWall(ref Qgood, ref Qbad, ref curGrenades);
                    }
                }

            } while (mapMoves[start.X, start.Y].Value <= 0);

            //построить путь

            MessageBox.Show("Гранат потрачено: " + curGrenades.ToString(), "Выполнено", MessageBoxButtons.OK);
        }       
    }
}
