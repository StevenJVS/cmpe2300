using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lexture7_Exercise1
{
    public partial class ModalDlg : Form
    {  public int value1
        {
            get
            {
                int val;
                int.TryParse(UI_Input1_Tbx.Text, out val);
                return val;
            }
        }

        public int value2
        {
            get
            {
                int val;
                int.TryParse(UI_Input2_Tbx.Text, out val);
                return val;
            }
        }
        public ModalDlg()
        {
            InitializeComponent();
        }

        private void UI_OK_Btn_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.OK;
        }

        private void UI_Cancel_Btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
