namespace DrawingProgram
{
    /// <summary>
    /// Partial Class <c>DrawingForm</c> represents the main form for the Drawing Program.
    /// </summary>
    public partial class DrawingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lineButton = new Button();
            rectangleButton = new Button();
            ellipseButton = new Button();
            pictureBox = new PictureBox();
            rgb_label = new Label();
            red_trackBar = new TrackBar();
            green_trackBar = new TrackBar();
            blue_trackBar = new TrackBar();
            clearButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)red_trackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)green_trackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blue_trackBar).BeginInit();
            SuspendLayout();
            // 
            // lineButton
            // 
            lineButton.Location = new Point(12, 21);
            lineButton.Name = "lineButton";
            lineButton.Size = new Size(75, 23);
            lineButton.TabIndex = 0;
            lineButton.Text = "Line";
            lineButton.UseVisualStyleBackColor = true;
            lineButton.Click += LineButton_Click;
            // 
            // rectangleButton
            // 
            rectangleButton.Location = new Point(93, 21);
            rectangleButton.Name = "rectangleButton";
            rectangleButton.Size = new Size(75, 23);
            rectangleButton.TabIndex = 1;
            rectangleButton.Text = "Rectangle";
            rectangleButton.UseVisualStyleBackColor = true;
            rectangleButton.Click += RectangleButton_Click;
            // 
            // ellipseButton
            // 
            ellipseButton.Location = new Point(174, 21);
            ellipseButton.Name = "ellipseButton";
            ellipseButton.Size = new Size(75, 23);
            ellipseButton.TabIndex = 2;
            ellipseButton.Text = "Ellipse";
            ellipseButton.UseVisualStyleBackColor = true;
            ellipseButton.Click += EllipseButton_Click;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = SystemColors.ControlLightLight;
            pictureBox.Location = new Point(12, 61);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(776, 377);
            pictureBox.TabIndex = 3;
            pictureBox.TabStop = false;
            pictureBox.Paint += PictureBox_Paint;
            pictureBox.MouseDown += PictureBox_MouseDown;
            pictureBox.MouseMove += PictureBox_MouseMove;
            pictureBox.MouseUp += PictureBox_MouseUp;
            // 
            // rgb_label
            // 
            rgb_label.AutoSize = true;
            rgb_label.Location = new Point(356, 10);
            rgb_label.Name = "rgb_label";
            rgb_label.Size = new Size(29, 15);
            rgb_label.TabIndex = 4;
            rgb_label.Text = "RGB";
            // 
            // red_trackBar
            // 
            red_trackBar.BackColor = Color.Red;
            red_trackBar.Location = new Point(435, 10);
            red_trackBar.Name = "red_trackBar";
            red_trackBar.Size = new Size(104, 45);
            red_trackBar.TabIndex = 5;
            red_trackBar.ValueChanged += TrackBar_ValueChange;
            // 
            // green_trackBar
            // 
            green_trackBar.BackColor = Color.Green;
            green_trackBar.Location = new Point(555, 10);
            green_trackBar.Name = "green_trackBar";
            green_trackBar.Size = new Size(104, 45);
            green_trackBar.TabIndex = 6;
            green_trackBar.ValueChanged += TrackBar_ValueChange;
            // 
            // blue_trackBar
            // 
            blue_trackBar.BackColor = Color.Blue;
            blue_trackBar.Location = new Point(674, 10);
            blue_trackBar.Name = "blue_trackBar";
            blue_trackBar.Size = new Size(104, 45);
            blue_trackBar.TabIndex = 7;
            blue_trackBar.ValueChanged += TrackBar_ValueChange;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(255, 21);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 8;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearButton_Click;
            // 
            // DrawingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(clearButton);
            Controls.Add(blue_trackBar);
            Controls.Add(green_trackBar);
            Controls.Add(red_trackBar);
            Controls.Add(rgb_label);
            Controls.Add(pictureBox);
            Controls.Add(ellipseButton);
            Controls.Add(rectangleButton);
            Controls.Add(lineButton);
            Name = "DrawingForm";
            Text = "Drawing Program";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)red_trackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)green_trackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)blue_trackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button lineButton;
        private Button rectangleButton;
        private Button ellipseButton;
        private PictureBox pictureBox;
        private Label rgb_label;
        private TrackBar red_trackBar;
        private TrackBar green_trackBar;
        private TrackBar blue_trackBar;
        private Button clearButton;
    }
}
