//***********************************************************************************
//Program: ICA4
//Description: Speed converter
//Date: 01/29/23
//Author: Steven Santiago
//Course: CMPE1666
//Class: CNTA02
//***********************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ica4
{
    public partial class Form1 : Form
    {
<<<<<<< .mine
        string input;
        double num;
        double kilo = 1.609344;
        double mile = 0.62137119;
        string output;
        bool select = false;
        bool kilom = false;
        bool milem = false;
        bool error = false;
||||||| .r68
        string input = "0";
        double num;
        double kilo = 1.609344;
        double mile = 0.62137119;
        string output;
        bool kilom = false;
        bool error = false;
=======
>>>>>>> .r93

        string input = "";//initail string input
        double num;//unassigned double
        //source:https://www.rapidtables.com/convert/length/mile-to-km.html
        double Kilo = 3.6;//unit conversion from miles to kilometres
        double Mile = 2.23693629;//unit conversion from kilometres to miles
        bool kilom = false;//to indicate which radio button is checked

        public Form1()
        {
            InitializeComponent();
        }
        //********************************************************************************************
        //Method: UI_input_Changed
        //Purpose: Take user input
        //*********************************************************************************************
        private void UI_input_TextChanged(object sender, EventArgs e)
        {
<<<<<<< .mine
            input = UI_input.Text;
            double.TryParse(input, out num);

            if (!double.TryParse(input, out num))
                error = true;

||||||| .r68
            input = UI_input.Text;
            double.TryParse(input, out num);
            if (!double.TryParse(input, out num))
                error = true;

=======
            input = UI_input.Text;//user input
            Convert(input);
>>>>>>> .r93
        }
        //********************************************************************************************
        //Method: convert
        //Purpose: converts input in real time
        //*********************************************************************************************
        private void Convert(string input)
        {
<<<<<<< .mine
            
                if (num < 0)
                {
                    UI_output.Text = "Please enter a valid input";
                
                }

            if (UI_Kilometres_CheckedChanged() = true)
||||||| .r68
            if (!error)
=======
            double.TryParse(input, out num);//convert string input to double
            bool flag = double.TryParse(input, out num);//store error input
            //display error message for invalid input
            if (!flag)
>>>>>>> .r93
            {
<<<<<<< .mine
                UI_output.Text = $"{num / kilo:f2}";               
||||||| .r68
                UI_output.Text = "Please enter a valid input";
=======
                UI_output.Text = "Please enter a valid number";
>>>>>>> .r93
            }
<<<<<<< .mine
            else if (milem == true)
||||||| .r68
            if (kilom == true)
=======
            //remove error message if input is emmpty
            if (input == "")
>>>>>>> .r93
            {
<<<<<<< .mine
||||||| .r68
                UI_output.Text = $"{num / kilo:f2}";
            }
            else if (kilom == false)
            {
=======
                UI_output.Text = "0";
                flag = false;
            }

            //calculate input to kilometres and display in text box
            if (kilom == true && flag)
            {
>>>>>>> .r93
                UI_output.Text = $"{num / Kilo:f2}";
            }
<<<<<<< .mine

||||||| .r68
            
=======
            //calculate input to miles and display in text box
            else if (kilom == false && flag)
            {
                UI_output.Text = $"{num / Mile:f2}";
            }
>>>>>>> .r93
        }
        //********************************************************************************************
        //Method: UI_Radio_Click
        //Purpose: Checks if Kilometres radio box is checked
        //*********************************************************************************************
        private void UI_Radio_Click(object sender, EventArgs e)
        {
<<<<<<< .mine
            kilom = true;
            milem = false;
        }
||||||| .r68
            kilom = false;
        }
=======
            //if Miles is selected
            if (UI_Miles.Checked)
            {
                kilom = false;
                Convert(input);
            }
            //if kilometres is selected
            else if (UI_Kilometres.Checked)
            {
                kilom = true;
                Convert(input);
            }
>>>>>>> .r93

<<<<<<< .mine
        private void UI_Kilometres_CheckedChanged(object sender, EventArgs e)
        {
            kilom = false;
            
||||||| .r68
        private void UI_Kilometres_CheckedChanged(object sender, EventArgs e)
        {
            kilom = true;
=======
>>>>>>> .r93
        }
    }
}
