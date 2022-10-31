using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба4
{
    public partial class Form1 : Form
    {
        double[] b;
        int j;
        int i;
        int k;

        // Инициализируем динамически переменную result
        double [,] Sq;
        double[,] T;
        public Form1()
        {
            InitializeComponent();
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
            Sq = new double Sq[j, k];
            T = new double T[k, i];
            b = new double[3];
            for (int j = 0; j < 4; j++) //Цикл по вершинам фигуры (4 вершины для квадрата)
            {

                for (int i = 0; i < 3; i++)
                {

                    b[i] = 0;
                    for (int k = 0; k < 3; k++)
                        b[i] = b[i] + Sq[j, k] * T[k, i];

                }
                for (int k = 0; k < 3; k++)
                    Sq[j, k] = b[k];
            }
            for (int j = 0; j < 4; j++)
            {
                Sq[j, 0] = Sq[j, 0] / Sq[j, 2];
                Sq[j, 1] = Sq[j, 1] / Sq[j, 2];
                Sq[j, 2] = 1;

            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen skyBluePen = new Pen(Brushes.DeepSkyBlue);
            int cx = ClientSize.Width / 2;
            int cy = ClientSize.Height / 2;
            gfx.DrawLine(skyBluePen, cx, 0, cx, ClientSize.Height);
            gfx.DrawLine(skyBluePen, 0, cy, ClientSize.Width, cy);

            Pen SqPen = new Pen(Brushes.BlueViolet);

            gfx.DrawLine(SqPen, (int)(cx + Sq[0, 0]), (int)(cy - Sq[0, 1]),
            (int)(cx + Sq[1, 0]), (int)(cy - Sq[1, 1]));
            gfx.DrawLine(SqPen, (int)(cx + Sq[1, 0]), (int)(cy - Sq[1, 1]),
            (int)(cx + Sq[2, 0]), (int)(cy - Sq[2, 1]));
            gfx.DrawLine(SqPen, (int)(cx + Sq[2, 0]), (int)(cy - Sq[2, 1]),
            (int)(cx + Sq[3, 0]), (int)(cy - Sq[3, 1]));
            gfx.DrawLine(SqPen, (int)(cx + Sq[3, 0]), (int)(cy - Sq[3, 1]),
            (int)(cx + Sq[0, 0]), (int)(cy - Sq[0, 1]));
        }
    }

   
}
