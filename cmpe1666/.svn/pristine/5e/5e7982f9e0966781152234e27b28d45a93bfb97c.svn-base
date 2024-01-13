
//***********************************************************************************
//Program: Color This
//Description: change the background color of the main form using a modeless dialog
//Date: 03/24/23
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

namespace ica13
{
    public partial class Form1 : Form
    {
        //initiate modeless dialog object
        Modelessdialog modelessdialog = null;
        public Form1()
        {
            InitializeComponent();
            //create new dialog object
            modelessdialog = new Modelessdialog();

            //return current state of the background of main form to the modeless dialog
            modelessdialog.ThisColor = BackColor;
            modelessdialog.ThisOpacity = Opacity;
        }
        //********************************************************************************************
        //Method: Form1_Click
        //Purpose: open modelessdialog 
        //Returns:
        //*********************************************************************************************
        private void Form1_Click(object sender, EventArgs e)
        {
           //call methods when track bar values from the modeless dialog 
           //is being changed
                modelessdialog._dChangeColor = new delColor(setbackground);
                modelessdialog._dOpacity = new delOpacity(setopacity);
                modelessdialog._dFormClosing = new delVoidVoid(Formclosing);
            //show dialog
            modelessdialog.Show();

        }
        //********************************************************************************************
        //Method: FormClosing
        //Purpose: hide modeless dialog
        //Returns:
        //*********************************************************************************************
        private void Formclosing()
        {
            //hide dialog when the user exits the modeless dialog form
            modelessdialog.Hide();
        }
        //********************************************************************************************
        //Method: setbackground
        //Purpose: set background
        //Returns:
        //*********************************************************************************************
        private void setbackground(int r, int g, int b)
        {
            //set background color of the main form
            BackColor = modelessdialog.ThisColor;
        }
        //********************************************************************************************
        //Method: setopacity
        //Purpose: set opacity
        //Returns:
        //*********************************************************************************************
        private void setopacity(double opacity)
        {
            //set opacity of the main form
            Opacity= modelessdialog.ThisOpacity/100;
        }
    }
}
