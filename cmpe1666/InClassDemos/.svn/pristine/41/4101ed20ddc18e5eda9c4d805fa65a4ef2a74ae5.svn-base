using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Lecture10_Exercise5
{
    public partial class Form1 : Form
    {
        LinkedList<string> myList;
       
    public Form1()
        {
            InitializeComponent();
            myList = new LinkedList<string>();

        }


        //Event Handler for Front button
        private void UI_AddToFront_btn_Click(object sender, EventArgs e)
        {
            Action<string> delAddFront = new Action<string>(SendToListFront);
            Invoke(delAddFront, UI_Name_tbx.Text);
            UI_Name_tbx.Clear();
        }

        //This method is invoked by the delegate in th event handler for the Add Front button
        private void SendToListFront(string str)
        {
            myList.AddFirst(str);
        }


        //Event handler for the Add TO Rear button
        private void UI_AddToRear_btn_Click(object sender, EventArgs e)
        {
            Action<string> delAddRear = new Action<string>(SendToListRear);

            Invoke(delAddRear, UI_Name_tbx.Text);
            UI_Name_tbx.Clear();
        }


        //This method is invoked by the delegate in the event hadler for the Add To Rear button
        private void SendToListRear(string str)
        {
            myList.AddLast(str);

        }

        //Event handler for the Display First button
        private void UI_DisplayFirst_btn_Click(object sender, EventArgs e)
        {
            Action<string> delDisplayFirst = new Action<string>(DisplayFront);
            Invoke(delDisplayFirst,myList.First());
        }

        //invoked by the delegate for the "Display First" burtton event handler
        private void DisplayFront(String str)
        {
            UI_First_tbx.Text = str;
        }


        //"Display Rear" button event handler
        private void UI_DisplayLast_btn_Click(object sender, EventArgs e)
        {
            Action<string> delDisplayLast = new Action<string>(DisplayRear);
            Invoke(delDisplayLast,myList.Last());
        }


        private void DisplayRear(String str)
        {
            UI_Rear_tbx.Text = str;
        }

                

       public void DisplayList()
        {
            Action<string> delDisplayName = new Action<string>(displayName);

            foreach(string val in myList)
            {
                Invoke(delDisplayName,val);
                Thread.Sleep(50);
            }
                
        }

        private void UI_DisplayWholeList_btn_Click(object sender, EventArgs e)
        {
            UI_Name_LB.Items.Clear();
            Thread myThread = new Thread(DisplayList);
            myThread.IsBackground = true;
            myThread.Start();
        }

        private void displayName(string str)
        {
            UI_Name_LB.Items.Add(str);
        }

        private void UI_RemoveName_btn_Click(object sender, EventArgs e)
        {
            Action<string> delRemoveName = new Action<string>(RemoveName);
            Invoke(delRemoveName, UI_Name_tbx.Text);
            UI_Name_tbx.Clear();

        }

        private void RemoveName(string str)
        {
            myList.Remove(str);
        }

    }
}
