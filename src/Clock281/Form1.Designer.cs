namespace Clock281
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menu_str2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_str1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_str3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_resize = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Color = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_font = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_defult = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_recordMode = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_CountDownMode = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ReCountDown = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_SetCountTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.分ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.分ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutClock281 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_UP = new System.Windows.Forms.Button();
            this.btn_DOWN = new System.Windows.Forms.Button();
            this.btn_LEFT = new System.Windows.Forms.Button();
            this.btn_RIGHT = new System.Windows.Forms.Button();
            this.p_Resize = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.p_Resize.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ContextMenuStrip = this.contextMenuStrip1;
            this.label1.Font = new System.Drawing.Font("华文中宋", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "8888-88-88  88:88:88";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_str2,
            this.menu_str1,
            this.menu_str3,
            this.toolStripSeparator3,
            this.menu_refresh,
            this.toolStripSeparator1,
            this.menu_resize,
            this.menu_Color,
            this.menu_font,
            this.toolStripSeparator4,
            this.menu_defult,
            this.menu_recordMode,
            this.menu_CountDownMode,
            this.toolStripSeparator2,
            this.aboutClock281,
            this.exitXToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(259, 292);
            // 
            // menu_str2
            // 
            this.menu_str2.Name = "menu_str2";
            this.menu_str2.Size = new System.Drawing.Size(258, 22);
            this.menu_str2.Text = "yyyy-MM-dd HH:mm:ss Sunday";
            this.menu_str2.Click += new System.EventHandler(this.menu_str2_Click);
            // 
            // menu_str1
            // 
            this.menu_str1.Checked = true;
            this.menu_str1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menu_str1.Name = "menu_str1";
            this.menu_str1.Size = new System.Drawing.Size(258, 22);
            this.menu_str1.Text = "yyyy-MM-dd HH:mm:ss";
            this.menu_str1.Click += new System.EventHandler(this.menu_str1_Click);
            // 
            // menu_str3
            // 
            this.menu_str3.Name = "menu_str3";
            this.menu_str3.Size = new System.Drawing.Size(258, 22);
            this.menu_str3.Text = "yyyy年MM月dd日 HH:mm:ss";
            this.menu_str3.Click += new System.EventHandler(this.menu_str3_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(255, 6);
            // 
            // menu_refresh
            // 
            this.menu_refresh.Name = "menu_refresh";
            this.menu_refresh.Size = new System.Drawing.Size(258, 22);
            this.menu_refresh.Text = "刷新显示框";
            this.menu_refresh.Click += new System.EventHandler(this.menu_refresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(255, 6);
            // 
            // menu_resize
            // 
            this.menu_resize.Name = "menu_resize";
            this.menu_resize.ShowShortcutKeys = false;
            this.menu_resize.Size = new System.Drawing.Size(258, 22);
            this.menu_resize.Text = "调整大小";
            this.menu_resize.Click += new System.EventHandler(this.resizeRToolStripMenuItem_Click);
            // 
            // menu_Color
            // 
            this.menu_Color.Name = "menu_Color";
            this.menu_Color.Size = new System.Drawing.Size(258, 22);
            this.menu_Color.Text = "调整颜色";
            this.menu_Color.Click += new System.EventHandler(this.menu_Color_Click);
            // 
            // menu_font
            // 
            this.menu_font.Name = "menu_font";
            this.menu_font.Size = new System.Drawing.Size(258, 22);
            this.menu_font.Text = "调整字体";
            this.menu_font.Click += new System.EventHandler(this.menu_font_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(255, 6);
            // 
            // menu_defult
            // 
            this.menu_defult.Name = "menu_defult";
            this.menu_defult.Size = new System.Drawing.Size(258, 22);
            this.menu_defult.Text = "默认设置";
            this.menu_defult.Click += new System.EventHandler(this.menu_defult_Click);
            // 
            // menu_recordMode
            // 
            this.menu_recordMode.Name = "menu_recordMode";
            this.menu_recordMode.Size = new System.Drawing.Size(258, 22);
            this.menu_recordMode.Text = "取证模式";
            this.menu_recordMode.Click += new System.EventHandler(this.menu_recordMode_Click);
            // 
            // menu_CountDownMode
            // 
            this.menu_CountDownMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ReCountDown,
            this.menu_SetCountTime});
            this.menu_CountDownMode.Name = "menu_CountDownMode";
            this.menu_CountDownMode.Size = new System.Drawing.Size(258, 22);
            this.menu_CountDownMode.Text = "倒计时模式";
            this.menu_CountDownMode.Click += new System.EventHandler(this.menu_CountDownMode_Click);
            // 
            // menu_ReCountDown
            // 
            this.menu_ReCountDown.Name = "menu_ReCountDown";
            this.menu_ReCountDown.Size = new System.Drawing.Size(152, 22);
            this.menu_ReCountDown.Text = "重新计时";
            this.menu_ReCountDown.Click += new System.EventHandler(this.menu_ReCountDown_Click);
            // 
            // menu_SetCountTime
            // 
            this.menu_SetCountTime.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.分ToolStripMenuItem,
            this.分ToolStripMenuItem1,
            this.分ToolStripMenuItem2});
            this.menu_SetCountTime.Name = "menu_SetCountTime";
            this.menu_SetCountTime.Size = new System.Drawing.Size(152, 22);
            this.menu_SetCountTime.Text = "设置计时数量";
            this.menu_SetCountTime.Click += new System.EventHandler(this.menu_SetCountTime_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem2.Text = "05分";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // 分ToolStripMenuItem
            // 
            this.分ToolStripMenuItem.Name = "分ToolStripMenuItem";
            this.分ToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.分ToolStripMenuItem.Text = "10分";
            this.分ToolStripMenuItem.Click += new System.EventHandler(this.分ToolStripMenuItem_Click);
            // 
            // 分ToolStripMenuItem1
            // 
            this.分ToolStripMenuItem1.Name = "分ToolStripMenuItem1";
            this.分ToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.分ToolStripMenuItem1.Text = "15分";
            this.分ToolStripMenuItem1.Click += new System.EventHandler(this.分ToolStripMenuItem1_Click);
            // 
            // 分ToolStripMenuItem2
            // 
            this.分ToolStripMenuItem2.Name = "分ToolStripMenuItem2";
            this.分ToolStripMenuItem2.Size = new System.Drawing.Size(102, 22);
            this.分ToolStripMenuItem2.Text = "20分";
            this.分ToolStripMenuItem2.Click += new System.EventHandler(this.分ToolStripMenuItem2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(255, 6);
            // 
            // aboutClock281
            // 
            this.aboutClock281.Name = "aboutClock281";
            this.aboutClock281.ShowShortcutKeys = false;
            this.aboutClock281.Size = new System.Drawing.Size(258, 22);
            this.aboutClock281.Text = "关于 Clock281";
            this.aboutClock281.Click += new System.EventHandler(this.aboutClock281_Click);
            // 
            // exitXToolStripMenuItem
            // 
            this.exitXToolStripMenuItem.Name = "exitXToolStripMenuItem";
            this.exitXToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.exitXToolStripMenuItem.Text = "退出";
            this.exitXToolStripMenuItem.Click += new System.EventHandler(this.exitXToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_UP
            // 
            this.btn_UP.Location = new System.Drawing.Point(-1, 1);
            this.btn_UP.Name = "btn_UP";
            this.btn_UP.Size = new System.Drawing.Size(27, 23);
            this.btn_UP.TabIndex = 1;
            this.btn_UP.Text = "+H";
            this.btn_UP.UseVisualStyleBackColor = true;
            this.btn_UP.Click += new System.EventHandler(this.btn_UP_Click);
            // 
            // btn_DOWN
            // 
            this.btn_DOWN.Location = new System.Drawing.Point(-1, 22);
            this.btn_DOWN.Name = "btn_DOWN";
            this.btn_DOWN.Size = new System.Drawing.Size(27, 23);
            this.btn_DOWN.TabIndex = 2;
            this.btn_DOWN.Text = "-H";
            this.btn_DOWN.UseVisualStyleBackColor = true;
            this.btn_DOWN.Click += new System.EventHandler(this.btn_DOWN_Click);
            // 
            // btn_LEFT
            // 
            this.btn_LEFT.Location = new System.Drawing.Point(24, 22);
            this.btn_LEFT.Name = "btn_LEFT";
            this.btn_LEFT.Size = new System.Drawing.Size(27, 23);
            this.btn_LEFT.TabIndex = 3;
            this.btn_LEFT.Text = "-W";
            this.btn_LEFT.UseVisualStyleBackColor = true;
            this.btn_LEFT.Click += new System.EventHandler(this.btn_LEFT_Click);
            // 
            // btn_RIGHT
            // 
            this.btn_RIGHT.Location = new System.Drawing.Point(24, 1);
            this.btn_RIGHT.Name = "btn_RIGHT";
            this.btn_RIGHT.Size = new System.Drawing.Size(27, 23);
            this.btn_RIGHT.TabIndex = 4;
            this.btn_RIGHT.Text = "+W";
            this.btn_RIGHT.UseVisualStyleBackColor = true;
            this.btn_RIGHT.Click += new System.EventHandler(this.btn_RIGHT_Click);
            // 
            // p_Resize
            // 
            this.p_Resize.BackColor = System.Drawing.Color.Transparent;
            this.p_Resize.Controls.Add(this.btn_UP);
            this.p_Resize.Controls.Add(this.btn_RIGHT);
            this.p_Resize.Controls.Add(this.btn_DOWN);
            this.p_Resize.Controls.Add(this.btn_LEFT);
            this.p_Resize.Location = new System.Drawing.Point(1, 2);
            this.p_Resize.Name = "p_Resize";
            this.p_Resize.Size = new System.Drawing.Size(51, 45);
            this.p_Resize.TabIndex = 5;
            this.p_Resize.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1280, 145);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.p_Resize);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            this.p_Resize.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_resize;
        private System.Windows.Forms.Button btn_UP;
        private System.Windows.Forms.Button btn_DOWN;
        private System.Windows.Forms.Button btn_LEFT;
        private System.Windows.Forms.Button btn_RIGHT;
        private System.Windows.Forms.Panel p_Resize;
        private System.Windows.Forms.ToolStripMenuItem aboutClock281;
        private System.Windows.Forms.ToolStripMenuItem menu_str2;
        private System.Windows.Forms.ToolStripMenuItem menu_str1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menu_refresh;
        private System.Windows.Forms.ToolStripMenuItem menu_Color;
        private System.Windows.Forms.ToolStripMenuItem menu_font;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menu_defult;
        private System.Windows.Forms.ToolStripMenuItem menu_CountDownMode;
        private System.Windows.Forms.ToolStripMenuItem menu_ReCountDown;
        private System.Windows.Forms.ToolStripMenuItem menu_SetCountTime;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 分ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 分ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menu_str3;
        private System.Windows.Forms.ToolStripMenuItem menu_recordMode;
    }
}

