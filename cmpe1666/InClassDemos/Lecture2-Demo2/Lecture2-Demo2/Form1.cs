using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture2_Demo2
{
    public partial class Form1 : Form
    {
        string myString = "This is my First Form";
        public Form1()
        {
            InitializeComponent();
            Text = myString;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            Text = "The mouse has been double-clicked";
        }
    }
}
