using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ica11
{
    public partial class ModalDialogForm : Form
    {
        public Font ThisFont
        {
            get
            {
                return(fontDialog1.Font);//return font
            }
            set
            {
                fontDialog1.Font = value;//set font
            }
        }
        public Color ThisForeColor
        {
            get
            {
                return (colorDialog1.Color);//return color
            }
            set
            {
                colorDialog1.Color = value;//set color
            }
        }
        public ModalDialogForm()
        {
            InitializeComponent();
        }

        private void UI_fontbtn_Click(object sender, EventArgs e)
        {
            fontDialog1= new FontDialog();//open dialog to select font
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                UI_fonttbx.Text = fontDialog1.Font.ToString();//display font to string
            }
        }

        private void UI_Colorbtn_Click(object sender, EventArgs e)
        {
            colorDialog1= new ColorDialog();//open dialog to select color
            if (colorDialog1.ShowDialog()== DialogResult.OK)
            {
                UI_colortbx.Text= colorDialog1.Color.ToString();//display color to string
            }
        }

        private void UI_OkBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;//user selected ok button
        }

        private void ModalDialogForm_Load(object sender, EventArgs e)
        {
            //display current styling to text box
            UI_fonttbx.Text = fontDialog1.Font.ToString();
            UI_colortbx.Text = colorDialog1.Color.ToString();
        }
    }
}
