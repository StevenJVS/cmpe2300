using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture2BExercise4
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_Display_Btn_Click(object sender, EventArgs e)
        {
            string EngineCapacity = "";
            string Color = "";

            if (UI_Red_Radio.Checked)
                Color = "Red;";
            else if (UI_Green_Radio.Checked)
                Color = "Green";
            else if (UI_Blue_Radio.Checked)
                Color = "Blue";

            if (UI_1500_Radio.Checked)
                EngineCapacity = "1500";
            else if (UI_2000_Radio.Checked)
                EngineCapacity = "2000";
            else if (UI_2500_Radio.Checked)
                EngineCapacity = "2500";

            MessageBox.Show($" You wish to have a car with Color {Color } and Engine Capacity {EngineCapacity}");


        }
    }
}
