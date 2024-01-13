using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Select_Diffculty : Form
    {
        public int Difficulty
        {
            get
            {
                int difficulty = 3;
                if (UI_easy_radiobtn.Checked)
                {
                    difficulty = 3;
                }
                else if (UI_medium_radioBtn.Checked)
                {
                    difficulty = 4;
                }
                else if (UI_hard_radioBtn.Checked)
                {
                    difficulty = 5;
                }
                
                return difficulty;
            }
            set { Difficulty = value; }
        }

        public Select_Diffculty()
        {
            InitializeComponent();
        }

        private void UI_ok_btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void UI_Cancel_btn_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }
    }
}
