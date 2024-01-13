using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ica13
{
    //initiate delegates
    public delegate void delColor(int R, int G, int B);
    public delegate void delOpacity(double opac);
    public delegate void delVoidVoid();

    public partial class Modelessdialog : Form
    {
        //point delegates to nothing
        public delColor _dChangeColor = null;
        public delOpacity _dOpacity = null;
        public delVoidVoid _dFormClosing = null;

        public Color ThisColor
        {
            get
            {
                //return track bar values to main form
                return Color.FromArgb(Ui_red.Value,UI_green.Value,Ui_blue.Value);
            }
            set
            {
                //set trackbar value to current state of te dialog
                mycolor= value;
            }
        }
        public double ThisOpacity
        {
            get
            {
                //return track bar value to main form
                return UI_opacity.Value;
            }
            set
            {
                //set trackbar value to current opacity of the form
                opacity= value;
            }
        }
        Color mycolor;
        double opacity;
        public Modelessdialog()
        {
            InitializeComponent();
            //create delegates
            _dOpacity = new delOpacity(newopacity);
            _dChangeColor = new delColor(newcolor);
        }
        //********************************************************************************************
        //Method: Modelessdialog_Load
        //Purpose: set track bar values
        //Returns:
        //*********************************************************************************************
        private void Modelessdialog_Load(object sender, EventArgs e)
        {
            //set track bar values
            Ui_red.Value = mycolor.R;
            UI_green.Value = mycolor.G;
            Ui_blue.Value = mycolor.B;
            UI_opacity.Value = (int)(opacity * 100);
        }
        //********************************************************************************************
        //Method: newcolor
        //Purpose: set current color of the track bar 
        //Returns:
        //*********************************************************************************************
        private void newcolor(int R, int G, int B)
        {
            //set colors to the track bars
            mycolor = Color.FromArgb(R, G, B);
        }
        //********************************************************************************************
        //Method: newopacity
        //Purpose: set current opacity of the track bar
        //Returns:
        //*********************************************************************************************
        private void newopacity(double input)
        {
            //set opacity to track bars
           opacity = input;
        }
        //********************************************************************************************
        //Method: UI_track
        //Purpose: listens for track bar scroll
        //Returns:
        //*********************************************************************************************
        private void UI_track(object sender, EventArgs e)
        {
            //call method when track bar value changes
            _dChangeColor.Invoke(Ui_red.Value, UI_green.Value, Ui_blue.Value);
        }
        //********************************************************************************************
        //Method: UI_opacity_scroll
        //Purpose: listens for track bar scroll
        //Returns:
        //*********************************************************************************************
        private void UI_opacity_Scroll(object sender, EventArgs e)
        {
            //call method when track bar value changes
            _dOpacity.Invoke(UI_opacity.Value);
        }
        //********************************************************************************************
        //Method: Modelessdialog_FormClosing
        //Purpose: hide modeless dialog
        //Returns:
        //*********************************************************************************************
        private void Modelessdialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            //check if user decides to exit the modeless dialog
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (null != _dFormClosing)
                {
                    if (_dFormClosing != null)
                    {
                        //call method from main
                        _dFormClosing.Invoke();
                    }
                    //hide form
                    e.Cancel = true;
                    Hide();
                }
            }
        }
    }
}
