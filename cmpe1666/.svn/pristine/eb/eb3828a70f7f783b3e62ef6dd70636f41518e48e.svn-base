//***********************************************************************************
//Program: FloodFill
//Description: Flood fill
//Date: 02/08/23
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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;


namespace ica6
{
    public partial class Form1 : Form
    {
        CDrawer Canvas = new CDrawer();//create new canvas
        
        Color[,] colorfill = new Color[80, 60];//create empty color array
        Random random = new Random();//generate random number for canvas locations
        

        public Form1()
        {
            Canvas.Scale = 10;//scale canvas
            InitializeComponent();            
        }
        //********************************************************************************************
        //Method: UI_fill_color_Click
        //Purpose: Open color dialog and select wanted color
        //Returns:
        //*********************************************************************************************
        private void UI_fill_color_Click(object sender, EventArgs e)
        {
            UI_colordialog.ShowDialog();//open color dialog
            UI_picturebox.BackColor = UI_colordialog.Color;//change picture box to selected color
        }
        //********************************************************************************************
        //Method: UI_genartebutton_click
        //Purpose: generate borders and random pixels
        //Returns:
        //*********************************************************************************************
        private void UI_generatebutton_Click(object sender, EventArgs e)
        {
            //paint whole canvas black
            for(int c = 0; c < 80; c++)
            {
                for (int d = 1; d < 60; d++)
                {
                    Canvas.SetBBScaledPixel(c, d, Color.Black);//display red to canvas
                    colorfill[c,d] = Color.Black;//set color array to black
                }
            }
            //create red borders
                for (int a = 0; a < 80; a++)
                {
                    for (int b = 0; b < 60; b++)
                    {
                        if (a== 79 || a == 0 || b == 59 || b == 0)
                    {
                        colorfill[a,b] = Color.Red;//replace index values of array to red
                        Canvas.SetBBScaledPixel(a, b, Color.Red);//display red to canvas
                    }

                    }
                }
                //create random pixels
                for (int i = 0; i < UI_trackbar.Value; i++)
                {
                    int x = random.Next(0, 79);
                    int y = random.Next(0, 59);
                    Canvas.SetBBScaledPixel(x, y, Color.Red);//display red to canvas
                colorfill[x, y] = Color.Red;//replace index values of array to red
                }
             
        }
        //********************************************************************************************
        //Method: Flood Fill
        //Purpose: display flood fill in canvas
        //Returns:
        //*********************************************************************************************
        private void FloodFill(int x, int y, Color color)
        {
            //if coordinate has the same color return
            if (colorfill[x, y] == UI_colordialog.Color)
                return;
            //if color of pixel is red return
            if (colorfill[x,y] == Color.Red)
            {
                return;
            }
            //if color pixel is still black
                Canvas.SetBBScaledPixel((int)x, (int)y, UI_colordialog.Color);//paint canvas
            colorfill[x,y] = UI_colordialog.Color;//store color index in color fill
            //move to next location
            FloodFill(x + 1, y, color);
            FloodFill(x - 1, y, color);
            FloodFill(x, y + 1, color);
            FloodFill(x, y - 1, color);
        }
        //********************************************************************************************
        //Method: UI_fillcolor_Click
        //Purpose: start timer if canvas has been initialized
        //Returns:
        //*********************************************************************************************
        private void UI_fillcolor_Click(object sender, EventArgs e)
        {
            //start timer
            UI_timer.Enabled = true;
        }
        //********************************************************************************************
        //Method: UI_radioTest_Click
        //Purpose: function if button is clicked
        //Returns:
        //*********************************************************************************************
        private void UI_timer_Tick_1(object sender, EventArgs e)
        {
            Color old;//compare old color

            Point ptClick = new Point();//last pointer click
            if (Canvas.GetLastMouseLeftClickScaled(out ptClick))//if mouse has been clicked
            {
                old = colorfill[ptClick.X, ptClick.Y];//store location of the mouse click
                FloodFill(ptClick.X, ptClick.Y, old);//call recursion
                UI_timer.Enabled=false;
            }
        }
    }
}
