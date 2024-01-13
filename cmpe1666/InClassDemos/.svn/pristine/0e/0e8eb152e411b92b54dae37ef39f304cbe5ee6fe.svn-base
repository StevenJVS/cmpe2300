using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture2_Exercise2
{
    public partial class Form1 : Form
    {
        int num_times = 0;
        int toggle = 0;

        public Form1()
        {
            InitializeComponent();
            Text = "This is a nice form";

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            num_times++;
            if (toggle == 0)
            {
                Text = $"The mouse has been clicked {num_times} times";
                toggle = 1;
            }
            else
            {
                Text = "This is a nice form";
                toggle = 0;
            }
        }
    }
}
