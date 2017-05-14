using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clock281
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string str1 = "yyyy-MM-dd  HH:mm:ss";
        static string str2 = "yyyy-MM-dd  HH:mm:ss  ddd";
        static string str3 = "yyyy年MM月dd日 HH:mm:ss";
        string fontFamliyName = "华文中宋";

        TimeSpan tsp = new TimeSpan(0,5, 0);
        TimeSpan tsp_set = new TimeSpan(0, 5, 0);

        FontStyle fontstyle = FontStyle.Bold;
        Color defultColor = Color.Red;
        bool helper = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (menu_str1.Checked)
            {
                label1.Text = System.DateTime.Now.ToString(str1);
            }
            if (menu_str2.Checked)
            {
                label1.Text = System.DateTime.Now.ToString(str2);
            }
            if (menu_str3.Checked)
            {
                label1.Text = System.DateTime.Now.ToString(str3);
            }
            if (!helper)
            {
                helper = true;
                //aboutClock281_Click(sender, e);
            }
            if (menu_CountDownMode.Checked)
            {
                if (tsp != TimeSpan.Zero)
                {
                    tsp = tsp.Add(TimeSpan.FromSeconds(-1));
                }
                label1.Text = tsp.ToString();
            }

            GC.Collect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        bool leftMouseFlag;
        Point mouseOff;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //边框是1所以都减1
                mouseOff = new Point(-e.X - 1, -e.Y - 1);
                leftMouseFlag = true;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftMouseFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);
                Location = mouseSet;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftMouseFlag)
            {
                leftMouseFlag = false;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //边框是1所以都减1
                mouseOff = new Point(-e.X - label1.Location.X, -e.Y - label1.Location.Y);
                leftMouseFlag = true;
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftMouseFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);
                Location = mouseSet;
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftMouseFlag)
            {
                leftMouseFlag = false;
            }
        }

        private void exitXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void resizeRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (p_Resize.Visible == true)
            {
                p_Resize.Visible = false;
                menu_resize.Checked = false;
            }
            else
            {
                p_Resize.Visible = true;
                menu_resize.Checked = true;
            }
        }

        private void btn_UP_Click(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, this.Size.Height + 10);
            //label1.Font = new System.Drawing.Font("华文中宋", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        }

        private void btn_DOWN_Click(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, this.Size.Height - 10);
        }

        private void btn_RIGHT_Click(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width + 10, this.Size.Height );
        }

        private void btn_LEFT_Click(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width - 10, this.Size.Height);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            makeLabelFix();
        }
        
        private void makeLabelFix()
        {
            float f = 1;
            label1.Font = new System.Drawing.Font(fontFamliyName, f, fontstyle, System.Drawing.GraphicsUnit.Point, ((byte)(1)));
            while (label1.Size.Height <= this.Size.Height*0.95 && label1.Size.Width <= this.Size.Width*0.95 )//逻辑满足待修正！
            {
                label1.Font = new System.Drawing.Font(fontFamliyName, f, fontstyle, System.Drawing.GraphicsUnit.Point, ((byte)(1)));
                f = f + 3 ;
            }

            int labelLocationX = (this.Size.Width - label1.Size.Width) / 2;
            int labelLocationY = (int)((this.Size.Height - label1.Size.Height) / 2 * 1.15);
            label1.Location = new Point(labelLocationX,labelLocationY);
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch(keyData)
            {
                case Keys.Up:
                    this.Size = new Size(this.Size.Width, this.Size.Height - 5);
                    break;
                case Keys.Down:
                    this.Size = new Size(this.Size.Width, this.Size.Height + 5);
                    break;
                case Keys.Left:
                    this.Size = new Size(this.Size.Width - 20, this.Size.Height);
                    break;
                case Keys.Right:
                    this.Size = new Size(this.Size.Width + 20, this.Size.Height);
                    break;
                case Keys.Up | Keys.Control:
                    this.Size = new Size(this.Size.Width, this.Size.Height - 20);
                    break;
                case Keys.Down | Keys.Control:
                    this.Size = new Size(this.Size.Width, this.Size.Height + 20);
                    break;
                case Keys.Left | Keys.Control:
                    this.Size = new Size(this.Size.Width - 80, this.Size.Height);
                    break;
                case Keys.Right | Keys.Control:
                    this.Size = new Size(this.Size.Width + 80, this.Size.Height);
                    break;
                case Keys.I | Keys.Control:
                    MessageBox.Show(this.Size.ToString());
                    break;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void menu_str1_Click(object sender, EventArgs e)
        {
            if (menu_str1.Checked==false)
            {
                menu_str1.Checked = true;
                menu_str2.Checked = false;
            }
  //          makeLabelFix();
            
        }

        private void menu_str2_Click(object sender, EventArgs e)
        {
            
            if (menu_str2.Checked==false)
            {
                menu_str2.Checked = true;
                menu_str1.Checked = false;
            }

//            makeLabelFix();
            
        }

        private void aboutClock281_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clock 281\r\n\r\n1.用键盘的上下左右来调整大小，鼠标拖动来调整位置。\r\n\r\n2.右键点击出现菜单，可以进一步调整样式。\r\n\r\n3.作者：ShenJian@281 日期:2013-10-18\r\n2017年5月14日新增取证模式", "关于本程序 Clock281 v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menu_refresh_Click(object sender, EventArgs e)
        {
            makeLabelFix();
        }

        private void menu_Color_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog()== System.Windows.Forms.DialogResult.OK)
                {
                    this.label1.ForeColor = cd.Color;
                }
            }
        }

        private void menu_font_Click(object sender, EventArgs e)
        {
            using (FontDialog fd = new FontDialog())
            {
                fd.Font = new Font(fontFamliyName,label1.Font.Size,fontstyle);
                if (fd.ShowDialog()== System.Windows.Forms.DialogResult.OK)
                {
                    fontFamliyName = fd.Font.FontFamily.Name;
                    if(fd.Font.Bold)
                    {
                        fontstyle = FontStyle.Bold;
                    }
                    else
                    {
                        fontstyle = FontStyle.Regular;
                    }
                    this.makeLabelFix();
                }
            }
        }

        private void menu_defult_Click(object sender, EventArgs e)
        {
            fontstyle = FontStyle.Bold;
            fontFamliyName = "华文中宋";
            this.label1.ForeColor = defultColor;
            this.Size = new Size(1280, 145);
        }
        private void menu_recordMode_Click(object sender, EventArgs e)
        {
            fontstyle = FontStyle.Bold;
            fontFamliyName = "华文中宋";
            this.label1.ForeColor = Color.Lime;
            this.Size = new Size(300, 30);
            int x =(SystemInformation.WorkingArea.Size.Width / 2 - 150);
            this.Location = new Point(x, 0);

        }

        private void menu_CountDownMode_Click(object sender, EventArgs e)
        {
            if (menu_CountDownMode.Checked)
            {
                menu_CountDownMode.Checked = false;
            }
            else
            {
                menu_CountDownMode.Checked = true;
            }
        }

        private void menu_SetCountTime_Click(object sender, EventArgs e)
        {
            var f2 = new Form2_Settings();
            if (f2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { 
                 tsp_set = f2.TSP;
            }
        }

        private void menu_ReCountDown_Click(object sender, EventArgs e)
        {
            tsp = tsp_set;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tsp_set = new TimeSpan(0, 5, 0);
        }

        private void 分ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsp_set = new TimeSpan(0, 10, 0);
        }

        private void 分ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tsp_set = new TimeSpan(0, 15, 0);
        }

        private void 分ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tsp_set = new TimeSpan(0, 20, 0);
        }

        private void menu_str3_Click(object sender, EventArgs e)
        {
            menu_str3.Checked = true;
            menu_str2.Checked = false;
            menu_str1.Checked = false;
        }


    }
}
