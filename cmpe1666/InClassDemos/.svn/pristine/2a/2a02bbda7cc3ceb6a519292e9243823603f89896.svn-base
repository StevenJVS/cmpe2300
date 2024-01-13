using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture10Exercise1
{
    public partial class Form1 : Form
    { Queue<string> nameQueue = new Queue<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_AddName_Btn_Click(object sender, EventArgs e)
        {
            nameQueue.Enqueue(UI_Name_Tbx.Text);
            UI_Name_Tbx.Clear();
        }

        private void UI_RemoveName_btn_Click(object sender, EventArgs e)
        {
            string name = nameQueue.Dequeue();
            MessageBox.Show($"Name Removed is: {name}");
        }

        private void UI_DisplayQueue_Btn_Click(object sender, EventArgs e)
        {
            UI_DisplayQueue_Lbx.Items.Clear();

            foreach(string item in nameQueue)  
                UI_DisplayQueue_Lbx.Items.Add(item);
        }
    }
}
