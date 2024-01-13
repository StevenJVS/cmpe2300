using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeExam3Q1
{ 
    //Definining delegate types
    public delegate void delBinaryOp(string op,int v1, int v2); //Delegate type for the mathematical operations
    public delegate void delformClosing(); //Delegate type for form closing
    public partial class ModelessDialog : Form
    {
        //Declaration of variables for delegate object references
        public delBinaryOp _delOp = null; 
        public delformClosing _dFormClosing = null;
      
        private string operation;
        public ModelessDialog()
        {
            InitializeComponent();
        }

        //Consolidated event listener for radio buttons
        private void perFormCalculation(object sender, EventArgs e)
        {
            int val1, val2;
            bool success1;
            bool success2;

            success1= int.TryParse(UI_value1_tbx.Text, out val1);
            success2= int.TryParse(UI_value2_tbx.Text, out val2);
            if (!success1 || !success2)
            {
                if (_delOp != null)// Always ensure that a delgate has been assigned a function before invoking it
                    _delOp("None", val1, val2);
            }//if we don't have valid data, we still invoke  the delegate, but
             //we pass None as the operation
            else
            {
                if (UI_Addition_Radio.Checked)
                    operation = "Add";
                else if (UI_Subtraction_Radio.Checked)
                    operation = "Sub";
                else if (UI_Multiplication_Radio.Checked)
                    operation = "Mult";

                if (_delOp != null) //Ensure that a delgate has been assigned a function before invoking it
                    _delOp.Invoke(operation, val1, val2);//Invoking the delegate for the operation- It calls the corresponding callback
                                                  //in the main form
            }



        }

        //Event listener for the form closing action 
        private void ModelessDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) //Check if the closing action is from the user
                                                          // (not an OS shutdown)
            {
                e.Cancel = true; //Cancel the closing action (we don't want the form to be disposed)
                Hide();          //Hode the form instead of closing it
            }
            if (_dFormClosing!=null) //Ensuring the delegate has been assigned a function
                 _dFormClosing(); //Invoke the delegate for action on the main form when the form is closing
        }
    }
}
