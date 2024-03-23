using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PAINT_FINAL
{

    public partial class Form1 : Form
    {
        Graphics g;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;
        Pen pen1;
        private PictureBox pictureBox;
        private Color drawingColor = Color.Black;
        private int penThickness = 5;
        private List<PictureBox> pictureBoxes = new List<PictureBox>();
        private bool isDragging = false;
        private Point lastMousePosition;
        private PictureBox selectedPictureBox = null;
        bool PenClicked = false;
       
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            
            pen1 = new Pen(Color.Black,5);
            
            int width, height;
            width = Math.Abs(e.X - x);
            height = Math.Abs(e.Y - y);
            if (Ellipse.Checked  && moving && x != -1 && y != -1)
            {  
                PenClicked = false;
                g.DrawEllipse(pen1, x, y, e.X - x, e.Y - y);         
            }
            else if (Rectangle.Checked && moving && x != -1 && y != -1 )
            {
                PenClicked = false;
                g.DrawRectangle(pen1, x, y, e.X - x, e.Y - y);
            }
            else if (Line.Checked  && moving && x != -1 && y != -1)
            {
                PenClicked = false;
                g.DrawLine(pen1, x, y, e.X, e.Y);
            }
            else if (Triangle.Checked  && moving && x != -1 && y != -1 ) 
            {
                PenClicked = false;
                Point[] trianglePoints = new Point[]
                    {
                        new Point(x, y),        // Vertex 1
                        new Point(e.X, e.Y),    // Vertex 2 (current mouse position)
                        new Point(x, e.Y)       // Vertex 3 (same X coordinate as the starting point, Y coordinate of the current mouse position)
                    };
                // Draw the triangle
                g.DrawPolygon(pen1, trianglePoints);
            } 
            moving = false;
            x = -1;
            y = -1;
        }    
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1)
            {

                if (PenClicked == true)
                {
                    g.DrawLine(pen, new Point(x, y), e.Location);
                    x = e.X;
                    y = e.Y;
                }
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;         
        }
        private void Colors_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = drawingColor; // Set initial color to the current drawing color
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Update drawing color
                drawingColor = colorDialog.Color;
                pen.Color = drawingColor;
                pen1.Color = drawingColor;
            }
        }
        private void Pen_Click(object sender, EventArgs e)
        {
            PenClicked = true;
            pen = new Pen(drawingColor, penThickness);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            Ellipse.Checked = false;
            Rectangle.Checked = false;
            Line.Checked = false;
            Triangle.Checked = false;
        }
        private void Eraser_Click(object sender, EventArgs e)
        {
            pen = new Pen(panel1.BackColor, penThickness);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }     
        private void Background_Click(object sender, EventArgs e)
        {
            panel1.BackColor = drawingColor;
        }
        private void EraseAll_Click(object sender, EventArgs e)
        {
            Refresh();
        }
        private void AddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load the selected image file
                    string filePath = openFileDialog.FileName;
                    Image originalImage = Image.FromFile(filePath);

                    int maxWidth = 500; // Set your desired maximum width
                    int maxHeight = 500; // Set your desired maximum height                  
                    // Calculate the new dimensions while preserving aspect ratio
                    int newWidth, newHeight;
                    if (originalImage.Width > originalImage.Height)
                    {
                        newWidth = maxWidth;
                        newHeight = (int)((float)originalImage.Height / originalImage.Width * maxWidth);
                    }
                    else
                    {
                        newWidth = (int)((float)originalImage.Width / originalImage.Height * maxHeight);
                        newHeight = maxHeight;
                    }
                    // Resize the image
                    Image resizedImage = new Bitmap(originalImage, newWidth, newHeight);
                    // Create a new PictureBox
                    pictureBox = new PictureBox();
                    pictureBox.SizeMode = PictureBoxSizeMode.AutoSize; // Adjust this as needed
                    pictureBox.Image = resizedImage;
                    // Add event handlers to enable dragging
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    // Add the PictureBox to the form's controls collection
                    Controls.Add(pictureBox);
                    pictureBox.BringToFront(); // Bring the PictureBox to the front
                    pictureBoxes.Add(pictureBox);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }
        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {

            
            isDragging = true;
            lastMousePosition = e.Location;
            selectedPictureBox = (PictureBox)sender;
        }
        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && selectedPictureBox != null)
            {
                int deltaX = e.Location.X - lastMousePosition.X;
                int deltaY = e.Location.Y - lastMousePosition.Y;

                selectedPictureBox.Left += deltaX;
                selectedPictureBox.Top += deltaY;
            }
        }
        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
                selectedPictureBox = null;
            }
        }     
        private void NewCanvas_Click(object sender, EventArgs e)
        {
            // Clear all drawings from the canvas
            panel1.Refresh();
            // Reset the background color of the canvas to its normal state
            panel1.BackColor = SystemColors.Control;
            // Remove all PictureBox controls from the form
            foreach (Control control in Controls)
            {
                if (control is PictureBox)
                {
                    Controls.Remove(control);
                    control.Dispose();
                }
            }
        }       
        private void Thickness_Scroll(object sender, EventArgs e)
        {
            penThickness = Thickness.Value;
            pen.Width = penThickness;
        }

          
    }
}
