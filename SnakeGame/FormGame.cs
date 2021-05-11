using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class FormGame : Form
    {
        private int meatX { get; set; }
        private int meatY { get; set; }
        private List<List<int>> shapeList { get; set; }
        private int direction { get; set; }
        public int timerMiliSeconds { get; set; }

        public FormGame()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            shapeList = new List<List<int>>();

            timer1.Interval = timerMiliSeconds;

            direction = 3;

            shapeList.Add(new List<int>
            {
                70, 100
            });

            shapeList.Add(new List<int>
            {
                60, 100 
            });

            shapeList.Add(new List<int>
            {
                50, 100
            });

            GenerateMeat();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);

            Pen p = new Pen(Color.Black);
            g.DrawRectangle(p, 10, 10, 460, 290);

            DrawMeat(meatX, meatY);
            EatMeat();

            for (int i = shapeList.Count - 1; i >= 0; i--)
            {
                var shape = shapeList[i];

                if(i == 0)
                {
                    if(direction == 0)
                    {
                        shape[0] += 0;
                        shape[1] -= 10;
                    }
                    else if(direction == 1)
                    {
                        shape[0] += 0;
                        shape[1] += 10;
                    }
                    else if (direction == 2)
                    {
                        shape[0] -= 10;
                        shape[1] += 0;
                    }
                    else if (direction == 3)
                    {
                        shape[0] += 10;
                        shape[1] += 0;
                    }

                    SolidBrush sb = new SolidBrush(Color.Black);
                    g.DrawRectangle(p, shape[0], shape[1], 10, 10);
                    g.FillRectangle(sb, shape[0], shape[1], 10, 10);
                }
                else
                {
                    var next = shapeList[i - 1];

                    shape[0] = next[0];
                    shape[1] = next[1];

                    SolidBrush sb = new SolidBrush(Color.Black);
                    g.DrawRectangle(p, shape[0], shape[1], 10, 10);
                    g.FillRectangle(sb, shape[0], shape[1], 10, 10);
                }
            }

            CheckDeath();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up && direction != 1)
            {
                direction = 0;
            }
            else if(e.KeyCode == Keys.Down && direction != 0)
            {
                direction = 1;
            }
            else if(e.KeyCode == Keys.Left && direction != 3)
            {
                direction = 2;
            }
            else if(e.KeyCode == Keys.Right && direction != 2)
            {
                direction = 3;
            }
        }

        public void GenerateMeat()
        {
            Random random = new Random();
            int x = 0;
            int y = 0;

            do
            {
                x = random.Next(10, 460);
            }
            while (x % 10 > 0);

            do
            {
                y = random.Next(10, 290);
            }
            while (y % 10 > 0);

            meatX = x;
            meatY = y;

            DrawMeat(x, y);
        }

        public void DrawMeat(int x, int y)
        {
            Graphics g = this.CreateGraphics();

            Pen p = new Pen(Color.Black);

            SolidBrush sb = new SolidBrush(Color.Black);

            g.DrawRectangle(p, x, y, 10, 10);
            g.FillRectangle(sb, x, y, 10, 10);
        }

        public void EatMeat()
        {
            var head = shapeList[0];

            if(head[0] == meatX && head[1] == meatY)
            {
                GenerateMeat();

                var tail = shapeList[shapeList.Count - 1];

                shapeList.Add(new List<int>
                {
                    tail[0], tail[1]
                });
            }
        }

        public void CheckDeath()
        {
            var head = shapeList[0];

            if (head[0] < 10 || head[1] < 10 || head[0] > 460 || head[1] > 290)
            {
                timer1.Stop();
                var result = MessageBox.Show("GAME OVER", "Message", MessageBoxButtons.OK);

                if(result == DialogResult.OK)
                {
                    this.Close();
                }
            }

            for (int i = shapeList.Count - 1; i >= 1; i--)
            {
                var bodyPart = shapeList[i];

                if(head[0] == bodyPart[0] && head[1] == bodyPart[1])
                {
                    timer1.Stop();

                    var result = MessageBox.Show("GAME OVER", "Message", MessageBoxButtons.OK);

                    if (result == DialogResult.OK)
                    {
                        this.Close();
                        break;
                    }
                }
            }
        }
    }
}