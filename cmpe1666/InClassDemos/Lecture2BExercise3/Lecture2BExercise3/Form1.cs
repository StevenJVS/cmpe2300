using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture2BExercise3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_ClickMe_Btn_Click(object sender, EventArgs e)
        {
             
            MessageBox.Show($"The name given was: {UI_Name_Tbx.Text}");
        }
    }
}
