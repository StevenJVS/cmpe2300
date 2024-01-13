using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture8_Demo3
{
    public partial class Form1 : Form
    {
        ModelessDialogForm dlg = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void CallBackTextChanged(string str)
        {
            UI_DialogText_Lbl.Text = str;
        }

        private void CallBackFormClosing()
        {
            UI_ShowDialog_Cbx.Checked = false;
        }

        private void UI_ShowDialog_Cbx_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_ShowDialog_Cbx.Checked)
            {
                if (dlg == null)
                {
                    dlg = new ModelessDialogForm();
                    dlg._dTextChanged = CallBackTextChanged;
                    dlg._dFormClosing = CallBackFormClosing;
                }
                dlg.Show();
            }
            else dlg.Hide();
        }
    }
}
