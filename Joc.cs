using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Puzzle_Nume_Prenume
{
    public partial class Joc : Form
    {
        string selectedImage;
        int numberOfSquares,div;
        private Bitmap originalImage;
        private PictureBox[] pictureBoxes;
        private bool isDragging = false;
        private Point offset;

        public Joc()
        {
            InitializeComponent();
           
        }

        private void Joc_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Select File";
            openFileDialog.InitialDirectory = @"C:\Users\irimiapc2\OneDrive\Documente\GIT\Git Miriam\Puzzle_Nume_Prenume\Resurse\Img\";
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImage = openFileDialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
               if(button4.Checked) { numberOfSquares = 4; div = 2; }
                else if (button9.Checked) {  numberOfSquares = 9; div = 3; }
                // Load the original image
                LoadAndDivideImage(selectedImage);
        }

        private void LoadAndDivideImage(string imagePath)
        {
            try
            {
                // Load the original image
                originalImage = new Bitmap(imagePath);

                Bitmap resized = new Bitmap(originalImage, new Size(300, 180));

                // Create an array to hold PictureBox controls
                pictureBoxes = new PictureBox[numberOfSquares * numberOfSquares];

                // Determine the size of each square
                double squaresize = Math.Sqrt((resized.Width)*(resized.Height) / numberOfSquares);
                int squareSize = (int)squaresize;
                // Divide the image into squares and create PictureBox controls
                for (int row = 0; row < div; row++)
                {
                    for (int col = 0; col < div; col++)
                    {
                        // Calculate the source rectangle for the current square
                        Rectangle sourceRectangle = new Rectangle(col * squareSize, row * squareSize, squareSize, squareSize);

                        // Create a new PictureBox control for the current square
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Size = new Size(squareSize, squareSize);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Image = CropImage(resized, sourceRectangle);
                        pictureBox.Location = new Point(140 + squareSize*col +60*col, 100+squareSize*row+60*row);

                        // Add event handlers for mouse events to enable dragging and dropping
                       pictureBox.MouseDown += PictureBox_MouseDown;
                       pictureBox.MouseMove += PictureBox_MouseMove;
                       pictureBox.MouseUp += PictureBox_MouseUp;

                        // Add the PictureBox control to the form and to the array
                        Controls.Add(pictureBox);
                        pictureBoxes[row * numberOfSquares + col] = pictureBox;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading and dividing image: " + ex.Message);
            }
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                PictureBox pictureBox = sender as PictureBox;
                Point newLocation = pictureBox.Parent.PointToClient(Control.MousePosition);
                newLocation.Offset(-offset.X, -offset.Y);
                pictureBox.Location = newLocation;
            }
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                PictureBox pictureBox = sender as PictureBox;
                offset = new Point(e.X, e.Y);
                pictureBox.BringToFront(); // Bring the PictureBox to the front
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        // Method to crop a portion of the original image
        private Bitmap CropImage(Bitmap source, Rectangle section)
        {
            Bitmap croppedImage = new Bitmap(section.Width, section.Height);
            using (Graphics g = Graphics.FromImage(croppedImage))
            {
                g.DrawImage(source, 0, 0, section, GraphicsUnit.Pixel);
            }
            return croppedImage;
        }

    }
}
