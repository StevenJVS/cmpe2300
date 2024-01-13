//***********************************************************************************
//Steven Santiago - ICA2
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

namespace ica_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("The form has been constructed");//display message output
        }
        //********************************************************************************************
        //Method: static private void Form1_Load
        //Purpose: Display output message
        //Parameters:
        //object sender
        //EventArgs e
        //*********************************************************************************************
        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("The form has been loaded");//display message output

        }
        //********************************************************************************************
        //Method: static private void Form1_FormClosing
        //Purpose: Display output message
        //Parameters:
        //object sender
        //FormClosingEventArgs e
        //*********************************************************************************************
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("The form is closing");//display message output
        }
        //********************************************************************************************
        //Method: static private void Form1_Activated
        //Purpose: Display output message
        //Parameters:
        //object sender
        //EventArgs e
        //*********************************************************************************************
        private void Form1_Activated(object sender, EventArgs e)
        {
            Console.WriteLine("The form has been activated");//display message output
        }
        //********************************************************************************************
        //Method: static private void Form1_Paint
        //Purpose: Display output message
        //Parameters:
        //object sender
        //PaintEventArgs e
        //*********************************************************************************************
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("The form paint has opened");//display message output
        }
        //********************************************************************************************
        //Method: static private void Form1_FormClosed
        //Purpose: Display output message
        //Parameters:
        //object sender
        //FormClosedEventArgs e
        //*********************************************************************************************
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("The form has closed");//display message output
        }
        //********************************************************************************************
        //Method: static private void Form_Deactivate
        //Purpose: Display output message
        //Parameters:
        //object sender
        //EventArgs e
        //*********************************************************************************************
        private void Form1_Deactivate(object sender, EventArgs e)
        {
            Console.WriteLine("The form has been deactivated");//display message output
        }
        //********************************************************************************************
        //Method: static private void Form_Shown
        //Purpose: Display output message
        //Parameters:
        //object sender
        //EventArgs e
        //*********************************************************************************************
        private void Form1_Shown(object sender, EventArgs e)
        {
            Console.WriteLine("The form has been shown");//display message output
        }
    }
}
