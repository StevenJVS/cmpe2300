using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Lecture9_Demo3
{ 
    public partial class Form1 : Form
    {
        public int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_Count_Btn_Click(object sender, EventArgs e)
        {
            UI_Count_Lbl.Text = $"The button has been clicked {++count} times";
        }

        public void FindSine()
        {
            for (double x = 0; x < 90; x = x + 0.1)
            {
                double rad = Math.PI * x / 180;
                double sineValue = Math.Sin(rad);
                listBox1.Items.Add($"{x:F2} degrees = {rad:F4} radians. Sine={sineValue:F4}");
                Thread.Sleep(50);
            }
        }

        private void UI_Comput_Btn_Click(object sender, EventArgs e)
        {
           FindSine();
        }
    }
}
