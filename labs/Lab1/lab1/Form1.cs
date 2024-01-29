using GDIDrawer;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        Bitmap maze;//bit map for maze
        CDrawer canvas;//maze canvas 
        public enum State { open, wall, visited };//possible states of the maze
        
        State[,] mazegrid;//maze grid

        //start and end points
        Point start;
        Point end;

        Thread solve;//solving thread
        public delegate void DisplayDelegate(int steps);//delegate to get the steps from solving thread

        public Form1()
        {
            InitializeComponent();
        }

        private void UI_Load_Btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            //check if a picture was selected
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                maze = new Bitmap(ofd.FileName);//createa bitmap for the loaded maze

                //check if the maze size is within bounds
                if (maze.Width > 200 || maze.Height > 100)
                {
                    UI_Message_txtbx.Text = "Maze size is too big!";
                }
                else
                {
                    //check if theres another maze loaded
                    if (canvas != null)
                    {
                        //close previous maze
                        canvas.Close();
                    }
                    UI_Display.Image = Image.FromFile(ofd.FileName);//display maze on form
                    UI_Message_txtbx.Text = $"Loaded: {maze.Width}x{maze.Height}";//display maze dimensions
                    UI_Solve_Btn.Enabled = true;//enable the solve button
                    mazegrid = new State[maze.Width, maze.Height];//create a the 2d array with the dimensions of the loaded maze

                    //create canvas
                    canvas = new CDrawer(maze.Width * 10, maze.Height * 10);
                    canvas.Scale = 10;//increase the size if the pixels

                    for (int i = 0; i < maze.Width; i++)//x portion of the maze
                    {
                        for (int j = 0; j < maze.Height; j++)//y potion of the maze
                        {
                            Color pixel = maze.GetPixel(i, j);//store the color of the pixel
                            if (pixel.R == 255 && pixel.G == 255 && pixel.B == 255)// if white
                            {
                                //set state to open for pixel and display on canvas
                                mazegrid[i, j] = State.open;
                                canvas.SetBBScaledPixel(i, j, pixel);
                            }
                            else if (pixel.R == 0 && pixel.G == 0 && pixel.B == 0)//if black
                            {
                                //set state to wall and display on canvas
                                mazegrid[i, j] = State.wall;
                                canvas.SetBBScaledPixel(i, j, pixel);
                            }
                            else if (pixel.R == 0 && pixel.G == 255 && pixel.B == 0)//if green
                            {
                                //store starting point and display on canvas
                                canvas.SetBBScaledPixel(i, j, pixel);
                                start.X = i; start.Y = j;
                            }
                            else if (pixel.R == 255 && pixel.G == 0 && pixel.B == 0)//if red
                            {
                                //store end point and display on canvas
                                canvas.SetBBScaledPixel(i, j, pixel);
                                end.X = i; end.Y = j;
                            }
                        }
                    }
                }
            }
        }

        private void UI_Solve_Btn_Click(object sender, EventArgs e)
        {
            //check if there was a current maze in the 2d array
            if (mazegrid != null)
            {
                solve = new Thread(CallSolve);//create thread
                solve.IsBackground= true;//create thread to backgoround
                if (!solve.IsAlive)//check if thread is already running
                    solve.Start();//start thread
                else 
                    UI_Message_txtbx.Text = "Solving thread is already running";//display if thread is already running
            }
        }
        /// <summary>
        /// Calls the recursive method
        /// </summary>
        public void CallSolve()
        {
            int steps = Solve(start);//gets the steps from the recuresive method
            DisplayDelegate display = Results;//store the delegate
                                              //neccessary to prevent crossthreading
            Invoke(display, steps);//call the delegate
        }
        /// <summary>
        /// displays appropriate message to the user if the maze was solved of not
        /// </summary>
        /// <param name="steps"></param>
        public void Results(int steps)
        {
            //check if steps are taken, a solution was found
            if (steps > 0)            
                UI_Message_txtbx.Text = $"Maze was solved with {steps} Steps!";
            else
                UI_Message_txtbx.Text = "No solution";

        }
        /// <summary>
        /// analyze the current pixel and return if its a valid move
        /// </summary>
        /// <param name="curr"></param>
        /// <returns>number of steps taken</returns>
        public int Solve(Point curr)
        {
            if (curr == end) //win condition && last step
            {
                return 1;
            }
            //check if the pixel is within bounds, a wall or visited
            if (curr.X < 0 || curr.X > mazegrid.GetLength(0) || curr.Y < 0 || curr.Y > mazegrid.GetLength(1) || mazegrid[curr.X, curr.Y] == State.wall || mazegrid[curr.X, curr.Y] == State.visited)
            {
                return 0;
            }
            else
            {
                //get the list of possible paths 
                List<Point> possiblepath = Path(curr);

                canvas.SetBBScaledPixel(curr.X, curr.Y, Color.Purple);//paint canvas
                mazegrid[curr.X, curr.Y] = State.visited;//set the current pixel to visited
                Thread.Sleep(20);//sleep thread

                //foreach possible direction, recursively analyze the following pixels
                foreach (Point p in possiblepath)
                {
                    int results = Solve(p);//follow path
                    if(results > 0)
                    {
                        //if path was found, add to steps
                        Thread.Sleep(20);
                        return 1 + results;
                    }
                
                }
                //if a dead end arm has been found
                canvas.SetBBScaledPixel(curr.X, curr.Y, Color.Green);
                return 0;
            }
        }
        /// <summary>
        /// Get the possible directions to go to
        /// </summary>
        /// <param name="nextpoint"></param>
        /// <returns>List of possible directions</returns>
        public List<Point> Path(Point nextpoint)
        {
            //create new list
            List<Point> path = new List<Point>();

            //check all sizes of the current pixel if a open pixel is found
            if (nextpoint.X - 1 >= 0 && mazegrid[nextpoint.X - 1, nextpoint.Y] == State.open)
                path.Add(new Point(nextpoint.X - 1, nextpoint.Y));

            if (nextpoint.X + 1 < mazegrid.GetLength(0) && mazegrid[nextpoint.X + 1, nextpoint.Y] == State.open)
                path.Add(new Point(nextpoint.X + 1, nextpoint.Y));

            if (nextpoint.Y - 1 >= 0 && mazegrid[nextpoint.X, nextpoint.Y - 1] == State.open)
                path.Add(new Point(nextpoint.X, nextpoint.Y - 1));

            if (nextpoint.Y + 1 < mazegrid.GetLength(1) && mazegrid[nextpoint.X, nextpoint.Y + 1] == State.open)
                path.Add(new Point(nextpoint.X, nextpoint.Y + 1));

            return path;//return list of possible directions
        }
    }
}
