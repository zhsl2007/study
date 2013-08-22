//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
////using System.Linq;
//using System.Text;
//using System.Windows.Forms;
//using System.Drawing.Drawing2D;

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace POK_project
{
   public enum FireMode
        {
            /// <summary>
            /// Absolute Scale Mode: Values from 0 to 100 are accepted and displayed
            /// </summary>
            Horizontal,
            /// <summary>
            /// Relative Scale Mode: All values are allowed and displayed in a proper relation
            /// </summary>
            Vertical
        }

    public partial class Form1 : Form
    {
     
        public Form1()
        {
            try
            {
                InitializeComponent();
                SetStyle(ControlStyles.AllPaintingInWmPaint, true);
                SetStyle(ControlStyles.UserPaint, true);
                SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            image_H = new Bitmap("res\\arrow.jpg");
            image_V = new Bitmap("res\\arrow.jpg");

            image_Close = new Bitmap("res\\close.jpg");
            image_Open = new Bitmap("res\\open.jpg");

            fireH = new hydrant();
            fireH.Location = new Point(0, 0);
            this.Controls.Add(fireH);

            fireV = new hydrant();
            fireV.Location = new Point(this.Width - 340, 3);
            this.Controls.Add(fireV);

            this.pictureBox1.Image = image_Close;
            
        }

        const float pi = 3.14159265F;
        private Bitmap image_H = null;
        private Bitmap image_V = null;

        private Bitmap image_Close = null;
        private Bitmap image_Open = null;
        static float rotateAngle_V = 0;
        static float rotateAngle_H = 0;

        hydrant fireH = null;
        hydrant fireV = null;
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    // 
        //    Bitmap bufferimage = new Bitmap(this.Width, this.Height);
        //    Graphics g = Graphics.FromImage(bufferimage);
        //    g.Clear(this.BackColor);
        //    g.SmoothingMode = SmoothingMode.HighQuality; //高质量
        //    g.PixelOffsetMode = PixelOffsetMode.HighQuality; //高像素偏移质量

        //    //center point 
        //    float x = 160.0f;
        //    float y = 160.0f;
        //    //
        //    float r = 150.0f;

        //    float one = pi/180;
        //    // 
        //    int angle = 10;

        //    float ptR = 3.0f;
        //    float ptCenterR = 5.0f;

        //    //center 
        //    //g.FillEllipse(Brushes.Red, x - ptCenterR / 2, y - ptCenterR / 2, ptCenterR, ptCenterR);

        //    for (int i = 0; i < 360 / angle; i++)
        //    {
        //        // 1
        //        float gX = x + r * (float)(Math.Sin(one * i * 10));
        //        float gY = y + r * (float)(Math.Cos(one * i * 10));
        //        g.FillEllipse(Brushes.Red, gX - ptR / 2, gY - ptR / 2, ptR, ptR);
        //    }

        //    //draw horizontal
        //    float x_H = (float)this.Size.Width - 170.0f;
        //    float y_H = 160.0f;

        //    int angle_H = 10;
        //    for (int j = 0; j < 360 / angle_H; j++)
        //    {
        //        // 1
        //        float gX_H = x_H + r * (float)(Math.Sin(one * j * 10));
        //        float gY_H = y_H + r * (float)(Math.Cos(one * j * 10));
        //        g.FillEllipse(Brushes.Red, gX_H - ptR / 2, gY_H - ptR / 2, ptR, ptR);
        //    }


        //    // arrow
        //    //
        //    DrawImage(g, rotateAngle_V, FireMode.Horizontal);
        //    DrawImage(g, rotateAngle_H, FireMode.Vertical);


        //    ////Put the rotation point in the center of the image

        //    Graphics tg = e.Graphics;
        //    tg.DrawImage(bufferimage, 0, 0);　　//把画布贴到画面上
        //}

        private void DrawImage(Graphics g, float angle, FireMode mode)
        {
            
            //create a new empty bitmap to hold rotated image
            //Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
            //rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            //make a graphics object from the empty bitmap
            //Graphics g = Graphics.FromImage(rotatedBmp);

            if (mode == FireMode.Horizontal)
            {
                //Put the rotation point in the center of the image
                g.TranslateTransform(this.Width -170.0f - 2.5f, 160 - 2.5f);

                //rotate the image
                g.RotateTransform(angle);

                //move the image back
                g.TranslateTransform(-(this.Width - 170) + 2.5f, -160 + 2.5f);

                //draw passed in image onto graphics object
                g.DrawImage(image_H, new PointF(this.Width - 170.0f - 2.5f, 160 - 2.5f));
            }
            else
            {
                //Put the rotation point in the center of the image
                g.TranslateTransform(160 - 2.5f, 160 - 2.5f);

                //rotate the image
                g.RotateTransform(angle);

                //move the image back
                g.TranslateTransform(-160 + 2.5f, -160 + 2.5f);

                //draw passed in image onto graphics object
                g.DrawImage(image_V, new PointF(160 - 2.5f, 160 - 2.5f));
            }

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (0 != this.fireH.RotateArrow(5))
            {
                MessageBox.Show("已经到最大，请点击Right按钮。");
            }
            this.lbl_H.Text = String.Format("水平角度：{0}", fireH.rotateAngle);
            this.fireH.Refresh();
        }
        

        private void btnUp_Click(object sender, EventArgs e)
        {
            //rotateAngle_V += 5;
             if (0 != this.fireV.RotateArrow(5))
            {
                MessageBox.Show("已经到最大，请点击Down按钮。");
            }
             this.lbl_V.Text = String.Format("竖直角度：{0}", fireV.rotateAngle);
            this.fireV.Refresh();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (0 !=this.fireV.RotateArrow(-5))
            {
                MessageBox.Show("已经到最小，请点击Up按钮。");
            }
            this.lbl_V.Text = String.Format("竖直角度：{0}", fireV.rotateAngle);
            this.fireV.Refresh();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
             if (0 !=this.fireH.RotateArrow(-5))
            {
                MessageBox.Show("已经到最小，请点击Left按钮。");
            }
             this.lbl_H.Text = String.Format("水平角度：{0}", fireV.rotateAngle);
            this.fireH.Refresh();
        }

        private void btnDuckOpen_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = image_Open;
        }

        private void btnDuckClose_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = image_Close;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String strMsg = String.Format(@"水平角度是{0}，竖直角度是{1}", this.lbl_H.Text, this.lbl_V.Text);
            MessageBox.Show(strMsg);
            MessageBox.Show("保存成功.");
        }
    }
}
