using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Input;


namespace Лаба4
{
    public partial class Form1 : Form
    {
        double[,] Fig_circle; //Создаём массивы для фигур
        double[,] Trans_Mat_Fig = new double[3,3];//матрицы трансформации для фигур 
        double[,] Fig_star;
        int cn = 100;
        int cr = 50;
        int sr = 150;
        int sn = 12;
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
            Fig_star = new double[sn, 3];
            int sn_2 =sn / 2;
            for (int i =0; i< sn_2; i++)
            {
                double phi = (2 * Math.PI*i) / sn_2;
                double teta = Math.PI / sn_2;
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
            draw(e.Graphics);//она типо для удобства

        }
        private void draw_figure (Graphics g, double[,] Figure)
        { 
            
            int Verschin = Figure.GetLength(0);
            double[,] Trans_Mat_Fig;
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

       
        private void draw(Graphics gfx)
        {
            Pen skyBluePen = new Pen(Brushes.DeepSkyBlue);
            int cx = pictureBox1.Width / 2; // Находим координаты центра
            int cy = pictureBox1.Height / 2;
            gfx.DrawLine(skyBluePen, cx, 0, cx, pictureBox1.Height);
            gfx.DrawLine(skyBluePen, 0, cy, pictureBox1.Width, cy);
            Pen CPen = new Pen(Brushes.BlueViolet);
            draw_figure(gfx, Fig_circle);//
            draw_figure(gfx, Fig_star);
        }
        // Перемещение фигуры по осям 
        private void move_x(int step)
        {
            for (int i =0; i<cn;i++)
            {
                Fig_circle[i, 0] += step;//
            }
            for (int i = 0; i < sn; i++)//
            {
                Fig_star[i, 0] += step;//
            }
           pictureBox1.Image = null;
        }
        private void move_y(int step)
        {
            for (int i = 0; i < cn; i++)
            {
                Fig_circle[i, 1] += step;//
            }
            for (int i = 0; i < sn; i++)
            {
                Fig_star[i, 1] += step;//
            }
          pictureBox1.Image = null;// новый вид картинки 
        }

        private void btn_left(object sender, EventArgs e)
        {
            move_x(-10);//по икс перемещаем в лево 
        }

        private void btn_right(object sender, EventArgs e)
        {
            move_x(10);//
        }

        private void btn_up(object sender, EventArgs e)
        {
            move_y(10);// 
        }

        private void btn_down(object sender, EventArgs e)
        {
            move_y(-10);
        }

        
        // Увеличение размеров фигуры
        private void move_size_x(double step)
        {
            for (int i = 0; i < cn; i++)
            {
                Fig_circle[i, 0] *= step;//
            }
            for (int i = 0; i < sn; i++)//
            {
                Fig_star[i, 0] *= step;//
            }
            pictureBox1.Image = null;
        }
        private void move_size_y(double step)
        {
            for (int i = 0; i < cn; i++)
            {
                Fig_circle[i, 1] *= step;//
            }
            for (int i = 0; i < sn; i++)
            {
                Fig_star[i, 1] *= step;//
            }
            pictureBox1.Image = null;// новый вид картинки 
        }
        private void button7_Click(object sender, EventArgs e)
        {
            move_size_y(1.1);
            move_size_x(1.1);
        }
        // Уменьшение размеров фигуры
        private void move_size1_x(double step)
        {
            for (int i = 0; i < cn; i++)
            {
                Fig_circle[i, 0] /= step;//
            }
            for (int i = 0; i < sn; i++)//
            {
                Fig_star[i, 0] /= step;//
            }
            pictureBox1.Image = null;
        }
        private void move_size1_y(double step)
        {
            for (int i = 0; i < cn; i++)
            {
                Fig_circle[i, 1] /= step;//
            }
            for (int i = 0; i < sn; i++)
            {
                Fig_star[i, 1] /= step;//
            }
            pictureBox1.Image = null;// новый вид картинки 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            move_size1_y(-1.1);
            move_size1_x(-1.1);
        }
    
    // Отображение фигуры относительно осей 
        private void mirror_x(int step)
        {
            for (int i = 0; i > -cn; i--)
            {
                Fig_circle[i, 0]= step;//
            }
            for (int i = 0; i > -sn; i++)//
            {
                Fig_star[i, 0] = step;//
            }
            pictureBox1.Image = null;
        }
        private void mirror_y(int step)
        {
            for (int i = -100; i > -cn; i--)
            {
                Fig_circle[i, 1] = step;//
            }
            for (int i = 0; i > -sn; i++)
            {
                Fig_star[i, 1] = step;//
            }
            pictureBox1.Image = null;// новый вид картинки 
        }
        private void ref_up_Click(object sender, EventArgs e)
        {
            mirror_y(1);
        }

        private void ref_down_Click(object sender, EventArgs e)
        {
            mirror_x(1);
        }
    }
}
