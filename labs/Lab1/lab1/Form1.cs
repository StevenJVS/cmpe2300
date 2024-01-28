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
        Bitmap maze;
        CDrawer canvas;
        public enum State { open, wall, visited };
        
        State[,] mazegrid;
        Point start;
        Point end;

        Thread solve;

        public delegate void DisplayDelegate(int steps);

        public Form1()
        {
            InitializeComponent();
            //start
            //newedit2
        }

        private void UI_Load_Btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                maze = new Bitmap(ofd.FileName);
                if (maze.Width > 200 || maze.Height > 100)
                {
                    UI_Message_txtbx.Text = "Maze size is too big!";
                }
                else
                {
                    if (canvas != null)
                    {
                        canvas.Close();
                    }
                    UI_Display.Image = Image.FromFile(ofd.FileName);
                    UI_Message_txtbx.Text = $"Loaded: {maze.Width}x{maze.Height}";
                    UI_Solve_Btn.Enabled = true;
                    mazegrid = new State[maze.Width, maze.Height];

                    //create canvas
                    canvas = new CDrawer(maze.Width * 10, maze.Height * 10);
                    canvas.Scale = 10;

                    for (int i = 0; i < maze.Width; i++)
                    {
                        for (int j = 0; j < maze.Height; j++)
                        {
                            Color pixel = maze.GetPixel(i, j);
                            if (pixel.R == 255 && pixel.G == 255 && pixel.B == 255)
                            {
                                mazegrid[i, j] = State.open;
                                canvas.SetBBScaledPixel(i, j, pixel);
                            }
                            else if (pixel.R == 0 && pixel.G == 0 && pixel.B == 0)
                            {
                                mazegrid[i, j] = State.wall;
                                canvas.SetBBScaledPixel(i, j, pixel);
                            }
                            else if (pixel.R == 0 && pixel.G == 255 && pixel.B == 0)
                            {
                                canvas.SetBBScaledPixel(i, j, pixel);
                                start.X = i; start.Y = j;
                            }
                            else if (pixel.R == 255 && pixel.G == 0 && pixel.B == 0)
                            {
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
            if (mazegrid != null)
            {
                solve = new Thread(CallSolve);
                solve.IsBackground= true;
                if (solve.ThreadState != ThreadState.Running)
                    solve.Start();
                else 
                    UI_Message_txtbx.Text = "Solving thread is already running";
            }
        }

        public void CallSolve()
        {
            int steps = Solve(start);
            DisplayDelegate display = Results;
            Invoke(display, steps);
        }
        public void Results(int steps)
        {
            if (steps > 0)
            {
                UI_Message_txtbx.Text = $"Maze was solved with {steps} Steps!";
            }
            else
            {
                UI_Message_txtbx.Text = "No solution";
            }
        }
        public int Solve(Point curr)
        {
            if (curr == end) //win condition && last step
            {
                return 1;
            }
            if (curr.X < 0 || curr.X > mazegrid.GetLength(0) || curr.Y < 0 || curr.Y > mazegrid.GetLength(1) || mazegrid[curr.X, curr.Y] == State.wall || mazegrid[curr.X, curr.Y] == State.visited)
            {
                return 0;
            }
            else
            {
                List<Point> possiblepath = Path(curr);

                canvas.SetBBScaledPixel(curr.X, curr.Y, Color.Purple);//paint canvas
                mazegrid[curr.X, curr.Y] = State.visited;
                Thread.Sleep(20);

                foreach (Point p in possiblepath)
                {
                    int results = Solve(p);
                    if(results > 0)
                    {

                        Thread.Sleep(20);
                        return 1 + results;
                    }
                
                }
                    canvas.SetBBScaledPixel(curr.X, curr.Y, Color.Green);
                    return 0;
            }
        }
        public List<Point> Path(Point nextpoint)
        {
            List<Point> path = new List<Point>();

            if (nextpoint.X - 1 >= 0 && mazegrid[nextpoint.X - 1, nextpoint.Y] == State.open)
                path.Add(new Point(nextpoint.X - 1, nextpoint.Y));

            if (nextpoint.X + 1 < mazegrid.GetLength(0) && mazegrid[nextpoint.X + 1, nextpoint.Y] == State.open)
                path.Add(new Point(nextpoint.X + 1, nextpoint.Y));

            if (nextpoint.Y - 1 >= 0 && mazegrid[nextpoint.X, nextpoint.Y - 1] == State.open)
                path.Add(new Point(nextpoint.X, nextpoint.Y - 1));

            if (nextpoint.Y + 1 < mazegrid.GetLength(1) && mazegrid[nextpoint.X, nextpoint.Y + 1] == State.open)
                path.Add(new Point(nextpoint.X, nextpoint.Y + 1));
            return path;
        }
    }
}
