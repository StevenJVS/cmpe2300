//Steven Santiago
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class HighScoredialog : Form
    {
        
        public int score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
            }
        }
        public HighScoredialog()
        {
            InitializeComponent();
        }

        private void UI_cancel_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;//user cancel input
        }

        private void UI_Ok_Click(object sender, EventArgs e)
        {
            //stream writer
            StreamWriter sw = new StreamWriter("Text.txt");
            sw.WriteLine(UI_textbox.Text+$": {score}");//write to text file
            DialogResult= DialogResult.OK;//result ok
        }
    }
}
