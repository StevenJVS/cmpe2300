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
    //delegate fro sending notifications to the main form
    public delegate void delVoidString(string s);
    public delegate void delVoidVoid();
    public partial class ModelessDialogForm : Form
    {
        //delegate reference will contain the callback
        public delVoidString _dTextChanged = null;
        public delVoidVoid _dFormClosing = null;
        public ModelessDialogForm()
        {
            InitializeComponent();
        }

        private void UI_Input_Lbl_TextChanged(object sender, EventArgs e)
        {
            if(_dTextChanged != null)
            _dTextChanged.Invoke(UI_Input_Tbx.Text);
        }

        private void ModelessDialogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (null != _dFormClosing)
                {
                    if (_dFormClosing != null) 
                    { 
                    _dFormClosing.Invoke();
                    }

                    e.Cancel = true;
                    Hide();
                }
            }
        }
    }
}
