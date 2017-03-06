using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clock281
{
    public partial class Form2_Settings : Form
    {
        public Form2_Settings()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            TSP = new TimeSpan((int)nud_Hour.Value, (int)nud_Min.Value, (int)nud_Sec.Value);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        public TimeSpan TSP;


    }
}
