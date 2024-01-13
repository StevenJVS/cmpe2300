using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture2_Exercise7
{     
    public partial class Form1 : Form
    {
        int count = 0;
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            Text=$"count is: {count.ToString()} - Milliseconds elapsed: {sw.ElapsedMilliseconds}";

            if (count % 20 == 0)
                UI_DisplayCount_Lbx.Items.Add($"Tick Number {count}");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sw.Start();
        }

        private void UI_Stop_Btn_Click(object sender, EventArgs e)
        {
            sw.Stop();  
        }
    }
}
