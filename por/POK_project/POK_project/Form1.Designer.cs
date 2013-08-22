using System.Windows.Forms;
namespace POK_project
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDuckOpen = new System.Windows.Forms.Button();
            this.btnDuckClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbl_H = new System.Windows.Forms.Label();
            this.lbl_V = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(466, 1);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(110, 110);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(356, 110);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(110, 110);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(574, 110);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(110, 110);
            this.btnRight.TabIndex = 3;
            this.btnRight.Text = "right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(466, 218);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(110, 110);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(340, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 315);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(690, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 315);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(196, 359);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(414, 134);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnDuckOpen
            // 
            this.btnDuckOpen.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDuckOpen.Location = new System.Drawing.Point(649, 359);
            this.btnDuckOpen.Name = "btnDuckOpen";
            this.btnDuckOpen.Size = new System.Drawing.Size(141, 134);
            this.btnDuckOpen.TabIndex = 8;
            this.btnDuckOpen.Text = "打开";
            this.btnDuckOpen.UseVisualStyleBackColor = true;
            this.btnDuckOpen.Click += new System.EventHandler(this.btnDuckOpen_Click);
            // 
            // btnDuckClose
            // 
            this.btnDuckClose.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDuckClose.Location = new System.Drawing.Point(16, 359);
            this.btnDuckClose.Name = "btnDuckClose";
            this.btnDuckClose.Size = new System.Drawing.Size(141, 134);
            this.btnDuckClose.TabIndex = 9;
            this.btnDuckClose.Text = "关闭";
            this.btnDuckClose.UseVisualStyleBackColor = true;
            this.btnDuckClose.Click += new System.EventHandler(this.btnDuckClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(867, 359);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 134);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保存配置";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbl_H
            // 
            this.lbl_H.AutoSize = true;
            this.lbl_H.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_H.Location = new System.Drawing.Point(16, 520);
            this.lbl_H.Name = "lbl_H";
            this.lbl_H.Size = new System.Drawing.Size(105, 21);
            this.lbl_H.TabIndex = 11;
            this.lbl_H.Text = "水平角度:";
            // 
            // lbl_V
            // 
            this.lbl_V.AutoSize = true;
            this.lbl_V.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_V.Location = new System.Drawing.Point(462, 520);
            this.lbl_V.Name = "lbl_V";
            this.lbl_V.Size = new System.Drawing.Size(105, 21);
            this.lbl_V.TabIndex = 12;
            this.lbl_V.Text = "竖直角度:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1049, 560);
            this.Controls.Add(this.lbl_V);
            this.Controls.Add(this.lbl_H);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDuckClose);
            this.Controls.Add(this.btnDuckOpen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUp);
            this.Name = "Form1";
            this.Text = "设定页面demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnDuckOpen;
        private Button btnDuckClose;
        private Button btnSave;
        private Label lbl_H;
        private Label lbl_V;
        //private hydrant panel1;

    }
}

