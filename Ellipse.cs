using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingProgram
{
    /// <summary>
    /// Class <c>Ellpise</c> represents the Ellipse shape.
    /// </summary>
    public class Ellipse : Shape
    { 
        public Ellipse(Color color) : base(color) { }

        public override Shape CreateNewShape(Color color)
        {
            return new Ellipse(color);
        }

        public override void DrawColoredShape(Graphics g, Point startPoint, Point endPoint)
        {
            using (Pen pen = new Pen(shapeColor))

            {
                int x = Math.Min(startPoint.X, endPoint.X);
                int y = Math.Min(startPoint.Y, endPoint.Y);
                int width = Math.Abs(startPoint.X - endPoint.X);
                int height = Math.Abs(startPoint.Y - endPoint.Y);
                g.DrawEllipse(pen, x, y, width, height);
            }
        }

        // Resize method based on specific width and height
        public override void Resize(int width, int height)
        {
            int x = Math.Min(startPoint.X, endPoint.X);
            int y = Math.Min(startPoint.Y, endPoint.Y);
            endPoint = new Point(x + width, y + height);
        }
    }
}
