using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Lab6
{
    public partial class Form1 : Form
    {
        private const float clientSize = 100;
        private const float lineLength = 80;
        private const float block = lineLength / 3;
        private const float offset = 10;
        private const float delta = 5;
        public enum CellSelection { N, O, X };
        public static CellSelection[,] grid = new CellSelection[3, 3];
        private float scale;    //current scale factor
        bool oStartClicked = true;
      
        public Form1()
        {
            InitializeComponent();
            ResizeRedraw = true;
            Text = "Luke Poitras - Lab 6";
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            ApplyTransform(g);
            //draw board
            g.DrawLine(Pens.Black, block, 0, block, lineLength);
            g.DrawLine(Pens.Black, 2 * block, 0, 2 * block, lineLength);
            g.DrawLine(Pens.Black, 0, block, lineLength, block);
            g.DrawLine(Pens.Black, 0, 2 * block, lineLength, 2 * block);
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; ++j)
                    if (grid[i, j] == CellSelection.O)
                    {
                        DrawO(i, j, g);
                    }
                    else if (grid[i, j] == CellSelection.X)
                    {
                        DrawX(i, j, g);
                    }
        }

        // O starts clicked in menu
        private void computerStartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;

            // If flag is true, call OStarts method
            // once passes true, will always pass false until new game 
            GameEngine myEngine = new GameEngine(i, j, grid);
            if (oStartClicked == true)
            {
                myEngine.OStarts(true);
                oStartClicked = false;
            }
            else
                myEngine.OStarts(false);
      

            Invalidate();
            computerStartsToolStripMenuItem.Enabled = false;
        }
       

        private void ApplyTransform(Graphics g)
        {
            scale = Math.Min(ClientRectangle.Width / clientSize,
            ClientRectangle.Height / clientSize);
            if (scale == 0f)
                return;
            g.ScaleTransform(scale, scale);
            g.TranslateTransform(offset, offset);
        }
        private void DrawX(int i, int j, Graphics g)
        {
            g.DrawLine(Pens.Black, i * block + delta, j * block + delta,
            (i * block) + block - delta, (j * block) + block - delta);
            g.DrawLine(Pens.Black, (i * block) + block - delta, j * block + delta, (i * block) + delta, (j * block) + block - delta);
        }
        private void DrawO(int i, int j, Graphics g)
        {
            g.DrawEllipse(Pens.Black, i * block + delta, j * block + delta,
            block - 2 * delta, block - 2 * delta);
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            oStartClicked = false;
            Graphics g = CreateGraphics();
            ApplyTransform(g);
            PointF[] p = { new Point(e.X, e.Y) };
            g.TransformPoints(CoordinateSpace.World, CoordinateSpace.Device, p);
            if (p[0].X < 0 || p[0].Y < 0) 
                return;
            int i = (int)(p[0].X / block);
            int j = (int)(p[0].Y / block);
            if (i > 2 || j > 2)
                return;
          
            //only allow setting empty cells
            if(grid[i, j] == CellSelection.N)
            {
                if(e.Button == MouseButtons.Left)
                {
                    GameEngine myEngine = new GameEngine(i, j, grid);
                    if(myEngine.CheckWinner() != true)
                    {
                    computerStartsToolStripMenuItem.Enabled = false;
                    // Check if there is a winner.
                    // if there isnt, play X
                    if (myEngine.CheckWinner() != true)
                    {
                        myEngine.PlayX();
                        Invalidate();
                    }
                   if(myEngine.CheckWinner() == true)
                    {
                        if (myEngine.WhoWon() == "X Wins!")
                        {
                            MessageBox.Show("X wins!");
                        }
                        else if (myEngine.WhoWon() == "O Wins!")
                        {
                            MessageBox.Show("O Wins!");
                        }
                        else if (myEngine.WhoWon() == "Game is drawn!")
                        {
                            MessageBox.Show("Game is drawn!");
                        }
                    }

                    // Once X is played, check if it was a winning move
                    // If not, invalidate form and play O and check if O had winning move
                    if (myEngine.CheckWinner() != true)
                    {
                        Invalidate();
                        myEngine.PlayX();
                        myEngine.PlayO();
                        if (myEngine.CheckWinner() == true)
                        {
                            if (myEngine.WhoWon() == "Game is drawn!")
                            {
                                MessageBox.Show("Game is drawn!");
                            }
                            else if (myEngine.WhoWon() == "X Wins!")
                            {
                                MessageBox.Show("X wins!");
                            }
                            else if (myEngine.WhoWon() == "O Wins!")
                            {
                                MessageBox.Show("O Wins!");
                            } 
                        }
                    }
                }
            }
            }
            Invalidate();
        }

        // When New game menu item clicked call NewGame() method
        private void newGameMenu_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;
            
            GameEngine myEngine = new GameEngine(i,j, grid);
            myEngine.NewGame();
            oStartClicked = true;
            computerStartsToolStripMenuItem.Enabled = true;
            
            this.Invalidate();
        }
    }
}