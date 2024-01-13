using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinarySearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UI_buttonAddtoList_Click(object sender, EventArgs e)
        {
            int num;
            int.TryParse(UI_Value.Text, out num);
            UI_UnsortedData.Items.Add(num);
        }

        private void UI_buttonSortData_Click(object sender, EventArgs e)
        {
            UI_UnsortedData.Sorted = true;
            foreach (int i in UI_UnsortedData.Items)
                UI_UnsortedData.Items.Add(i);
        }

        private void UI_buttonSearchValue_Click(object sender, EventArgs e)
        {
            bool success;
            int x;

        }
    }
}
