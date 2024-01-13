//***********************************************************************************
//Your Name Here Assignment #
//****************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ica3
{
    public partial class Form1 : Form
    {            
        //create a stopwatch
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

        //counter for splits
        int count = 0;
        //to compare string split
        string itemlist = "";
        //********************************************************************************************
        //Method: public Form1
        //Purpose: Loads form and shows stops the timer at 0
        //Parameters:
        //object sender
        //EventArgs e
        //*********************************************************************************************
        public Form1()
        {
            InitializeComponent();
            sw.Stop();
           
        }
        //********************************************************************************************
        //Method: private string Display
        //Purpose: Capture wanted display
        //Returns: captured string
        //*********************************************************************************************

        private string Display()
        {
            //create timespan format
            TimeSpan ElapseTime;
            ElapseTime = sw.Elapsed;

            //display time span in milliseconds
            string milli = $"{ElapseTime.Milliseconds / 10}";
            string display;

            //store string display
            display = $"({count}){ElapseTime.ToString().Substring(0,8)}:{milli}"; 

            //return display
            return display;

        }
        //********************************************************************************************
        //Method: static private void timer1_Tick
        //Purpose: Display timer to user
        //Parameters:
        //object sender
        //EventArgs e
        //*********************************************************************************************
        private void timer1_Tick(object sender, EventArgs e)
        {
            //prints ticking time to label
            UI_label1.Text= Display();
        }
        //********************************************************************************************
        //Method: private void UI_start_Click
        //Purpose: Starts timer
        //Parameters:
        //object sender
        //EventArgs e
        //*********************************************************************************************
        private void UI_start_Click(object sender, EventArgs e)
        {
            //start stop watch
            sw.Start();
        }
        //********************************************************************************************
        //Method: private void UI_stop_Click
        //Purpose: Stops timer
        //Parameters:
        //object sender
        //EventArgs e
        //*********************************************************************************************
        private void UI_stop_Click(object sender, EventArgs e)
        {
            //stops stop watch
            sw.Stop();
        }
        //********************************************************************************************
        //Method: private void UI_split_Click
        //Purpose: Captures spllit time
        //Parameters:
        //object sender
        //EventArgs e
        //*********************************************************************************************
        private void UI_split_Click(object sender, EventArgs e)
        {
        // stores captured time
         string display = Display();

            //compares captured time to current time
            if (display == itemlist)
            {
                //if time is identical. do nothing
            }
            else
            {
                //if time is not a duplicate. Add time to list
                listBox1.Items.Add(display);
                //add counter
                count++;

            }
            //store item in list
            itemlist = Display();

        }
        //********************************************************************************************
        //Method: private void UI_Reset_Click
        //Purpose: Reset timer
        //Parameters:
        //object sender
        //EventArgs e
        //*********************************************************************************************
        private void UI_Reset_Click(object sender, EventArgs e)
        {
            //reset stop watch
            sw.Reset();
            //clear list box items
            listBox1.Items.Clear();
            //reset counter to 0
            count= 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
