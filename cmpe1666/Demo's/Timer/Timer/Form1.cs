﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        new 
        int count;
        int count2;
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
        public Form1()
        {
            InitializeComponent();
            count = 0;
            count2 = 0;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            count++;
            Text = "count is " + count + "Milliseconds ellapse: " + sw.ElapsedMilliseconds.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sw.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sw.Start();
        }

        private void UI_listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (1 != count / 20)
                count2++;
            {
                Text = count2.ToString();
            }
        }
    }
}
