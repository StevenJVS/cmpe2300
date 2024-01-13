//Steven Santiago
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
    public delegate void delVoidVoid();//delegate to call in main
    public partial class Animationdialog: Form
    {
        public delVoidVoid _dFormClosing = null;
        public int AnimationSpeed
        {
            get
            {
                //return track bar value to main
                return UI_trackbar.Value;
            }
            set
            {
                //set trackbar value from main
                UI_trackbar.Value = value;
            }
        }
        public Animationdialog()
        {
            InitializeComponent();
        }
        //user closes window
        private void Animationdialog_FormClosing(object sender, FormClosingEventArgs e)
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
