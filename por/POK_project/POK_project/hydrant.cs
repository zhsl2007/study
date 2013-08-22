using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace POK_project
{
    public partial class hydrant : Panel
    {
        public hydrant()
        {
            InitializeComponent();
            //// Set Optimized Double Buffer to reduce flickering
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            //// Redraw when resized
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            image = new Bitmap("res\\arrow.jpg");
            this.Size = new Size(330, 330);
            maxAngle = rotateAngle + 150.0f;
            minAngle = rotateAngle - 150.0f;
        }
        const float pi = 3.14159265F;
        private Bitmap image = null;
        public float rotateAngle = 270.0f;
        //public float startAngle = 270.0f;
        public float maxAngle = 0;
        public float minAngle = 0;

        public int RotateArrow(int angle)
        {
            float temp = rotateAngle + angle;
            if (temp <= minAngle)
            {
                return -1;
            }
            if (temp >= maxAngle)
            {
                return -2;
            }
            rotateAngle = temp;
            return 0;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            Bitmap bufferimage = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(bufferimage);
            g.Clear(this.BackColor);
            g.SmoothingMode = SmoothingMode.HighQuality; //高质量
            g.PixelOffsetMode = PixelOffsetMode.HighQuality; //高像素偏移质量

            //center point 
            float x = 160.0f;
            float y = 160.0f;
            //
            float r = 150.0f;

            float one = pi / 180;
            // 
            int angle = 10;

            float ptR = 3.0f;
            float ptCenterR = 5.0f;

            //center 
            //g.FillEllipse(Brushes.Red, x - ptCenterR / 2, y - ptCenterR / 2, ptCenterR, ptCenterR);

            for (int i = 0; i < 360 / angle; i++)
            {
                // 1
                float gX = x + r * (float)(Math.Cos(one * i * 10));
                float gY = y + r * (float)(Math.Sin(one * i * 10));
                

                if (i == 0 || i == 90 / angle || i == 180 / angle || i == 270 / angle)
                {
                    ptR = 7.0f;

                    g.FillEllipse(Brushes.Red, gX - ptR / 2, gY - ptR / 2, ptR, ptR);
                }
                else
                {
                    ptR = 3.0f;
                    g.FillEllipse(Brushes.Red, gX - ptR / 2, gY - ptR / 2, ptR, ptR);
                }
            }

            // draw max
            float maxX = x + r * (float)(Math.Cos(maxAngle * one));
            float maxY = y + r * (float)(Math.Sin(maxAngle * one));
            g.FillEllipse(Brushes.Black, maxX - ptCenterR / 2, maxY - ptCenterR / 2, ptCenterR, ptCenterR);

            // draw min
            float minX = x + r * (float)(Math.Cos(minAngle * one));
            float minY = y + r * (float)(Math.Sin(minAngle * one));
            g.FillEllipse(Brushes.Black, minX - ptCenterR / 2, minY - ptCenterR / 2, ptCenterR, ptCenterR);

            // draw start
           // float startX = x + r * (float)(Math.Sin(rotateAngle));
            //float startY = y - r * (float)(Math.Cos(rotateAngle));
            //g.FillEllipse(Brushes.Black, startX - ptCenterR / 2, startY - ptCenterR / 2, ptCenterR, ptCenterR);


            // arrow
            //
            DrawImage(g, rotateAngle);

            ////Put the rotation point in the center of the image
            Graphics tg = e.Graphics;
            tg.DrawImage(bufferimage, 0, 0);　　//把画布贴到画面上

        }
        private void DrawImage(Graphics g, float angle)
        {
            //create a new empty bitmap to hold rotated image
            //Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
            //rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            //make a graphics object from the empty bitmap
            //Graphics g = Graphics.FromImage(rotatedBmp);

            //Put the rotation point in the center of the image
            g.TranslateTransform(160 - 2.5f, 160 - 2.5f);

            //rotate the image
            g.RotateTransform(angle);

            //move the image back
            g.TranslateTransform(-160 + 2.5f, -160 + 2.5f);

            //draw passed in image onto graphics object
            g.DrawImage(image, new PointF(160 - 2.5f, 160 - 2.5f));
        }

        //public hydrant(IContainer container)
        //{
        //    container.Add(this);

        //    InitializeComponent();
        //}
    }
}
