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
using System.Drawing;
using System.Threading;

namespace Question1_solution
{
    public partial class UI_LE3Q1_Form : Form
    {
        Queue<Point> drawerQueue = new Queue<Point>();
        Stack<Point> drawerStack = new Stack<Point>();
       

        CDrawer Canvas = new CDrawer();
        public UI_LE3Q1_Form()
        {
            InitializeComponent();
            //Canvas.Scale = 5;
          
            Canvas.MouseLeftClick += Canvas_MouseLeftClick;
            Canvas.MouseRightClick += Canvas_MouseRightClick;
          

        }
                

        private void Canvas_MouseLeftClick(Point pos, CDrawer dr)
        {
           drawerQueue.Enqueue(pos);
           displayQueueCountInfo();
        }

        private void displayQueueCountInfo()
        {
            Action<String> delQLabelDisplay; delQLabelDisplay = new Action<string>(displayQueueInfo);

            string QInfo;
            QInfo = $"Number of Points in Queue: {drawerQueue.Count}";
            QInfo += $"- Estimated Time: {drawerQueue.Count * 1.5} secs";
            Invoke(delQLabelDisplay,QInfo);
            displayStackCountInfo();

        }

        private void displayQueueInfo(string str)
        {
            UI_QLabel.Text = str;
        }



        private void Canvas_MouseRightClick(Point pos, CDrawer dr)
        {
            drawerStack.Push(pos);
            displayStackCountInfo();


        }
        


        private void drawSquares()
        {
            Point posn;
            Action<Point> squareDelegate= new Action<Point>(drawSingleSquare);
            
            while (true)
            {
                if (drawerQueue.Count > 0)
                {
                    posn = drawerQueue.Dequeue();
                    Invoke(squareDelegate, posn);
                    displayQueueCountInfo();

                }
                Thread.Sleep(1500);

            }
       }

       private void drawSingleSquare(Point posn)
            {
            Canvas.AddRectangle(posn.X, posn.Y, 50, 50, Color.Red);
            }

        private void drawCircles()
        {
            Point posn;
            Action<Point> circleDelegate = new Action<Point>(drawSingleCircle);

            while (true)
            {
                if (drawerStack.Count > 0)
                {
                    posn = drawerStack.Pop();
                    Invoke(circleDelegate, posn);
                    displayStackCountInfo();

                }
                Thread.Sleep(2000);

            }
        }

        private void drawSingleCircle(Point posn)
        {
            Canvas.AddEllipse(posn.X, posn.Y, 50, 50, Color.Blue);
        }

        private void UI_LE3Q1_Form_Load(object sender, EventArgs e)
        {
            displayQueueCountInfo();
            Thread QueueThread = new Thread(drawSquares);
            QueueThread.IsBackground = true;
            QueueThread.Start();

            Thread StackThread = new Thread(drawCircles);
            StackThread.IsBackground = true;
            StackThread.Start();
        }


        private void displayStackCountInfo()
        {
           
            Action<String> delStackLabelDisplay = new Action<string>(displayStackInfo);
            string StackInfo;
            StackInfo = $"Number of Points in Stack: {drawerStack.Count}";
            StackInfo += $"- Estimated Time: {drawerStack.Count * 2} secs";
            Invoke(delStackLabelDisplay,StackInfo);

        }

        private void displayStackInfo(string str)
        {
            UI_StackLabel.Text = str;
        }
    }
}
