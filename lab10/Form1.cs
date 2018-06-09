using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class Form1 : Form
    {
         Graphics g;  //обьявляем обьект Graphics, который представляет поверхность рисования для формы  
       
        public Form1()
        {
            InitializeComponent();
        }

        float x0 = 100f;  //Установка начала координат 
        float y0 = 130f;
        int mag = 40;  // маштабирование (увеличение графика)
        float shag = 0.1f; // шаг
                       
        private void sinX()
        {
            g = this.CreateGraphics();//Вызов метода CreateGraphics формы, для получения ссылки на объект Graphics,
                                      // который представляет поверхность рисования для формы  Form1    
            g.DrawString("               y=sin(x)", Font, new SolidBrush(Color.DarkGreen), ClientRectangle); // пишем название функции

            // шаг  расчета значений на интервале -π/2...-2π, длина интервала 2,5π
            int nn = Convert.ToInt32(2.5f * Math.PI / shag); // определяем количество точек на интервале -π/2...-2π
            PointF[] points = new PointF[nn]; //создаем структуру (размером nn) - пара из чисел с плавающей запятой x и y (координаты),
                                              // определяющую точку на двумерной плоскости
            int ii = 0;
            for (float j = (float)(-Math.PI /2); j < 2 * Math.PI; j+= shag) //пределы -π/2...-2π для j
            {
                points[ii] = new PointF(); // создаем элементы структуры (точки)
                points[ii].X = x0 + j*mag;  // координата Х для текущей точки
                points[ii].Y = y0 - (float)(Math.Sin(j))*mag;  // определяем координату Y для текущей точки (вычисляем ф-ию Sin(j))
                ii++;
            }
            g.DrawLines(Pens.DarkGreen, points); //построение графика по найденым координатам точек из структуры points
                     
            draw_grid();  // прорисовка сетки координат
        }
                         
        private void cosX()
        {
            g = this.CreateGraphics();
            g.DrawString("                                                      " +
                "   y=cos(x)", Font, new SolidBrush(Color.Red), ClientRectangle); // пишем название функции

            // шаг  расчета значений на интервале -π/2...-2π, длина интервала 2,5π
            int nn = Convert.ToInt32(2.5f * Math.PI / shag);
            PointF[] points = new PointF[nn]; //создаем структуру - пара из чисел с плавающей запятой x и y координаты, определяющую точку на двумерной плоскости

            int ii = 0;
            for (float j = (float)(-Math.PI / 2); j < 2 * Math.PI; j += shag)
            {
                points[ii] = new PointF(); // //создаем элементы структуры (точки)
                points[ii].X = x0 + j * mag;
                points[ii].Y = y0 - (float)(Math.Cos(j)) * mag;
                ii++;
            }
            g.DrawLines(Pens.Red, points); //построение графика
            
            // прорисовка сетки координат
            draw_grid();
        }
               
        private void tgX()
        {
            g = this.CreateGraphics();
            g.DrawString("                                                               " +   // пишем название функции
                "                                    y=tg(x)", Font, new SolidBrush(Color.Blue), ClientRectangle);

            // шаг расчета значений на первом интервале -π/2...+π/2, длина интервала 1π
            int nn = Convert.ToInt32(Math.PI / shag);
            nn = nn - 3; // отсечение значений tg выходящих из области видимости графика 
            PointF[] points = new PointF[nn]; //создаем структуру - пара из чисел с плавающей запятой x и y координаты, 
                                              //определяющую точку на двумерной плоскости
            int ii = 0;
            for (float j = (float)(-Math.PI/2+0.2); j < (Math.PI/2-0.2); j += shag)
            {
                points[ii] = new PointF(); // //создаем элементы структуры (точки)
                points[ii].X = x0 + j * mag;
                points[ii].Y = y0 - (float)(Math.Tan(j)) * mag;
                ii++;
            }
            g.DrawLines(Pens.Blue, points); //построение графика

            // шаг  расчета значений на втором интервале π/2...+3π/2, длина интервала 1π
            int tt = Convert.ToInt32(Math.PI / shag); 
            tt = tt - 3; // отсечение значений tg выходящих из области видимости графика        
        
            PointF[] points1 = new PointF[tt]; //создаем структуру - пара из чисел с плавающей запятой x и y координаты,
                                               // определяющую точку на двумерной плоскости
            int iii = 0;
            for (float j = (float)(Math.PI/2+0.2); j < (Math.PI*(1.5)-0.2); j += shag)
            {
                points1[iii] = new PointF(); // //создаем элементы структуры (точки)
                points1[iii].X = x0 + j * mag;
                points1[iii].Y = y0 - (float)(Math.Tan(j)) * mag;
                iii++;
            }
            g.DrawLines(Pens.Blue, points1); //построение графика
            
            // прорисовка сетки координат
            draw_grid();
        }
          
        private void ctgX()
        {
            g = this.CreateGraphics();
            // пишем название функции
            g.DrawString("                                                                                        " +
                "                                   y=сtg(x)", Font, new SolidBrush(Color.Orange), ClientRectangle);

            // шаг  расчета значений на первом интервале 0...+π, длина интервала 1π
            int nn = Convert.ToInt32(Math.PI / shag);
            nn = nn - 4; // отсечение значений сtg выходящих из области видимости графика 
            PointF[] points = new PointF[nn]; //создаем структуру - пара из чисел с плавающей запятой x и y координаты, 
                                              //определяющую точку на двумерной плоскости
            int ii = 0;
            for (float j = 0.3f; j < (Math.PI - 0.2); j += shag)  //// отсечение значений tg выходящих из области видимости графика 
            {
                points[ii] = new PointF(); // //создаем элементы структуры (точки)
                points[ii].X = x0 + j * mag;
                points[ii].Y = y0 - (float)(1/Math.Tan(j)) * mag;
                ii++;
            }
            g.DrawLines(Pens.Orange, points); //построение графика

            // шаг  расчета значений на втором интервале π...+2π, длина интервала 1π
            int tt = Convert.ToInt32(Math.PI / shag);
            tt = tt - 4; // отсечение значений сtg выходящих из области видимости графика        
         
            PointF[] points1 = new PointF[tt]; //создаем структуру - пара из чисел с плавающей запятой x и y координаты,
                                               // определяющую точку на двумерной плоскости
            int iii = 0;
            for (float j = (float)(Math.PI + 0.3); j < (Math.PI*2 - 0.2); j += shag)
            {
                points1[iii] = new PointF(); // //создаем элементы структуры (точки)
                points1[iii].X = x0 + j * mag;
                points1[iii].Y = y0 - (float)(1 / Math.Tan(j)) * mag;
                iii++;
            }
            g.DrawLines(Pens.Orange, points1); //построение графика
             // прорисовка сетки координат
            draw_grid();
        }

        public void draw_grid() {
            
            using (Pen p = new Pen(Color.Black)) // рисуем координатную сетку
            {
                p.EndCap = LineCap.ArrowAnchor;
                //Рисуем ось X
                g.DrawLine(p, x0 - 80, y0, x0 + 280, y0);
                //Рисуем ось Y
                g.DrawLine(p, x0, y0 + 200, x0, y0 - 130);
            }

            // дополнительные  координатные линии 
            Pen pp = new Pen(Color.Gray);
            g.DrawLine(pp, x0 + ((float)(Math.PI) * 10f * shag * mag) / -2f,
             y0 + 140, x0 + ((float)(Math.PI) * 10f * shag * mag) / -2f, y0 - 120);   //вертикальная линия -π/2

            g.DrawLine(pp, x0 + ((float)(Math.PI) * 10f * shag * mag) / 2f,
                y0 + 140,    x0 + ((float)(Math.PI) * 10f * shag * mag) / 2f,  y0 - 120);   //вертикальная линия π/2

            g.DrawLine(pp, x0 + ((float)(Math.PI) * 10f * shag * mag), 
                y0 + 140,    x0 + ((float)(Math.PI) * 10f * shag * mag) ,   y0 - 120);  //вертикальная линия π

            g.DrawLine(pp, x0 + ((float)(Math.PI) * 10f * shag * mag)*1.5f, 
                y0 + 140,    x0 + ((float)(Math.PI) * 10f * shag * mag)*1.5f,   y0 - 120);  //вертикальная линия 3π/2

            g.DrawLine(pp, x0 + ((float)(Math.PI) * 10f * shag * mag)*2f, 
                y0 + 140,    x0 + ((float)(Math.PI) * 10f * shag * mag)*2f,   y0 - 120);  //вертикальная линия 2π



            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 255), 8);
            // подпись осей
            g.DrawString("-π/2", SystemFonts.MenuFont, Brushes.Black, x0 + ((float)(Math.PI) * 10f * shag * mag) / -2f, y0);
            g.DrawString("0", SystemFonts.MenuFont, Brushes.Black, x0, y0);
            g.DrawString("π/2", SystemFonts.MenuFont, Brushes.Black, x0 + ((float)(Math.PI) * 10f * shag * mag) / 2f, y0);
            g.DrawString("π", SystemFonts.MenuFont, Brushes.Black, x0 + ((float)(Math.PI) * 10f * shag * mag), y0);
            g.DrawString("3π/2", SystemFonts.MenuFont, Brushes.Black, x0 + ((float)(Math.PI) * 10f * shag * mag) * 1.5f, y0);
            g.DrawString("2π", SystemFonts.MenuFont, Brushes.Black, x0 + ((float)(Math.PI) * 10f * shag * mag) * 2f, y0);
            g.DrawString("x", SystemFonts.MenuFont, Brushes.Black, x0 + ((float)(Math.PI) * 10f * shag * mag) + 150, y0);
            g.DrawString(" y", SystemFonts.MenuFont, Brushes.Black, x0, y0 - 130);
            g.DrawString(" 1", SystemFonts.MenuFont, Brushes.Black, x0, y0 - 50);
            g.DrawString("-", SystemFonts.MenuFont, Brushes.Black, x0 - 5, y0 - 50);
            g.SmoothingMode = SmoothingMode.AntiAlias;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Програму построения графиков тригонометрических функций с  " +
                "       помощью средств GDI+ выполнил студент гр.ЗПI-71 Галян Н.Н. "); // MessageBox-о программе
        }
        
        private void cos_Click(object sender, EventArgs e) // рисование графика cos(х) при нажатии кнопки
        {
            cosX();
        }
        private void tg_Click(object sender, EventArgs e)
        {
            tgX();
        }
        private void ctg_Click(object sender, EventArgs e)
        {
            ctgX();
        }
        private void sin_Click(object sender, EventArgs e)
        {
            sinX();
        }
        private void Clear_Click(object sender, EventArgs e) // очистка формы от графиков
        {
            this.Invalidate();
        }

    }
}
