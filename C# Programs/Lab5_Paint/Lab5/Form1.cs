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


namespace Lab5
{
    public partial class Form1 : Form
    {
        public ArrayList shapes = new ArrayList();
        bool firstClick = true;
        Point firstPos;
        Point endPos;
        Brush brush = null;
        Pen pen;
        Brush fillBrush = null;
        bool isFill;
        bool isOutline;

        float width = 0;

        public Form1()
        {
            InitializeComponent();
            penColorList.Items.Add("Black");
            penColorList.Items.Add("Red"); 
            penColorList.Items.Add("Blue");
            penColorList.Items.Add("Green");

            fillColorList.Items.Add("White");
            fillColorList.Items.Add("Black");
            fillColorList.Items.Add("Red");
            fillColorList.Items.Add("Blue");
            fillColorList.Items.Add("Green");

            penWidthList.DataSource = iarray;

            this.penColorList.SelectedIndex = 0;
            this.fillColorList.SelectedIndex = 0; 
            this.penWidthList.SelectedIndex = 0;
            ResizeRedraw = true;
            textBox.Multiline = true;
            textBox.ScrollBars = ScrollBars.Both;
            textBox.WordWrap = false;
            textBox.AcceptsReturn = true;


        }
         public int[] iarray = {1,2,3,4,5,6,7,8,9,10};
       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach(Shape shape in shapes)
            {
                shape.draw(g);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (firstClick == true)
            {
                firstPos = e.Location;
                firstClick = false;
                return;
            }
            else
            {
                endPos = e.Location;
                firstClick = true;
            }
           
            switch(penColorList.SelectedIndex)
            {
                case 0:
                    brush = Brushes.Black;
                    break;
                case 1:
                    brush = Brushes.Red;
                    break;
                case 2:
                    brush = Brushes.Blue;
                    break;
                case 3:
                    brush = Brushes.Green;
                    break;
            }

            if(lineButton.Checked || outlineBox.Checked)
            {
                switch (penColorList.SelectedIndex)
                {
                    case 0:
                        brush = Brushes.Black;
                        break;
                    case 1:
                        brush = Brushes.Red;
                        break;
                    case 2:
                        brush = Brushes.Blue;
                        break;
                    case 3:
                        brush = Brushes.Green;
                        break;
                }
                //pen.Brush = brush;
               
                switch (penWidthList.SelectedIndex)
                {
                    case 0:
                        width = 1;
                        break;
                    case 1:
                        width = 2;
                        break;
                    case 2:
                        width = 3;
                        break;
                    case 3:
                        width = 4;
                        break;
                    case 4:
                        width = 5;
                        break;
                    case 5:
                        width = 6;
                        break;
                    case 6:
                        width = 7;
                        break;
                    case 7:
                        width = 8;
                        break;
                    case 8:
                        width = 9;
                        break;
                    case 9:
                        width = 10;
                        break;
                }
               
                //pen.Width = width;

                pen = new Pen(brush, width);
                
            }
            if(fillBox.Checked == true)
            {
                switch(fillColorList.SelectedIndex)
                {
                    case 0:
                        fillBrush = Brushes.White;
                        break;
                    case 1:
                        fillBrush = Brushes.Black;
                        break;
                    case 2:
                        fillBrush = Brushes.Red;
                        break;
                    case 3:
                        fillBrush = Brushes.Blue;
                        break;
                    case 4:
                        fillBrush = Brushes.Green;
                        break;
                }
          

            }
            if(this.lineButton.Checked==true)
            {
                this.shapes.Add(new Line(firstPos, endPos, pen));
            }
            if(rectangleButton.Checked == true)
            {
                if (fillBox.Checked && outlineBox.Checked)
                {
                    this.shapes.Add(new Rectangle(firstPos, endPos, fillBrush, pen, true, true));
                }
                else
                    if(fillBox.Checked && (outlineBox.Checked == false))
                    {
                        this.shapes.Add(new Rectangle(firstPos, endPos, fillBrush, pen, true, false));
                    }
                    if(outlineBox.Checked && (fillBox.Checked ==false))
                    {
                         this.shapes.Add(new Rectangle(firstPos, endPos, fillBrush, pen, false, true));
                    }
              
            }
            if (textButton.Checked)
            {
                shapes.Add(new Text(firstPos, endPos, pen, Font, textBox.Text, brush));
            }
            if(ellipseButton.Checked)
            {
                if(fillBox.Checked && outlineBox.Checked)
                {
                    shapes.Add(new Ellipse(firstPos, endPos, pen, fillBrush, true, true));
                }
                else if(fillBox.Checked && (outlineBox.Checked==false))
                {
                    shapes.Add(new Ellipse(firstPos, endPos, pen, fillBrush, true, false));
                }
                else if((fillBox.Checked == false) && outlineBox.Checked == true)
                {
                    shapes.Add(new Ellipse(firstPos, endPos, pen, fillBrush, false, true));
                }
            }
            panel2.Invalidate();
          
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.shapes.Clear();
            panel2.Invalidate();
          
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Shape shape in shapes)
            {
                for (int i = shapes.Count-1; i >= 0; i--)
                {
                    if (this.shapes[i].Equals(shapes[i]))
                    {
                        this.shapes.RemoveAt(i);
                        //shapes.Remove(shape);
                        break;
                    }
                }
            }
            panel2.Invalidate();
        }


        
       
        
    }
    
}
