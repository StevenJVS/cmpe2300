
//***********************************************************************************
//Program: Line Drawing
//Description: draw lines and change colors and size of the line using the right click
//Date: 03/13/23
//Author: Steven Santiago
//Course: CMPE1666
//Class: CNTA02
//***********************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace ica10
{
    public partial class Form1 : Form
    {
        //line struct
        public struct SLine
        {
            public Point start;//start point
            public Point end;//end point
            public Color color;//line color
            public byte thick;//linc thickness

            //constructor to assign default values
            public SLine(Point _start, Point _end, Color _color, byte _thick)
            {
                //save 
                start = _start;
                end = _end;
                color = _color;
                thick = _thick;
            }
        }
        Point start;//store first click 
        private enum eState {Idle, Armed};//state of click

        CDrawer canvas;//canvas
        //list of original lines and modified lines
        List<SLine> lines;
        List<SLine> modlines;

        eState state;//state variable
        Random rand = new Random();//random number generator
        public Form1()
        {
            InitializeComponent();
            //create list
            lines = new List<SLine>();
            modlines = new List<SLine>();

            canvas = new CDrawer(800, 800, false);//create canvas
            UI_timer.Enabled = true;//start timer
        }
        //********************************************************************************************
        //Method: UI_Form1_load
        //Purpose: update state
        //Returns:
        //*********************************************************************************************
        private void Form1_Load(object sender, EventArgs e)
        {
            canvas.Render();//upadate empty canvas
            UI_label.Text = state.ToString();//display idle to forms
            state = eState.Idle;//set state to idle
        }
        //********************************************************************************************
        //Method: Render
        //Purpose: draw original line to canvas
        //Parameters:SLine line
        //Returns:
        //*********************************************************************************************
        private void Render(SLine line)
        {   
            //create draw line to canvas
            canvas.AddLine(line.start.X, line.start.Y, line.end.X,line.end.Y, line.color, line.thick);
            canvas.Render();//update canvas
        }
        //********************************************************************************************
        //Method: Render
        //Purpose: display modified lines
        //Parameters:
        //Returns:
        //*********************************************************************************************
        private void Render()
        {    
            //foreach random lines in the list
            foreach (SLine line in modlines)
            {
                //call method to display line in canvas
                Render(line);
            }
        }
        //********************************************************************************************
        //Method: UI_timer_Tick
        //Purpose: check for clicks on the canvas
        //Returns:
        //*********************************************************************************************
        private void UI_timer_Tick(object sender, EventArgs e)
        {
            Point left;//left click
            Point right; ;//right click
            byte thick = 5;//line thickness
            if (canvas.GetLastMouseLeftClick(out left))//if mouse has been clicked
            {
                if(state == eState.Idle)//check state
                {
                    start = new Point(left.X, left.Y);//store starting point
                    state = eState.Armed;//change state to armed

                }
                else
                {
                    //create new line
                    SLine line = new SLine(start,left,Color.Red,thick);
                    lines.Add(line);//add line to list
                    Render(line);//call method to display created line
                    state = eState.Idle;//hange state to idle

                }
                UI_label.Text = state.ToString();//update label
            }
            if (canvas.GetLastMouseRightClick(out right))//right mouse click
            {
                //clear lines so lines dont over lap
                modlines.Clear();
                //add new modified lines to list
                foreach(SLine i in lines)
                {
                    modlines.Add(new SLine(i.start, i.end, RandColor.GetColor(), (byte)rand.Next(1,16)));
                }
                //clear canvas
                canvas.Clear();
                canvas.Render();//update canvas
                Render();//display modded lines to list
            }
        }
    }
}
