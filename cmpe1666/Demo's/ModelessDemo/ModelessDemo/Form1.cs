using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelessDemo
{
    public partial class Form1 : Form
    {
        ModelessDialogForm dlg = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_ShowDialog_Chx_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_ShowDialog_Chx.Checked)
            {

                if (dlg == null)
                {
                    dlg = new ModelessDialogForm();
                    dlg._dTextChanged = new delVoidString(CallBackTextChaged);
                    dlg._dFormClosing = new delVoidVoid(CallBackFormClosing);
                }
                dlg.Show();
            }
            else
            {
                dlg.Hide();
            }
        }
        private void CallBackTextChaged(string str)
        {
            UI_DialogText_Lbl.Text = str;
        }
        private void CallBackFormClosing()
        {
            UI_ShowDialog_Chx.Checked = false;
        }
    }
}
