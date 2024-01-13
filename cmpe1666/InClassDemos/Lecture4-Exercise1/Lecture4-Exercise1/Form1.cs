using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture4_Exercise1
{
    public partial class Form1 : Form
    {
        List<string> names;
        public Form1()
        {
            InitializeComponent();
            names= new List<string>();
        }

        private void UI_AddToList_Btn_Click(object sender, EventArgs e)
        {
            names.Add(UI_Name_Tbx.Text);
            UI_Name_Tbx.Clear();

            if (names.Count >= 10)
            {
                UI_AddToList_Btn.Enabled = false;
                UI_AddToListBox_Btn.Enabled = true;
            }

        }

        private void UI_AddToListBox_Btn_Click(object sender, EventArgs e)
        {
            foreach (string name in names)
                UI_Names_Lbx.Items.Add(name);
        }
    }
}
