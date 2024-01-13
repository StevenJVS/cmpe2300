using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture7_Exercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ui_ChooseFont_Btn_Click(object sender, EventArgs e)
        {
            if (UI_TextFont_Dlg.ShowDialog()==DialogResult.OK)
            {
                UI_Display_Lbl.Font = UI_TextFont_Dlg.Font;
                UI_Font_Tbx.Text= UI_TextFont_Dlg.Font.ToString();
            }
        }

        private void UI_ChooseColor_Btn_Click(object sender, EventArgs e)
        {
            if (UI_TextColor_Dlg.ShowDialog() == DialogResult.OK)
            {
                UI_Display_Lbl.ForeColor = UI_TextColor_Dlg.Color;
                UI_Color_Tbx.Text = UI_Display_Lbl.ForeColor.ToString();
            }
        }
    }
}
