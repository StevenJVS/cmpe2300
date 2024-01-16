using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace lab1
{
    public partial class Form1 : Form
    {
        Bitmap maze;
        CDrawer canvas;
        public enum State {open, wall, visited};
        State[,] blockstate;
        Point start;
        Point end;
        int steps = 0;

        //obj
        struct CurrPoint
        {
            public Point point;
            public Color color;

            public CurrPoint(Point mypoint, Color mycolor)
            {
                point = mypoint;
                color = mycolor;
            }
        }
        public Form1()
        {
            InitializeComponent();
            //start
            //newedit2
        }

        private void UI_Load_Btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                maze = new Bitmap(ofd.FileName);
                if(maze.Width > 200 || maze.Height > 100)
                {
                    UI_Message_txtbx.Text = "Maze size is too big!";
                }
                else
                {
                    UI_Display.Image = Image.FromFile(ofd.FileName);
                    UI_Message_txtbx.Text = $"Loaded: {maze.Width}x{maze.Height}";
                    UI_Solve_Btn.Enabled = true;
                    blockstate = new State[maze.Width, maze.Height];

                    //create canvas
                    canvas = new CDrawer(maze.Width*10, maze.Height*10);
                    canvas.Scale = 10;

                    for (int i = 0; i < maze.Width; i++)
                    {
                        for(int j = 0; j < maze.Height; j++)
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
            if (blockstate != null) {
                Color color = Color.Green;
                Thread solve = new Thread(new ParameterizedThreadStart(Solve));
                solve.Start(new CurrPoint(start,Color.Green));
            }
        }
        private void Solve(object objData)
        {
            if (objData is CurrPoint) {
                //unboxing
                CurrPoint thispoint = (CurrPoint)objData;
                int x = thispoint.point.X;
                int y = thispoint.point.Y;
                Color color = thispoint.color;

                if (x < 0 || x > maze.Width || y < 0 || y > maze.Height || blockstate[x, y] == State.wall || blockstate[x, y] == State.visited)
                {
                    return;
                }
                canvas.SetBBScaledPixel(x, y, Color.Purple);//paint canvas
                color = Color.Purple;

                CurrPoint pointright = thispoint;
                pointright.point.X = pointright.point.X + 1;
                pointright.color = color;

                CurrPoint pointleft = thispoint;
                pointleft.point.X = pointleft.point.X - 1;
                pointleft.color = color;

                CurrPoint pointup = thispoint;
                pointup.point.Y = pointup.point.Y - 1;
                pointup.color = color;

                CurrPoint pointdown = thispoint;
                pointdown.point.Y = pointdown.point.Y + 1;
                pointdown.color = color;
                
                if(y >= 0)
                Solve(pointup);
                if(y <= maze.Height)
                Solve(pointdown);
                if(x <= maze.Height)
                Solve(pointright);
                if(x >= 0)
                Solve(pointleft);

                if (x == end.X && y == end.Y)
                    return;
            }
        }
    }
}
