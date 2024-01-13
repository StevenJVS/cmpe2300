using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeExam3
{
    public partial class Form1 : Form
    {
        ModelessDialog md = null;
        public Form1()
        {
            InitializeComponent();
            md = new ModelessDialog();
        }

        private void Ui_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Ui_checkbox.Checked)
            {
                md.Show();
                md._formclosing = new delvoid(Formclosing);
                UI_textbox.Text = md.value.ToString();
            } 
            else 
            { 
                md.Hide(); 
            }
        }
        private void Formclosing()
        {
            Ui_checkbox.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
