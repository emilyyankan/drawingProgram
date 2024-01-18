using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DrawingProgram
{
    /// <summary>
    /// Class <c>Line</c> represents the Line Shape.
    /// </summary>
    public class Line : Shape
    {
        public Line(Color color) : base(color) { }

        public override Shape CreateNewShape(Color color)
        {
            return new Line(color);
        }

        // Method to a Line shape with specific color between given start and end point
        public override void DrawColoredShape(Graphics g, Point startPoint, Point endPoint)
        {
            using (Pen pen = new Pen(shapeColor, 2))

            {
                g.DrawLine(pen, startPoint, endPoint);
            }
        }

        // Resize method of the line by adjusting the end point.
        public override void Resize(int width, int height)
        {
            endPoint = new Point(endPoint.X + width, endPoint.Y + height);
        }
    }
}
