using System.Net;

namespace DrawingProgram
{
    /// <summary>
    /// Partial Class <c>DrawingForm</c> represents the main form for the Drawing Program.
    /// </summary>
    public partial class DrawingForm : Form
    {
        private Shape? currentShape; // Set currentShape as null initially
        private Color currentColor = Color.Black; // Default color
        private List<Shape> shapes = new List<Shape>(); // List to store shapes that are drawn
        private Point startPoint;
        private Point endPoint;
        private bool isDrawing = false;
        
        private Bitmap bufferBitmap;
        private Graphics bufferGraphics;
        private Label rgbLabel; // Display RGB values

        public DrawingForm()
        {
            InitializeComponent();

            // Initialize the buffer for double buffing
            bufferBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            bufferGraphics = Graphics.FromImage(bufferBitmap);
            bufferGraphics.Clear(Color.White);
            pictureBox.Image = bufferBitmap;

            // Initialize RGB TrackBars values and increments
            red_trackBar.Minimum = 0;
            red_trackBar.Maximum = 255;
            red_trackBar.SmallChange = 5;
            red_trackBar.LargeChange = 20;

            green_trackBar.Minimum = 0;
            green_trackBar.Maximum = 255;
            green_trackBar.SmallChange = 5;
            green_trackBar.LargeChange = 20;

            blue_trackBar.Minimum = 0;
            blue_trackBar.Maximum = 255;
            blue_trackBar.SmallChange = 5;
            blue_trackBar.LargeChange = 20;

            // Create and set up the RGB label
            rgbLabel = new Label();
            rgbLabel.Location = new Point(335, 35);
            rgbLabel.Size = new Size(150, 15);
            rgbLabel.Text = "R: 0, G: 0, B: 0"; // Initial RGB Values
            Controls.Add(rgbLabel);

        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            currentShape = new Line(currentColor);
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            currentShape = new Rectangle(currentColor);
        }

        private void EllipseButton_Click(object sender, EventArgs e)
        {
            currentShape = new Ellipse(currentColor);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            shapes.Clear();
            pictureBox.Invalidate();
        }

        // Method for event handler drawing in the PictureBox
        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            // Clear the buffer
            bufferGraphics.Clear(Color.White);

            // Draw existing shape
            foreach (Shape shape in shapes)
            {
                shape.DrawColoredShape(bufferGraphics, shape.startPoint, shape.endPoint);
            }

            // Draw the currentShape
            if (isDrawing && currentShape != null)
            {
                currentShape.DrawColoredShape(bufferGraphics, currentShape.startPoint, currentShape.endPoint);
            }

            e.Graphics.DrawImage(bufferBitmap, 0, 0); // Draw buffer to PictureBox
        }

        // Method to update the end point of currentShape while drawing
        private void UpdateEndPoint(Point newEndPoint)
        {
            if (currentShape != null)
            {
                currentShape.endPoint = newEndPoint;
            }
        }

        // Method for PictureBox mouse down event handler 
        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
            isDrawing = true;

            if (currentShape != null)
            {
                currentShape = currentShape.CreateNewShape(currentColor);
                currentShape.startPoint = startPoint;
                currentShape.endPoint = startPoint;

            }
        }

        // Method for PictureBox mouse move event handler 
        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                UpdateEndPoint(e.Location);
                pictureBox.Invalidate();
            }
        }

        // Method for PictureBox mouse up event handler 
        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                endPoint = e.Location;
                isDrawing = false;

                if (currentShape != null)
                {
                    shapes.Add(currentShape);
                }

                pictureBox.Invalidate(); // Allow repaint for the next shape
            }
        }

        // Method for the RGB track bar event handler 
        private void TrackBar_ValueChange(object sender, EventArgs e)
        {
            currentColor = Color.FromArgb(red_trackBar.Value, green_trackBar.Value, blue_trackBar.Value);

            // Print current RGB values 
            rgbLabel.Text = $"R: {red_trackBar.Value}, G: {green_trackBar.Value}, B: {blue_trackBar.Value}";
        }
    }
}
