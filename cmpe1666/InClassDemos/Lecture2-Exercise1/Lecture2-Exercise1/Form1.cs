using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture2_Exercise1
{
    public partial class Form1 : Form
    {
        int num_times = 0;
        public Form1()
        {
            InitializeComponent();
            Text = "The form has been double-clicked 0 time";
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            num_times++;
            Text = $"The form has been double-clicked {num_times} times";
        }
    }
}
