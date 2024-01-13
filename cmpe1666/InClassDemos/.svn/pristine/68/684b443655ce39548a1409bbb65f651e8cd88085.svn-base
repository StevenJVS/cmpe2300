using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture8_Exercise4
{  public delegate void delColor(int R, int G, int B);
   public delegate void delOpacity(int opac);
    public partial class ModelessDialog : Form
    {
        public delColor _dChangeColor = null;
        public delOpacity _dOpacity = null;
        public ModelessDialog()
        {
            InitializeComponent();
        }

        private void UI_Radio_CheckedChanged(object sender, EventArgs e)
        {
              if (_dChangeColor != null)
            {
                if (UI_Red_Radio.Checked)
                    _dChangeColor(255, 0, 0);
                else if (UI_Purple_Radio.Checked)
                    _dChangeColor(255, 0, 255);
                else if (UI_Yellow_Radio.Checked)
                    _dChangeColor(255, 255, 0);
            }
        }

        private void UI_OP_Trackbar_ValueChanged(object sender, EventArgs e)
        {
           _dOpacity(UI_OP_Trackbar.Value);
        }
    }
}
