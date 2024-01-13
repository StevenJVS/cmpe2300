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

namespace Lecture9_Exercise2
{   
    
    public partial class Form1 : Form
    {  //Definition of delegate type for writing into listboxes
        public delegate void delVoidString(string S);

        //defining a delegate Type to clear the listboxes
        public delegate void delClear();


        //Create delegate refences for writing into each of the listboxes
        public delVoidString _delWriteSine = null;
        public delVoidString _delWriteCos = null;

        //Creating delegate references for clearing the listboxes
        private delClear _delClearSine=null;
        private delClear _delClearCos=null;

        private bool runSine;
        private bool runCos;

        public Form1()
        {
            InitializeComponent();
        }


       //The method FindSine() calculates the sine of all angles from 0 to 90 degrees
       // and uses a delegate to write the values in the left listbox in the form
       //Prior to running, it uses a delegate to clear up the listbox from the data of previous runs
        public void FindSine()
        {
            _delWriteSine = WriteToSineListBox;
            _delClearSine = ClearSineListBox;

            Invoke(_delClearSine);

            for (double x = 0; x < 90; x = x + 0.1)
            {
                if (runSine)
                {
                    double rad = Math.PI * x / 180;
                    double sineValue = Math.Sin(rad);
                    string str = $"{x:F2} degrees = {rad:F4} radians. Sine={sineValue:F4}";
                    Invoke(_delWriteSine, str);
                    Thread.Sleep(50);
                }
            }
        }

        //The method FindCos() calculates the sine of all angles from 0 to 90 degrees
        // and uses a delegate to write the values in the right listbox in the form
        //Prior to running, it uses a delegate to clear up the listbox from the data of previous runs
        public void FindCos()
        {
            _delWriteCos = WriteToCosListBox;
            _delClearCos= ClearCosListBox;   
            
            Invoke(_delClearCos);

           for (double x = 0; x < 90; x = x + 0.1)
            {
                if (runCos)
                {
                    double rad = Math.PI * x / 180;
                    double cosValue = Math.Cos(rad);
                    string str = $"{x:F2} degrees = {rad:F4} radians. Cos={cosValue:F4}";
                    Invoke(_delWriteCos, str);
                    Thread.Sleep(50);
                }
            }

        }

        //The methods below are used by delgates for writing into the listboxes or clearing
        //the listboxes
        private void WriteToSineListBox(string str)
        {
            UI_Sine_LB.Items.Add(str);
        }

        private void WriteToCosListBox(string str)
        {
            UI_Cos_LB.Items.Add(str);
        }

        private void UI_StopSine_btn_Click(object sender, EventArgs e)
        {
            runSine = false;
        }

        private void UI_StopCos_btn_Click(object sender, EventArgs e)
        {
            runCos = false;
        }

        private void UI_StartSine_Btn_Click(object sender, EventArgs e)
        {
            runSine = true;
            Thread sineThread = new Thread(FindSine);
            sineThread.Start();
        }

        private void UI_StartCos_Btn_Click(object sender, EventArgs e)
        {
            runCos = true;
            Thread cosThread = new Thread(FindCos);
            cosThread.Start();
        }

        private void ClearSineListBox()
        {
            UI_Sine_LB.Items.Clear();
        }

        private void ClearCosListBox()
        {
            UI_Cos_LB.Items.Clear();
        }
    }
}
