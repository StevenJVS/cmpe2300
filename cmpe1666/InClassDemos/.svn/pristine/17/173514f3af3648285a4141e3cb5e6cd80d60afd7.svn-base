using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture8Demo3
{
    public partial class Form1 : Form
    {
        ModelessDialogForm dlg = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_ShowDialog_Cbx_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_ShowDialog_Cbx.Checked)
            {
                if (dlg == null)
                {
                    dlg = new ModelessDialogForm();
                    dlg._dTextChanged = new delVoidString(CallBackTextChanged);
                    dlg._dFormClosing= new delVoidVoid(CallBackFormClosing);
                }
                dlg.Show();
            }
            else
                dlg.Hide();
        }

        private void CallBackTextChanged(string s1)
        {
            UI_DialogText_Lbl.Text = s1;
        }

        private void CallBackFormClosing()
        {
            UI_ShowDialog_Cbx.Checked = false;
        }
    }
}
