using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Lecture11Exercise9
{
    public partial class Form1 : Form
    {  List<string> nameList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_Save_Btn_Click(object sender, EventArgs e)
        {
            nameList.Add(UI_Name_Tbx.Text);
            UI_Name_Tbx.Clear();
        }

        private void UI_AddToListBox_Btn_Click(object sender, EventArgs e)
        {
            Thread T1 = new Thread(AddNamesToListBox);
            T1.IsBackground = true;
            T1.Start();
        }

        private void AddNamesToListBox()
        {
            Action<string> writeToListBox = new Action<string>(s => UI_Name_Lbx.Items.Add(s));
            foreach(string name in nameList)
            {
                Invoke(writeToListBox, name);
                Thread.Sleep(100);
            }
        }
    }
}
