using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingProgram
{
    /// <summary>
    /// Class <c>Rectangle</c> represents a rectangular shape that can be drawn in the PictureBox.
    /// </summary>
    public class Rectangle : Shape
    {
        private const int DefaultWidth = 100;
        private const int DefaultHeight = 80;
        public Rectangle(Color color) : base(color) { }

        public override Shape CreateNewShape(Color color)
        {
            return new Rectangle(color);
        }

        public override void DrawColoredShape(Graphics g, Point startPoint, Point endPoint)
        {
            using (Pen pen = new Pen(shapeColor))
            {
                int x = Math.Min(startPoint.X, endPoint.X);
                int y = Math.Min(startPoint.Y, endPoint.Y);
                int width = Math.Abs(startPoint.X - endPoint.X);
                int height = Math.Abs(startPoint.Y - endPoint.Y);
                g.DrawRectangle(pen, x, y, width, height);
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
