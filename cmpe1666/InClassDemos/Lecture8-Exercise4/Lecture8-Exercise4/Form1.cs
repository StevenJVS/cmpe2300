using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture8_Exercise4
{
    public partial class Form1 : Form
    {
        private ModelessDialog dlg = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_ShowDialog_Btn_Click(object sender, EventArgs e)
        {
            if (dlg == null)
            {
                dlg = new ModelessDialog();
                dlg._dChangeColor = CallBackChangeColor;
                dlg._dOpacity = CallBackOpacity;
            }

            dlg.Show();

        }

        private void UI_HideDialog_Btn_Click(object sender, EventArgs e)
        {
            if (dlg != null)
                dlg.Hide();
        }

        private void CallBackChangeColor(int Red, int Green, int Blue)
        {
            this.BackColor= Color.FromArgb(Red, Green, Blue);
        }

        private void CallBackOpacity(int Value)
        {
            this.Opacity = (double)Value/25;
        }
    }
}
