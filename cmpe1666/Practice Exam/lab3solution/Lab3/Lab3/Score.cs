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
    public partial class Score : Form
    {
        public int score
        {
            get
            {
                int score = 0;
                int.TryParse(UI_score_lbl.Text, out score);
                return score;
            }
            set
            {
                
                UI_score_lbl.Text = value.ToString();
            }
        }


        public Score()
        {
            InitializeComponent();
        }
    }
}
