using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * Author: Oveeyen Moonian
 * Lab Exam Question on Modeless Dialog
 * 
 * 
 * 
 * 
 */


namespace PracticeExam3Q1
{
    public partial class Form1 : Form
    {
        private ModelessDialog dlg = null;//Declaring a referefor a modeless dialog object
                                          //The actual instance will be created below

        public Form1()
        {
            InitializeComponent();
        }

       
        //Callback function. Will be invoked by delegate 
        //in the modeless dialog whenever a change in value or in operation occurs 
      private void callBackOp(string Op, int value1, int value2)
        { int result = 0;

            switch (Op){
                case "Add": result = value1 + value2; break;
                case "Sub": result = value1 - value2; break;
                case "Mult": result = value1 * value2; break;
                default: result = 0;break; //If the operation is not one of the above 3
                                           //we simply display 0 as the result
                
            }
            
            UI_Result_tbx.Text = result.ToString();
;          
        }

        //Callback function. Invoked from modeless dialog when user closes the form by clicking on the X
        private void callBackFormClosing()
        {
            UI_ShowModeless_CBx.Checked = false;
        }


        //Event listener for the checkbox- invoked whenever a change occurs in the "check status 
        //of the checkbox
        private void UI_ShowModeless_CBx_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_ShowModeless_CBx.Checked) //This part runs when the checkbox is checked
            {
                //If the modeless dialog instance doesn't exit yet we need to create it
                //this will only happen when we check the checkbox for the first time
                if (dlg == null)
                {
                    dlg = new ModelessDialog();//Creation of Modeless Dialog instance

                    //We also need to register the callbacks for the delegates (these delegates
                    //  belong to the modeless dialog class)
                    dlg._delOp = callBackOp;
                    dlg._dFormClosing = callBackFormClosing;

                }
                dlg.Show();
            }
            else dlg.Hide(); //This will run if the checkbox is unchecked. In this case
                             // we only hide the dialog

        }
    }
}
