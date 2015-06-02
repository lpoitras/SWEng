using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab5
{
    class Ellipse : Shape
    {
        Point startPt;
        Point endPt;
        Brush brushType;
        Pen penType;
        bool isFill;
        bool isOutline;
        
        public Ellipse(Point start, Point end, Pen pen, Brush brush, bool isFill, bool isOutline)
        {
            startPt = start;
            endPt = end;
            penType = pen;
            brushType = brush;
            this.isFill = isFill;
            this.isOutline = isOutline;
        }

        public override void draw(Graphics g)
        {
            int width = Math.Abs(endPt.X - startPt.X);
            int height = Math.Abs(endPt.Y - startPt.Y);
            int startX = Math.Min(startPt.X, endPt.X);
            int startY = Math.Min(startPt.Y, endPt.Y);

            RectangleF rectF = new RectangleF(startX, startY, width, height);
            if(isFill && isOutline)
            {
                g.FillEllipse(brushType, rectF);
                g.DrawEllipse(penType, rectF);
            }
            else if(isFill && !isOutline)
            {
                g.FillEllipse(brushType, rectF);
            }
            else if(!isFill && isOutline)
            {
                g.DrawEllipse(penType, rectF);
            }
        }
    }
}
