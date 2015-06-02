using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab5
{
    class Text : Shape
    {
        Point startPt;
        Point endPt;
        Brush brushType;
        Pen penType;
        Font textFont;
        String typedText;
        
        public Text(Point start, Point end, Pen pen, Font font, String text, Brush brush)
        {
            startPt = start;
            endPt = end;
            penType = pen;
            textFont = font;
            typedText = text;
            brushType = brush;
        }

        public override void draw(Graphics g)
        {
            int width = Math.Abs(endPt.X - startPt.X);
            int height = Math.Abs(endPt.Y - startPt.Y);
            int startX = Math.Min(startPt.X, endPt.X);
            int startY = Math.Min(startPt.Y, endPt.Y);

            RectangleF rectF1 = new RectangleF(startX, startY, width, height);
            g.DrawString(typedText, textFont, brushType, rectF1);
       
            
        }
    }
}
