using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture2B_Exercise5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_CalculateSum_Btn_Click(object sender, EventArgs e)
        {
            int value1;
            int value2;
            int sum;

            int.TryParse(UI_Value1_Tbx.Text, out value1);
            int.TryParse(UI_Value2_Tbx.Text, out value2);

            sum= value1+ value2;

            UI_Sum_Tbx.Text = sum.ToString();
        }
    }
}
