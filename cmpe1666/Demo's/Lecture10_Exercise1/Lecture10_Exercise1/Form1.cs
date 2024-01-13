using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture10_Exercise1
{
    public partial class Form1 : Form
    {
        //create queue
        Queue<string> queue = new Queue<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_addnametoq_Click(object sender, EventArgs e)
        {
            queue.Enqueue(UI_textbox.Text);//add contents in list box to queue
            UI_textbox.Clear();//clear text box after its added
        }

        private void UI_removenamefromq_Click(object sender, EventArgs e)
        {
            string name = queue.Dequeue();//store the removed queue to a variable
            UI_textbox.Text = name;//display the remove queue to text box
        }

        private void UI_display_Click(object sender, EventArgs e)
        {
            UI_listbox.Items.Clear();//clear initial contents of list box
            foreach(string item in queue)
            {
                UI_listbox.Items.Add(item);//display contents in queue
            }
        }
    }
}
