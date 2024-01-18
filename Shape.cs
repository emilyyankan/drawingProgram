using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingProgram
{
    /// <summary>
    /// The abstract class <c>Shape</c> represents a basic shape that can be drawn on a canvas.
    /// </summary>
    public abstract class Shape
    {
        protected Color shapeColor;
        public Point startPoint {  get; set; }
        public Point endPoint { get; set; }

        public Shape(Color color) 
        {
            shapeColor = color;
        }

        public void SetShapeColor(Color color)
        {
            shapeColor = color;
        }

        public abstract void DrawColoredShape(Graphics g, Point startPoint, Point endPoint);
        public abstract void Resize(int width, int height);
        public abstract Shape CreateNewShape(Color color);
    }
}
