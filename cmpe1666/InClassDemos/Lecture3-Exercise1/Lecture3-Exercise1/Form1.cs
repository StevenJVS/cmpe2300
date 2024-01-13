using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture3_Exercise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ui_Calculate_Btn_Click(object sender, EventArgs e)
        {
            bool success;
            int value;
            int result;
            
            success=int.TryParse(UI_Value_Tbx.Text, out value);

            if ((!success) || (value < 0))
                MessageBox.Show("The text box does not contain a valid value");
            else
            {
                result = factorial(value);
                UI_Result_Tbx.Text=result.ToString();
            }

        }


        int factorial(int n)
        {  
            if (n>=1)
                return n * factorial(n - 1);
            else 
                return 1;
        }
    }
}
