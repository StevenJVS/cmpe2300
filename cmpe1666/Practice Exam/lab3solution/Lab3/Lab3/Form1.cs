
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

namespace Lab3
{
    public partial class Form1 : Form
    {
        const int width = 800;
        const int height = 600;
        const int ballSize = 50;
        const int rowCount = height / ballSize;
        const int columnCount = width / ballSize;

        int TotalScore = 0;


        Select_Diffculty select_Diffculty = new Select_Diffculty();
        Animation_Speed animation_Speed = new Animation_Speed();
        Score score = new Score();
        HighScore highScore = new HighScore();  


        public enum State { alive, dead };

        public struct element 
        {
            public Color color;
            public State aliveOrDead;

            public element(Color color, State aliveOrDead)
            {
                this.color = color;
                this.aliveOrDead = aliveOrDead;
            }
        }


        element[,] ballStructure = new element[columnCount, rowCount];



        CDrawer Canvas = new CDrawer(width, height);


        public Form1()
        {
            InitializeComponent();
        }

        private void UI_play_btn_Click(object sender, EventArgs e)
        {

            if (select_Diffculty.ShowDialog() == DialogResult.OK)
            {
                UI_play_btn.Enabled = false;
                timer1.Enabled = true;

                TotalScore = 0;

                Randomize(select_Diffculty.Difficulty);
                Display();
            }
        }
        private void UI_showScore_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_showScore_checkBox.Checked)
                score.Show();
            else
                score.Hide();
        }
        private void UI_showAnimationSpeed_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_showAnimationSpeed_checkBox.Checked)
                animation_Speed.Show();
            else
                animation_Speed.Hide();
        }

        public void Randomize(int difficulty)
        {
            Color[] randomColor = { Color.Red, Color.Yellow, Color.Green, Color.Blue, Color.White };

            Random random = new Random();
            for (int y = 0; y < rowCount; y++)
            {
                for (int x = 0; x < columnCount; x++)
                {
                    int colorIndex = random.Next(0, difficulty);
                    ballStructure[x, y] = new element(randomColor[colorIndex], State.alive);
                }
            }
        }

        public void Display()
        {
            Canvas.Clear();
            for (int y = 0; y < rowCount; y++)
            {
                for (int x = 0; x < columnCount; x++)
                {
                    if (ballStructure[x,y].aliveOrDead == State.alive)
                    {
                        int xCoord = x * ballSize;
                        int yCoord = y * ballSize;
                        Canvas.AddEllipse(xCoord, yCoord, ballSize, ballSize, ballStructure[x, y].color);
                    }
                }
            }
        }
        public int BallsAlive()
        {
            int num = 0;
            for (int y = 0; y < rowCount; y++)
            {
                for (int x = 0; x < columnCount; x++)
                {
                    if (ballStructure[x, y].aliveOrDead == State.alive)
                    {
                        num++;    
                    }
                }
            }

            return num;
        }
        public int CheckBalls(int row, int col, Color color)
        {
            if (row < 0 || row >= columnCount || col < 0 || col >= rowCount)
            {
                return 0;
            }

            if (ballStructure[row, col].aliveOrDead == State.dead)
            {
                return 0;
            }
            if (ballStructure[row, col].color != color)
            {
                return 0;
            }

            ballStructure[row, col].aliveOrDead = State.dead;

            int numKilled = 1;

            numKilled += CheckBalls(row - 1, col, color); // above
            numKilled += CheckBalls(row + 1, col, color); // below
            numKilled += CheckBalls(row, col - 1, color); // left
            numKilled += CheckBalls(row, col + 1, color); // right

            return numKilled;
        }
        public int StepDown()
        {
            int total = 0;
            for (int y = 1; y < rowCount; y++)
            {
                for (int x = 0; x < columnCount; x++)
                {
                    
                    if (ballStructure[x, y].aliveOrDead == State.dead)
                    {
                        
                        if (ballStructure[x, y - 1].aliveOrDead == State.alive)
                        {
                            ballStructure[x, y - 1].aliveOrDead = State.dead;
                            ballStructure[x, y].aliveOrDead = State.alive;
                            ballStructure[x, y].color = ballStructure[x, y - 1].color;
                            total++;
                        }

                    }
                }
            } 
            return total;
        }
        public int FallDown()
        {
            
            int totalLoopCount = 0;
            int ballsDropped = 1;


            while (ballsDropped > 0)
            {

                ballsDropped = StepDown();
                totalLoopCount++;
                Display();

                Thread.Sleep(animation_Speed.AnimationSpeed);
            }

            return totalLoopCount;
        }
        public void Pick()
        {

            Point pointClicked;

            if (Canvas.GetLastMouseLeftClickScaled(out pointClicked))
            {
                int pointX = pointClicked.X / (width / columnCount);
                int pointY = pointClicked.Y / (height / rowCount);
                int num = CheckBalls(pointX, pointY, ballStructure[pointX, pointY].color);

                int totalCalls = FallDown();

                TotalScore += num * 50 + num * (num * 25);

                score.score = TotalScore;

                Display();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int ballsAlive = BallsAlive();

            if (ballsAlive == 0)
            {

                Canvas.AddText("Game Over", 78);

                UI_play_btn.Enabled = true;
                timer1.Enabled = false;
            }
            else
            {
                Pick();
            }
        }
    }
}
