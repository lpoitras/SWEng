using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab5
{
    class Rectangle : Shape
    {
        Point startPt;
        Point endPt;
        Brush brushType;
        Pen penType;
        bool isFill;
        bool isOutline;

        public Rectangle(Point start, Point end, Brush brush, Pen pen, bool isFill, bool isOutline)
        {
            startPt = start;
            endPt = end;
            brushType = brush;
            penType = pen;
            this.isFill = isFill;
            this.isOutline = isOutline;
        }

        public override void draw(Graphics g)
        {
            int width = Math.Abs(endPt.X - startPt.X);
            int height = Math.Abs(endPt.Y - startPt.Y);
            int startX = Math.Min(startPt.X, endPt.X);
            int startY = Math.Min(startPt.Y, endPt.Y);

            if (isFill && isOutline)
            {
               g.FillRectangle(brushType, startX, startY, width, height);
               g.DrawRectangle(this.penType, startX, startY, width, height);
            }
            else if(isFill && !isOutline)
            { 
                g.FillRectangle(brushType, startX, startY, width, height); 
            }
            else if(!isFill && isOutline)
            {
                g.DrawRectangle(this.penType, startX, startY, width, height);
            }
            
        }
    }
}
