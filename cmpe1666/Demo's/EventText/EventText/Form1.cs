using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_textBox2_TextChanged(object sender, EventArgs e)
        {
            UI_textBox1.Text = UI_textBox2.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
