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
{   public delegate void delVoidString(string str);
    public delegate void delVoidVoid();
    public partial class ModelessDialogForm : Form
    {   public delVoidString _dTextChanged=null;
        public delVoidVoid _dFormClosing = null;
        public ModelessDialogForm()
        {
            InitializeComponent();
        }

        private void UI_Input_Tbx_TextChanged(object sender, EventArgs e)
        {
            if (_dTextChanged != null)
               _dTextChanged(UI_Input_Tbx.Text);
        }

        private void ModelessDialogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //If the form is being closed by the user- we can intercept the action
            //and hide the form instead of destroying it
            if (e.CloseReason == CloseReason.UserClosing)
            {
                //We first verify that the delegate is not null before invoking it
                if (_dFormClosing != null)
                    _dFormClosing();

                //Cancel the normal closing event
                e.Cancel = true;


                Hide(); //Hide the form instead of destroying it.
            }

        }
    }
}
