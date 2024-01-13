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
    public delegate void delVoid();// delegate to call in main
    public partial class Scoredialog : Form
    {
        public delVoid _dFormClosing = null;
        public int score
        {
            set
            {   //set score from main to label
                UI_Score.Text = $"{value}";
            }
        }
        public Scoredialog()
        {
            InitializeComponent();
        }     

        //when user clses the window
        private void Scoredialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (null != _dFormClosing)
                {
                    if (_dFormClosing != null)
                    {
                        //call method from main
                        _dFormClosing.Invoke();
                    }
                    //hide form
                    e.Cancel = true;
                    Hide();
                }
            }
        }
    }
}
