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
    public partial class Animation_Speed : Form
    {
        public int AnimationSpeed
        {
            get
            {
                return UI_trackBar.Value;
            }
            set
            {
                UI_trackBar.Value = value;
            }
        }


        public Animation_Speed()
        {
            InitializeComponent();
        }

        private void UI_trackBar_Scroll(object sender, EventArgs e)
        {

        }
    }
}
