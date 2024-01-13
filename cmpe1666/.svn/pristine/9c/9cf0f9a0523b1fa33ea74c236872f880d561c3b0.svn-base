

//***********************************************************************************
//Program: String bender
//Description: modify string using delegates
//Date: 03/16/23
//Author: Steven Santiago
//Course: CMPE1666
//Class: CNTA02
//***********************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ica12
{

    public partial class Form1 : Form
    {
        public delegate string inputstring(string s);//delagate type
        public inputstring _stringinput = null;//create delagate object
        public Form1()
        {
            InitializeComponent();
        }
        //********************************************************************************************
        //Method: UI_radio
        //Purpose: check for radio button
        //Returns:
        //*********************************************************************************************
        private void UI_radio_Click(object sender, EventArgs e)
        {
            
            if (UI_upper.Checked)
            {
                //create new delegate that calls the upper method
                _stringinput = new inputstring(Upper);              
            }
            if (UI_lower.Checked)
            {
                //create new delegate that calls the lower method
                _stringinput = new inputstring(Lower);
            }
            if (UI_flip.Checked)
            {
                //create new delegate that calls the flip method
                _stringinput = new inputstring(Flip);
            }         

            UI_output.Text = _stringinput.Invoke(UI_input.Text);

        }
        //********************************************************************************************
        //Method: lower
        //Purpose: makes string all lower case
        //Parameters: string init
        //Returns:lower cased string
        //*********************************************************************************************
        private string Lower(string init)
        {
            string input = init.ToLower();//convert string to lower
            return input;//return lowered string
        }
        //********************************************************************************************
        //Method: upper
        //Purpose: makes string all upper case
        //Parameters: string init
        //Returns:uppercased cased string
        //*********************************************************************************************
        private string Upper(string init)
        {
            string input = init.ToUpper();//convert string to uppercase
            return input;//return uppercased string
        }
        //********************************************************************************************
        //Method: flip
        //Purpose: converts uppercased characters to lowercased and lowercased characters to uppercased
        //Parameters: string init
        //Returns:converted string
        //*********************************************************************************************
        private string Flip(string init)
        {
            string input  = "";//initail space
            //go through each character in the string
            foreach(char c in init)
            {
                if (char.IsUpper(c))//check if character is uppercased
                {
                    //add lowercased character to input
                    input += char.ToLower(c);
                }
                else
                {
                    //else add uppercased characters to upppercased
                    input += char.ToUpper(c);
                }
            }
            //return input
            return input;
        }
    }
}
