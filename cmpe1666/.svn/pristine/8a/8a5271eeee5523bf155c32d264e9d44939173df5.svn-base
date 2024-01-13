using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Difficulty : Form
    {
        int num;
        public int difficulty
        {
            get
            {
                return num;
            }
        }
        public Difficulty()
        {
            InitializeComponent();
        }

        private void UI_OK_Click(object sender, EventArgs e)
        {
            if(UI_easy.Checked)
            {
                num = 3;
            }
            if(UI_medium.Checked)
            {
                num = 4;
            }
            if(UI_hard.Checked)
            {
                num= 5;
            }
            DialogResult= DialogResult.OK;
        }

        private void UI_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }
    }
}
