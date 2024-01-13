//***********************************************************************************
//Program: stackyListDraw
//Description: crummy drawing application
//Date: 04/23/23
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

namespace Lab4
{
    public partial class Form1 : Form
    {
        //struct
        public struct LineSeg
        {
            public Point Start;
            public Point End;
            public byte thick;
            public float alpha;
            public Color color;
            //constructor
            public LineSeg (Point _start, Point _end, byte _thickness, float _alpha, Color _color)
            {
                Start = _start;
                End = _end;
                thick = _thickness;
                alpha = _alpha;
                color = _color;
            }
        }
        //stack of linkedlists
       Stack<LinkedList<LineSeg>> stack= new Stack<LinkedList<LineSeg>>();
        CDrawer canvas = new CDrawer(1024, 768, true);//canvas
        bool draw = false;//draw
        Point pos;//starting click

        //starting line properties
        byte Thick = 5;
        float Alpha = (float)0.5;
        Color Color = Color.Red;

        //line and segment count
        int segcount = 0; 
        int linecount = 0;
        public Form1()
        {
            InitializeComponent();
        }
        //timer tick event
        private void UI_timer_Tick(object sender, EventArgs e)
        {
            Point click;//user click
            Point current;//cuurent position of the mouse hover

            //check if the staring click is not the same as last click
            if(canvas.GetLastMouseLeftClick(out click) && click != pos && draw == false)
            {
                draw = true;//enable drawing
                pos = click;//starting position
                stack.Push(new LinkedList<LineSeg>());//add a line in stack
            }
            //check if mouse is hovering on the canvas
            if(draw && canvas.GetLastMousePosition(out current) && current != pos)
            {
                //make a new segment
                LineSeg line = new LineSeg(current, pos, Thick, Alpha, Color.FromArgb((int)(255*Alpha), Color));
                //draw segment on canvas
                canvas.AddLine(line.Start.X, line.Start.Y, line.End.X, line.End.Y, line.color, line.thick);
                stack.Peek().AddFirst(line);//add segment to linkedlist
                pos= current;//move pos so user can make new segments
                segcount++;//increment segment counter
            }
            //user right click
            else if(canvas.GetLastMouseRightClick(out click))
            {
                draw= false;//disable drawing
                pos = click;//end of line
                linecount++;//increment line counter
            }
            Updatelabel();//update label
        }
        //select color btn
        private void UI_colorbtn_Click(object sender, EventArgs e)
        {
            UI_colordialog.ShowDialog();//open color dialog
            UI_picturebox.BackColor = UI_colordialog.Color;//show color in a picture box
            Color = UI_colordialog.Color;//store selected color
        }
        //track bar scroll
        private void UI_trackbar_Scroll(object sender, EventArgs e)
        {
            //thickness radio btn checked
            if (UI_thicknessrbtn.Checked)
            {
                UI_thicknessrbtn.Text= $"Thickness: {Thick}";//radio btn text
                Thick = (byte)UI_trackbar.Value;//store thick value
            }
            //alpha radio btn checked
            if (UI_alpharbtn.Checked)
            {
                UI_alpharbtn.Text = $"Alpha: {Alpha}";//radio btn text
                Alpha = (float)UI_trackbar.Value/100;//store alpha value
            }
        }
        //form load
        private void Form1_Load(object sender, EventArgs e)
        {
            //display default value
            UI_thicknessrbtn.Text = $"Thickness: {Thick}";
            UI_alpharbtn.Text = $"Alpha: {Alpha}";
        }
        //********************************************************************************************
        //Method: Render
        //Purpose: update canvas for each modification
        //Returns:
        //*********************************************************************************************
        private void Render()
        {
            Stack<LinkedList<LineSeg>> temp = new Stack<LinkedList<LineSeg>>();//create temp list
            stack.Reverse();//reverse created stack
            canvas.Clear();//clear canvas

            //each lines in stack
            foreach (LinkedList<LineSeg> node in stack)
            {
                temp.Push(node);//push reverse list into temp list
            }
            //each lines int temp
            foreach (LinkedList<LineSeg> node in temp)
            {
                //each segement in linked list
                foreach (LineSeg seg in node)
                {
                    //update canvas for each modifications
                    canvas.AddLine(seg.Start.X, seg.Start.Y, seg.End.X, seg.End.Y, seg.color, seg.thick);
                }
            }
        }
        //********************************************************************************************
        //Method: Updatelabel
        //Purpose: update display label
        //Returns:
        //*********************************************************************************************
        private void Updatelabel()
        {
            //display message in text box
            UI_textbox.Text = $"{linecount} lines, {segcount} total segments";
        }
        private void UI_undoline_Click(object sender, EventArgs e)
        {
            int count = 0;//counter for segments removed
            try
            {
                LinkedList<LineSeg> popped = stack.Pop();//remove line
                LinkedListNode<LineSeg> node = popped.First;//starting node of removed stack
                linecount--;//decrement line count

                //check for all segments of removed line
                while (node!= null)
                {
                    count++;//count segments
                    node = node.Next;//move to next segment
                }
            }
            catch(Exception ex)
            {
                //error message
                MessageBox.Show(ex.Message);
            }
            //decrement total segment count by the number of segments removed
            segcount -= count;

            //update label and render canvas
            Updatelabel();
            Render();
        }

        private void UI_undoseg_Click(object sender, EventArgs e)
        {
            try
            {
                //check if there any segments available to remove
                if (stack.Peek().Count > 0) 
                { 
                    stack.Peek().RemoveFirst();//remove segment
                    segcount--;//decrement segment count
                }
                //if there are no segments
                else
                {
                    stack.Pop();//remove line 
                    linecount--;//decrement line count
                }

            }
            catch(Exception ex)
            {
                //error message
                MessageBox.Show(ex.Message);
            }

            //update label and render canvas
            Updatelabel();
            Render();
        }

        private void UI_reducecomplexity_Click(object sender, EventArgs e)
        {
            //if line cannot be reduced
            if(stack.Peek().Count < 1)
            {
                return;
            }
            //only reduce top of stack
            LinkedList<LineSeg> seg = stack.First();
            LinkedListNode<LineSeg> node = seg.First;

            while(node.Next != seg.Last && node.Next!= null)
            {
                //new line
                node.Value = new LineSeg(node.Value.Start, node.Next.Value.End, node.Value.thick, node.Value.alpha, node.Value.color);
                seg.Remove(node.Next);//remove old line
                segcount --;//decrement segment count
                node = node.Next;//go to next node
            }

            //update label and render canvas
            Render();
            Updatelabel();
        }
    }
}
