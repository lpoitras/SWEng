using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab5
{
    class Line : Shape
    {
        Point startPt;
        Point endPt;
        Brush brushType;
        Pen penType;

        public Line(Point start, Point end,Pen pen)
        {
            startPt = start;
            endPt = end;
            penType = pen;
        }

        public override void draw(Graphics g)
        {
            g.DrawLine(penType, startPt, endPt);
        }
        
    }
}
