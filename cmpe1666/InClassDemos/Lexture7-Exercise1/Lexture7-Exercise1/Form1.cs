using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lexture7_Exercise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_ObtainValues_Btn_Click(object sender, EventArgs e)
        {
            ModalDlg dlg= new ModalDlg();

            UI_FirstValue_Tbx.Clear();
            UI_SecondValue_Tbx.Clear();
            Ui_Sum_Tbx.Clear(); 
           
                      
          if (dlg.ShowDialog() == DialogResult.OK)
            {
                
                int sum = 0;
                
                UI_FirstValue_Tbx.Text= dlg.value1.ToString();
                UI_SecondValue_Tbx.Text = dlg.value2.ToString();
                sum = dlg.value1 + dlg.value2;

                Ui_Sum_Tbx.Text = sum.ToString();

            }
           
        }
    }
}
