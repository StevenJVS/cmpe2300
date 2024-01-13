using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeExam3
{
    public delegate void delvoid();
    public delegate int delint(string c);
    public partial class ModelessDialog : Form
    {    
        public int value
        {
            get 
            { 
                return num; 
            }
        }

        public delvoid _formclosing= null;
        public delint _value = null;
        string operand;
        int num;


        public ModelessDialog()
        {
            InitializeComponent();
            _value = new delint(operation);
        }

        private void ModelessDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                if(null!= _formclosing)
                {
                    _formclosing.Invoke();
                }
                e.Cancel = true;
                Hide();
            }
        }

        private void UI_checked(object sender, EventArgs e)
        {
            if(Ui_addition.Checked)
            {
                operand = "+";
            }
            if(Ui_subtraction.Checked)
            {
                operand = "-";
            }
            if(Ui_multiplication.Checked)
            {
                operand = "*";
            }
            _value.Invoke(operand);
        }
        public int operation(string op)
        {
            int operation;
            int.TryParse(op, out operation);

            int value1;
            int value2;

            int.TryParse(Ui_input1.Text, out value1);
            int.TryParse(UI_input2.Text, out value2);



            switch (op)
            {
                case "+": num = value1+ value2;
                    break;

                    case "-": num = value1- value1;
                    break;

                    case "*": num = value1* value2;
                    break;
                    default:
                    num= 0;
                    break;
            }
            return num;
        }

        private void TextChange(object sender, EventArgs e)
        {
            _value.Invoke(operand);
        }
    }
}
