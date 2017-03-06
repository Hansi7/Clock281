namespace Clock281
{
    partial class Form2_Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nud_Hour = new System.Windows.Forms.NumericUpDown();
            this.nud_Min = new System.Windows.Forms.NumericUpDown();
            this.nud_Sec = new System.Windows.Forms.NumericUpDown();
            this.btn_OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Sec)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_Hour
            // 
            this.nud_Hour.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nud_Hour.Location = new System.Drawing.Point(75, 22);
            this.nud_Hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nud_Hour.Name = "nud_Hour";
            this.nud_Hour.Size = new System.Drawing.Size(58, 29);
            this.nud_Hour.TabIndex = 0;
            // 
            // nud_Min
            // 
            this.nud_Min.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nud_Min.Location = new System.Drawing.Point(75, 57);
            this.nud_Min.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nud_Min.Name = "nud_Min";
            this.nud_Min.Size = new System.Drawing.Size(58, 29);
            this.nud_Min.TabIndex = 0;
            // 
            // nud_Sec
            // 
            this.nud_Sec.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nud_Sec.Location = new System.Drawing.Point(75, 92);
            this.nud_Sec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nud_Sec.Name = "nud_Sec";
            this.nud_Sec.Size = new System.Drawing.Size(58, 29);
            this.nud_Sec.TabIndex = 0;
            // 
            // btn_OK
            // 
            this.btn_OK.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OK.Location = new System.Drawing.Point(48, 127);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(85, 29);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "时";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(44, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "分";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(44, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "秒";
            // 
            // Form2_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 189);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.nud_Sec);
            this.Controls.Add(this.nud_Min);
            this.Controls.Add(this.nud_Hour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2_Settings";
            this.Text = "设置";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Sec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_Hour;
        private System.Windows.Forms.NumericUpDown nud_Min;
        private System.Windows.Forms.NumericUpDown nud_Sec;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}