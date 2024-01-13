using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture7Demo1_A02
{
    public partial class ModalDialogForm : Form
    {
        public string pUserName
        {
            get { return tbxInput.Text; }
            set { tbxInput.Text = value; }
        }
        public ModalDialogForm()
        {
            InitializeComponent();
        }

        private void UI_OK_Btn_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.OK;
        }

        private void UI_Cancel_Btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
