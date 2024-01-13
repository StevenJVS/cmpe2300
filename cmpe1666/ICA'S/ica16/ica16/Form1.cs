//***********************************************************************************
//Program: Slow draw
//Description: Slowly draw on canvas
//Date: 04/05/23
//Author: Steven Santiago
//Course: CMPE1666
//Class: CNTA02
//***********************************************************************************
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace ica16
{
    public delegate void delvoid();//thread to 
    public delegate void deldis();//delegate to display
    public partial class Form1 : Form
    {
        CDrawer canvas = new CDrawer();//canvas
        Queue<Point> points = new Queue<Point>();//points to queue
        Stopwatch sw= new Stopwatch();//create stopwatch

        //delgate
        delvoid myque = null;
        deldis _display = null;
        Thread th;//thread
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //display to canvas
            canvas.MouseMove += canvas_mousemove;
            canvas.MouseRightClick += canvas_mouserightclick;

            //store delegate
            myque = trackpoint;
            _display = display;

            //start thread
            th = new Thread(trackthread);
            th.Start();

        }
        //********************************************************************************************
        //Method: Display
        //Purpose: Display total queue and time to indicator text box
        //Returns: 
        //*********************************************************************************************
        private void display()
        {
            //dispay to textbox
            UI_textbox.Text = $"{points.Count} segs in queu, estimate time to draw: {((double)points.Count/20):f2}";
        }
        //********************************************************************************************
        //Method: Canvas mousemove
        //Purpose: add drawn lines to queue
        //Returns: 
        //*********************************************************************************************
        private void canvas_mousemove(Point pos, CDrawer cDrawer)
        {
            //add to qeue
            points.Enqueue(pos);
        }
        //********************************************************************************************
        //Method: canvas_mouserightclick
        //Purpose: add star to canvas and add shapes to queue
        //Returns: 
        //*********************************************************************************************
        private void canvas_mouserightclick(Point pos, CDrawer cDrawer)
        {
            //end points
            double x;
            double y;

            //create star
            for (int i = 0; i < 250; i++)
            {
                x = Math.Cos(i) * 40 + pos.X;
                y = Math.Sin(i) * 40 + pos.Y;
                points.Enqueue(new Point((int)x, (int)y));//star end points
                points.Enqueue(pos);//start points
            }
        }
        //********************************************************************************************
        //Method: trackpoint
        //Purpose: get total rgb in percentage
        //Returns: 
        //*********************************************************************************************
        private void trackpoint()
        {
            //draw lines when movement is detected in canvas
            if (points.Count > 1)
            {
                Point lastPoint = points.Dequeue();
                Point startPoint = points.Peek();
                canvas.AddLine(lastPoint.X, lastPoint.Y, startPoint.X, startPoint.Y, Color.Red);
            }
            //draw on same point to prevent program form crashing
            else if (points.Count == 1)
            {
                Point lastPoint = points.Peek();
                canvas.AddLine(lastPoint.X, lastPoint.Y, lastPoint.X, lastPoint.Y, Color.Red);
            }
        }
        //********************************************************************************************
        //Method: trackthread
        //Purpose: get total rgb in percentage
        //Returns: 
        //*********************************************************************************************
        private void trackthread()
        {
            sw.Start();//start timer
            while (true)//keep loop running
            {
                sw.Restart();//to keep updating canvas and indicator
                try
                {
                    Invoke(myque);//make point
                }
                catch
                {
                    Console.WriteLine("Cancelled");
                }
                try
                {
                    Invoke(_display);//display on indicator
                }
                catch
                {
                    Console.WriteLine("Cancelled");
                }
                while (sw.ElapsedMilliseconds < 49)//Draw delay
                {
                    Thread.Sleep(1);//pause
                }
            }
        }
    }
}
