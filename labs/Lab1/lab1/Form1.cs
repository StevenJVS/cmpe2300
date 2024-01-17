using GDIDrawer;
using System;
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
        State[,] blockstate;
        Point start;
        Point end;

        Thread solve;
        int steps = 0;

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
                    blockstate = new State[maze.Width, maze.Height];

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
                                blockstate[i, j] = State.open;
                                canvas.SetBBScaledPixel(i, j, pixel);
                            }
                            else if (pixel.R == 0 && pixel.G == 0 && pixel.B == 0)
                            {
                                blockstate[i, j] = State.wall;
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
            if (blockstate != null)
            {
                solve = new Thread(CallSolve);
                if(solve.ThreadState != ThreadState.Running)
                solve.Start();
            }
        }
        public void CallSolve()
        {
            Solve(start);
        }
        public int Solve(Point curr)
        {
            if (curr.X == end.X && curr.Y == end.Y)
                return 1;
            if (curr.X < 0 || curr.X > maze.Width || curr.Y < 0 || curr.Y > maze.Height || blockstate[curr.X, curr.Y] == State.wall || blockstate[curr.X, curr.Y] == State.visited)
            {
                return 0;
            }
            canvas.SetBBScaledPixel(curr.X, curr.Y, Color.Purple);//paint canvas
            Thread.Sleep(20);
            blockstate[curr.X, curr.Y] = State.visited;

            
            List <Point> paths = path(curr);

            foreach(Point p in paths)
            {
                Solve(p);
            }

            if(paths.Count== 0)
            { return 1; }

            return 0;
        }
        public List<Point> path(Point nextpoint)
        {
            List<Point> path = new List<Point>();

            if (nextpoint.X+1 < maze.Width && blockstate[nextpoint.X + 1, nextpoint.Y] == State.open)
            {
                path.Add(nextpoint);
            }
            if (nextpoint.X-1 > 0 && blockstate[nextpoint.X - 1, nextpoint.Y] == State.open)
            {
                path.Add(nextpoint);
            }
            if (nextpoint.Y+1 < maze.Height && blockstate[nextpoint.X, nextpoint.Y + 1] == State.open)
            {
                path.Add(nextpoint);
            }
            if (nextpoint.Y-1 > 0 && blockstate[nextpoint.X, nextpoint.Y - 1] == State.open)
            {
                path.Add(nextpoint);
            }
            return path;
        }
    }
}
