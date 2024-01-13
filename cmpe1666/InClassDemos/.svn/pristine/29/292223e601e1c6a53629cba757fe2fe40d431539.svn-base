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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetName_Click(object sender, EventArgs e)
        {
            ModalDialogForm dialog = new ModalDialogForm();

            dialog.pUserName = "Default:";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //Code for actions when the Modal Dialog Form is closed with "OK"
                lblResult.Text=$"The name given was: {dialog.pUserName}";
            }
            else
            {
                MessageBox.Show("The Modal Form was Cancelled");
            }
        }
    }
}
