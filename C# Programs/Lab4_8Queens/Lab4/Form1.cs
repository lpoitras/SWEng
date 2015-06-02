using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Lab4
{
    public partial class Form1 : Form
    {
        bool hintsflag = false;
        public ArrayList queens = new ArrayList();  // Create ArrayList for Queen objects
        public ArrayList coords = new ArrayList();  // Creates ArrayList of the points clicked. 
        private bool[,] qArray = new bool[8, 8];    // 2D array for placed queens where the indicies are the corresponding row and col 
                                                    // Value is set to true for the corresponding clicked square and to true for all other
                                                    // valid squares that the placed queen can attack (up/down/diagonal).
        public Form1()
        {
            InitializeComponent();
            Text = "Eight Queens by Luke Poitras";    // Label form
            ResizeRedraw = true;  
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
       {
            if ((e.X > 100 && e.Y > 100 && e.X < 500 && e.Y < 500))  // Confirm that the click is within the game board.
           {
               if (e.Button == MouseButtons.Left)
               {
                   int row = (e.X - 100) / 50;                  // creates row and column for where mouse was clicked
                   int col = (e.Y - 100) / 50;
                   if (qArray[row, col] != true)
                   {
                       Point p = new Point(e.X, e.Y);
                       this.coords.Add(p);

                       for (int i = 0; i <= 7; i++)             // Sets horizontal and vertical = true from pt clicked, meaning in queens attack range.
                       {
                           qArray[i, col] = true;
                           this.queens.Add(new Queen(row, col, 0));
                       }
                       for (int i = 0; i <= 7; i++)
                       {
                           qArray[row, i] = true;
                           this.queens.Add(new Queen(row, col, 0));
                       }
                       for (int i = 0; i <= 7; i++)
                       {
                           for (int j = 0; j <= 7; j++)
                           {
                               for (int k = 0; k <= 7; k++)
                               {
                                   if (i == row + k && j == col + k)            // Sets diagonals  = true from pt clicked, meaning in queens attack range.
                                   {
                                       qArray[i, j] = true;
                                       this.queens.Add(new Queen(row, col, 0));
                                   }
                                   if (i == row - k && j == col + k)
                                   {
                                       qArray[i, j] = true;
                                       this.queens.Add(new Queen(row, col, 0));
                                   }
                                   if (i == row + k && j == col - k)
                                   {
                                       qArray[i, j] = true;
                                       this.queens.Add(new Queen(row, col, 0));
                                   }
                                   if (i == row - k && j == col - k)
                                   {
                                       qArray[i, j] = true;
                                       this.queens.Add(new Queen(row, col, 0));
                                   }
                               }
                           }
                       }
                   }
                   else
                   {
                       System.Media.SystemSounds.Beep.Play();                   // If box clicked is occupied or in another queens attack range
                   }                                                            // then do nothing but make noise.
               } 
           }
               this.Invalidate();
               if (coords.Count == 8)
               {
                   MessageBox.Show("You did it!");                              // If the arrayList of pts has 8 points, then player wins
               }
           } 
     
        protected override void OnPaint(PaintEventArgs e)
        {
            this.DoubleBuffered = true;
            Graphics g = e.Graphics;
            g.TranslateTransform(100, 100);
            Color color1, color2, color3;

         for (int i = 0; i < 8; i++)
            {
              Pen pen = new Pen(Brushes.Black, 0.01f);                  // Paints black and white board.
              g.PageUnit = GraphicsUnit.Pixel;
        
             if (i % 2 == 0)
          
             {
                 color1 = Color.White;
                 color2 = Color.Black;
             }
         
             else
             {
                 color1 = Color.Black;
                 color2 = Color.White;
             }
          
             SolidBrush blackBrush = new SolidBrush(color1);
             SolidBrush whiteBrush = new SolidBrush(color2);

          for (int j = 0; j < 8; j++)
          {
              if (j % 2 == 0)
              {
                  g.FillRectangle(blackBrush, i * 50, j * 50, 50, 50);
                  g.DrawRectangle(pen, i * 50, j * 50, 50, 50);
              }
              else
              {
                  g.FillRectangle(whiteBrush, i * 50, j * 50, 50, 50);
                  g.DrawRectangle(pen, i * 50, j * 50, 50, 50);
              }
          }
      }

      color3 = Color.Red;
            foreach (Queen q in queens)                                         // Paints red boxes if hints chkbox is clicked.
            {                                                                  
                if (hintsflag == true)
                {
                    using (Font font1 = new Font("Arial", 30, FontStyle.Regular, GraphicsUnit.Point))
                    {
                        Pen pen = new Pen(Brushes.Black, 0.01f);
                        g.PageUnit = GraphicsUnit.Pixel;
                        RectangleF rectF1 = new RectangleF(q.Row * 50, q.Col * 50, 50, 50);
                        e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
                        SolidBrush redBrush = new SolidBrush(color3);
                        for (int i = 0; i < 8; i++)
                        {
                            for (int j = 0; j < 8; j++)
                            {
                                if (this.qArray[i, j] == true)
                                {
                                    g.FillRectangle(redBrush, i * 50, j * 50, 50, 50);
                                    g.DrawRectangle(pen, i * 50, j * 50, 50, 50);
                                    //e.Graphics.DrawString(text1, font1, Brushes.Black, rectF1);
                                }
                            }
                        }
                    }
                }
                if(hintsflag == false)                              // Paints Qs either black or white, depending on box color
                {
                    string text1 = "Q";
                    using (Font font1 = new Font("Arial", 30, FontStyle.Regular, GraphicsUnit.Point))
                    {
                        RectangleF rectF1 = new RectangleF(q.Row * 50, q.Col * 50, 50, 50);
                        e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));

                        if (q.Col % 2 == 0 && q.Row % 2 == 0)
                        {
                            e.Graphics.DrawString(text1, font1, Brushes.Black, rectF1);
                        }
                        else
                        {
                            e.Graphics.DrawString(text1, font1, Brushes.White, rectF1);
                        }
                        if (q.Col % 2 == 1 && q.Row % 2 == 1)
                        {
                            e.Graphics.DrawString(text1, font1, Brushes.Black, rectF1);
                        }
                    }
                }
            }
            if (hintsflag == true)                                       // Sets all 'Q's as black if hints box is checked
            {
                foreach (Queen q in queens)
                {
                    string text2 = "Q";
                    using (Font font1 = new Font("Arial", 30, FontStyle.Regular, GraphicsUnit.Point))
                    {
                        Pen pen = new Pen(Brushes.Black, 0.01f);
                        g.PageUnit = GraphicsUnit.Pixel;
                        RectangleF rectF1 = new RectangleF(q.Row * 50, q.Col * 50, 50, 50);
                        e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
                        SolidBrush redBrush = new SolidBrush(color3);
                        for (int i = 0; i < 8; i++)
                        {
                            for (int j = 0; j < 8; j++)
                            {
                                if (this.qArray[i, j] == true)
                                {
                                    // g.DrawRectangle(pen, i * 50, j * 50, 50, 50);
                                    e.Graphics.DrawString(text2, font1, Brushes.Black, rectF1);
                                }
                            }
                        }
                    }
                }
            }
            this.number.Text = "You have " + this.coords.Count.ToString() + " queens on the board.";
         }

        private void clearButton_Click(object sender, EventArgs e)              // Clears all arrays, thus all queens on board
        {
            this.queens.Clear();
            this.coords.Clear();
            for(int i = 0; i <= 7;i++)
            {
                for(int j = 0; j <= 7;j++)
                {
                    qArray[i, j] = false;
                }
            }
            this.Invalidate();
        }

        private void hintsBox_CheckedChanged(object sender, EventArgs e)            // Sets the bool flag to T or F
        {
            if (hintsBox.Checked == true)
            {
                hintsflag = true;
            }
            if (hintsBox.Checked == false)
            {
                hintsflag = false;
            }
            Invalidate();
        }
    }
}