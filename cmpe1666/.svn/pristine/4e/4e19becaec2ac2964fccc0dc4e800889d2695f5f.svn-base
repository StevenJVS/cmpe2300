using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture7demo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetName_Click(object sender, EventArgs e)
        {
            ModelDialogForm dialog = new ModelDialogForm();

            dialog.pUsername = "enter use name here...";

            if (DialogResult.OK == dialog.ShowDialog())
            {


                lblResult.Text = dialog.pUsername;
            }
            else
            {
                MessageBox.Show("Closed with Cancel or X button.");
            }
        }
    }
}
