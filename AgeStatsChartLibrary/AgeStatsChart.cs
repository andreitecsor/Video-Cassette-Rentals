using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeStatsChartLibrary
{
    public partial class AgeStatsChart : UserControl
    {
        public int[] varste;
        int nrMinori;
        int nrMajori;
        public AgeStatsChart(int[] varstePrimite)
        {
            InitializeComponent();
            varste = varstePrimite;
            ResizeRedraw = true;
        }
        #region Desenare grafic 
        private void AgeStatsChart_Paint(object sender, PaintEventArgs e)
        {
            Font fontTitlu = new Font("Times New Roman", 14, FontStyle.Bold);
            Font font = new Font("Times New Roman", 12);

            Graphics graphics = e.Graphics;
            Rectangle rectangle = e.ClipRectangle; // 426 x 426

            nrMinori = 0;
            nrMajori = 0;

            for (int i = 0; i < varste.Length; i++)
            {
                if (varste[i] >= 18)
                {
                    nrMajori++;
                }
                else
                {
                    nrMinori++;
                }
            }

            int max;

            if (nrMinori > nrMajori)
            {
                max = nrMinori;
            }
            else
            {
                max = nrMajori;
            }

            var scaleFactor = (rectangle.Height - 20) / varste.Length;
            var barWidth = (rectangle.Width - 20) / 2;
            var minoriBarHeight = nrMinori * scaleFactor;
            var majoriBarHeight = nrMajori * scaleFactor;

            //public void FillRectangle(Brush brush, int X, int Y, int WIDTH, int HEIGHT);
            //public void FillRectangle(Brush brush, int AXA_ORIZONTALA, int AXA_VERTICALA, int LATIME, int INALTIME);

            graphics.DrawString("Grafic vârste clienți", fontTitlu, new SolidBrush(Color.Black), 0, 0);

            //BAR MINORI:
            graphics.FillRectangle(new SolidBrush(Color.FromArgb(102, 204, 0)),0,rectangle.Height - minoriBarHeight - 20,(float)barWidth,minoriBarHeight - 20);


            //BAR MAJORI:
            graphics.FillRectangle(new SolidBrush(Color.FromArgb(153, 51, 255)),barWidth + 20,rectangle.Height - majoriBarHeight - 20,(float)barWidth,majoriBarHeight - 20);

            //Texte sub bar-uri
            graphics.DrawString("Minori", fontTitlu, new SolidBrush(Color.FromArgb(102, 204, 0)), barWidth / 3 - 10, rectangle.Height - 40);
            graphics.DrawString("Majori", fontTitlu, new SolidBrush(Color.FromArgb(153, 51, 255)), barWidth + 20 + barWidth / 3 - 10, rectangle.Height - 40);
            
            //Texte deasupra bar-uri
            graphics.DrawString(nrMinori.ToString(), fontTitlu, new SolidBrush(Color.FromArgb(102, 204, 0)), barWidth / 2 - 5, rectangle.Height - minoriBarHeight - 40);
            graphics.DrawString(nrMajori.ToString(), fontTitlu, new SolidBrush(Color.FromArgb(153, 51, 255)), barWidth + 20 + barWidth / 2 - 5, rectangle.Height - majoriBarHeight - 40);

            //Border dreptunghi
            Pen pen = new Pen(Color.Black, 3);
            graphics.DrawRectangle(pen, 1, rectangle.Height - minoriBarHeight - 20,(float)barWidth - 1,minoriBarHeight - 20);
            graphics.DrawRectangle(pen, barWidth + 20, rectangle.Height - majoriBarHeight - 20,(float)barWidth - 1,majoriBarHeight - 20);
        }
        #endregion
    }
}
