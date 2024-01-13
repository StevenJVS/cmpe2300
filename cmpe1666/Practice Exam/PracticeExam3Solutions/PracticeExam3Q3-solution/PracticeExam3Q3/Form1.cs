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
//using System.Drawing;
using System.Threading;
using System.Diagnostics;


/*
 * Author: Oveeyen Moonian
 * Lab Exam: Multi-Threading
 * 
 */
namespace PracticeExam3Q3
{    
    public partial class Form1 : Form
    {   //Defining delegate type
        public delegate void delVoidString(string x);
        private Random rand = new Random();

        //For generating random colors (within the given array range) 
        private Random randColor=new Random();

        //For generating random move distances
        private Random randMovement = new Random();

        int ThreadCount = 0;

        //An array for a selected number of colors
        Color[] colorArray = {Color.Blue,Color.Red, Color.Yellow,Color.Green, Color.Cyan,Color.Purple,
                               Color.Azure, Color.Bisque,Color.Gray,Color.Navy};

        Stopwatch sw = new Stopwatch();
        private CDrawer Canvas;
        private List<Thread> ThreadList;//For storing a list of threads
        public Form1()
        {
            InitializeComponent();
            sw.Start();
        }

        private void UI_Start_Thread_Click(object sender, EventArgs e)
        {
            //Each time we click on the Start Thread button, we start a new thread
            //We also increment the Thread count, make the thread a background thread and add it to the thread list
            Thread T1 = new Thread(DrawMovingCircles);
            ThreadCount++;
            T1.Name = "Thread" + ThreadCount.ToString();

            T1.IsBackground = true;
            ThreadList.Add(T1);
            T1.Start();
        }

        //Method executed by each Thread
        private void DrawMovingCircles()
        { int xposn = 0;
            Color c;
            //generate a random color for the new ball
            c = colorArray[rand.Next(0, 10)];

            //Assigning the method "Add To Listbox to the delegate
            delVoidString Thread_delegate = new delVoidString(AddToListBox);
            string outputStr;
            int move;

            //For each new thread, we generate a random vertical position
            int yposn = rand.Next(50, Canvas.m_ciHeight - 50);
           
            
            while (xposn < Canvas.m_ciWidth+100)
            {
                //Create a ball with the color c and display it at the position (xposn,yposn)
                //Note that as we iterate through the loop, xposn will change. We'll cover the previous ball with black 
                // and draw a new ball at the new xposn keeping the same yposn. This will give the horizontal animation
                Canvas.AddCenteredEllipse(new Point(xposn, yposn), 50, 50, c, 1, Color.Black);
               
                //We build a string passing all the required information, the pass it to the ge=delegate 
                //to perform the display in the listbox
                outputStr = Thread.CurrentThread.Name + "-Time: "+ sw.ElapsedMilliseconds.ToString()
                          + "ms -(" + xposn.ToString() + "," + yposn.ToString() + ")";

                Invoke(Thread_delegate,outputStr);//Invoking the delegate to perform the display in the listbox

                //The thread sleeps for 100ms, then erases the current position of the ball by drawing a black ball in its position
                Thread.Sleep(100);

                Canvas.AddCenteredEllipse(new Point(xposn, yposn), 50, 50, Color.Black, 1, Color.Black);

                //Generate a random move in the range 1..40, add it to the xposn, so that when the loop runs again, the 
                //ball will be drawn in the new position
                move = randMovement.Next(1, 41);
                xposn += move;
            }
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {  //Creating the Drawer window and the Threadlist when the form loads
            Canvas = new CDrawer();
            ThreadList = new List<Thread>();
        }


        //At each time tick we check for stopped threads and remove them from the thread list.
        //Then we update the count
        private void UI_Thread_Timer_Tick(object sender, EventArgs e)
        {
            for (int count = 0; count < ThreadList.Count; count++)
            {
                Thread T = ThreadList[count];
                if (T.ThreadState == System.Threading.ThreadState.Stopped)
                    ThreadList.Remove(T);
            }

            this.Text = "No. of Active Threads is: " + ThreadList.Count.ToString();
        }

        private void AddToListBox(string str)
        {
            UI_Thread_LB.Items.Add(str);
        }
    }
}
