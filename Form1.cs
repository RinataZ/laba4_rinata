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
        double[,] Fig_circle; //Создаём массивы для фигур
        double[,] Fig_star;
        int cn = 100;
        int cr = 50;
        int sr = 150;
        int sn = 6;
        double x1 = 0;
        double y1 =0;
        double x2 = 0;
        double y2 = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // Fifura cruga
            Fig_circle = new double[cn, 3];
            for (int i = 0; i < cn; i++)
            {
                double phi = (2 * Math.PI * i) / cn;
                double x = Math.Cos(phi) * cr;
                double y = Math.Sin(phi) * cr;
                Fig_circle[i, 0] = x;
                Fig_circle[i, 1] = y;
                Fig_circle[i, 2] = 1;
            }
            // Figura stara
            Fig_star = new double[2 * sn, 3];
            for (int i =0; i<sn; i++)
            {
                double phi = (2 * Math.PI*i) / sn;
                double teta = Math.PI / sn;
                x1 = cr*Math.Cos(phi);
                y1 = cr * Math.Sin(phi);
                x2 = sr * Math.Cos(phi + teta);
                y2 = sr * Math.Sin(phi + teta);
                Fig_star[i*2, 0] = x1;
                Fig_star[i*2, 1] = y1;
                Fig_star[i*2, 2] = 1;
                Fig_star[i*2 + 1, 0] = x2;
                Fig_star[i*2 + 1, 1] = y2;
                Fig_star[i*2 + 1, 2] = 1;

            }
            
        }
     
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            /*
            //Рисуем оси координат
            Graphics gfx = e.Graphics;
            Pen skyBluePen = new Pen(Brushes.DeepSkyBlue);
            int cx = pictureBox1.Width / 2; // Находим координаты центра
            int cy = pictureBox1.Height / 2;
            gfx.DrawLine(skyBluePen, cx, 0, cx, pictureBox1.Height);
            gfx.DrawLine(skyBluePen, 0, cy, pictureBox1.Width, cy);
            Pen CPen = new Pen(Brushes.BlueViolet);
            draw_figure(gfx, Fig_circle);
            draw_figure(gfx, Fig_star);
            */

        }
        private void draw_figure (Graphics g, double[,] Figure)
        { 
            
            int Verschin = Figure.GetLength(0);
            int cx = pictureBox1.Width / 2; // Находим координаты центра
            int cy = pictureBox1.Height / 2;
            for (int i=0; i <Verschin; i++)
            {

                double x1 = Figure[i, 0];
                double y1 = Figure[i, 1];
                double x2 = Figure[(i + 1) % Verschin, 0];
                double y2 = Figure[(i + 1) % Verschin, 1];
                Pen Pen = new Pen(Brushes.BlueViolet);
                g.DrawLine(Pen, (int)(cx + x1), (int) (cy - y1), (int) (cx + x2), (int)(cy - y2));
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gfx = pictureBox1.CreateGraphics();
            Pen skyBluePen = new Pen(Brushes.DeepSkyBlue);
            int cx = pictureBox1.Width / 2; // Находим координаты центра
            int cy = pictureBox1.Height / 2;
            gfx.DrawLine(skyBluePen, cx, 0, cx, pictureBox1.Height);
            gfx.DrawLine(skyBluePen, 0, cy, pictureBox1.Width, cy);
            Pen CPen = new Pen(Brushes.BlueViolet);
            draw_figure(gfx, Fig_circle);
            draw_figure(gfx, Fig_star);
        }
       
        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
           /* Graphics gfx = pictureBox1.CreateGraphics();
            int width = pictureBox1.Width;
            do height = pictureBox1.Height;
            Bitmap bmp = new Bitmap(image, width, height);
            pictureBox1.Image = pictureBox1.RotateFlip(RotateFlipType.RotateNoneFlipY);*/
        }
    }

   
}
