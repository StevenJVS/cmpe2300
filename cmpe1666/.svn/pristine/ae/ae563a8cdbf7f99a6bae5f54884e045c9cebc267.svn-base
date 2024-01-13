using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lists
{
    public partial class Form1 : Form

    {
        List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();

        }

        private void UI_button1_Click(object sender, EventArgs e)
        {
            list.Add(UI_textbox.Text);
            UI_textbox.Clear();

            if (list.Count >= 10)
            {
                UI_button1.Enabled = false;
                UI_button2.Enabled = true;
            }
        }

        private void UI_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UI_button2_Click(object sender, EventArgs e)
        {
            foreach(string item in list)
                UI_listbox.Items.Add(item);
        }
    }
}
