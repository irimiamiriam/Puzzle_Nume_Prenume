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
        bool prim= false;
        private TimeSpan timp;
        private PictureBox currentlyDraggingPictureBox;
        Point curp;

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
                LoadAndDivideImage(selectedImage);
               //RandomizePuzzle();
        }



        private Random random = new Random();

        private void RandomizePuzzle()
        {
            // Shuffle the PictureBox controls in the array
            int n = pictureBoxes.Length;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                PictureBox temp = pictureBoxes[k];
                pictureBoxes[k] = pictureBoxes[n];
                pictureBoxes[n] = temp;
            }


            // Update the positions of the shuffled PictureBox controls on the form
            int index = 0;
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                int row = index / numberOfSquares;
                int col = index % numberOfSquares;
                int x = col * pictureBox.Width ; // Adjust the offset as needed
                int y = row * pictureBox.Height ; // Adjust the offset as needed
                pictureBox.Location = new Point(x, y);
                index++;
            }
        }


        private void LoadAndDivideImage(string imagePath)
        {
            try
            {
                // Load the original image
                int nrp = 0;
                originalImage = new Bitmap(imagePath);

                Bitmap resized = new Bitmap(originalImage, new Size(300, 180));

                // Create an array to hold PictureBox controls
                pictureBoxes = new PictureBox[numberOfSquares * numberOfSquares];

                // Determine the size of each square
                //  double squaresize = Math.Sqrt((resized.Width)*(resized.Height) / numberOfSquares);
                //int squareSize = (int)squaresize;
                int squareSizeH = (resized.Height) / div;
                int squareSizeW = (resized.Width) / div;

                // Divide the image into squares and create PictureBox controls
                for (int row = 0; row < div; row++)
                {
                    for (int col = 0; col < div; col++)
                    {
                       
                        // Calculate the source rectangle for the current square
                        Rectangle sourceRectangle = new Rectangle(col * squareSizeW, row * squareSizeH, squareSizeW, squareSizeH);

                        // Create a new PictureBox control for the current square
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Size = new Size(squareSizeW, squareSizeH);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Image = CropImage(resized, sourceRectangle);
                        pictureBox.Location = new Point(140 + squareSizeW*col +10*col, 100+squareSizeH *row+10*row);

                        PictureBox pictureBox2 = new PictureBox();
                        pictureBox2.Size = new Size(squareSizeW, squareSizeH);
                        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox2.BackColor = Color.LightGray;
                        pictureBox2.Location = new Point(140 + squareSizeW * col + 10 * col, 100 + squareSizeH * row + 10 * row);

                        // Add event handlers for mouse events to enable dragging and dropping
                        pictureBox.MouseDown += PictureBox_MouseDown;
                       pictureBox.MouseMove += PictureBox_MouseMove;
                       pictureBox.MouseUp += PictureBox_MouseUp;

                        // Add the PictureBox control to the form and to the array
                        Controls.Add(pictureBox);
                        Controls.Add(pictureBox2);
                        pictureBoxes[nrp++] = pictureBox;
                     
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
            if (prim == false) { timer1.Start(); prim = true; }
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                PictureBox pictureBox = sender as PictureBox;
                offset = new Point(e.X, e.Y);
                pictureBox.BringToFront(); // Bring the PictureBox to the front
                curp = pictureBox.Location; 
                currentlyDraggingPictureBox = pictureBox;
                currentlyDraggingPictureBox.DoDragDrop(currentlyDraggingPictureBox, DragDropEffects.Move);
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;  
                  } 
        }

        private void PictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void PictureBox_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox targetPictureBox = sender as PictureBox;
            if (targetPictureBox != null && currentlyDraggingPictureBox != null)
            {
                // Swap locations
                Point tempLocation = targetPictureBox.Location;
                targetPictureBox.Location = curp;
                currentlyDraggingPictureBox.Location = tempLocation;
            }
               
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timp = timp.Add(TimeSpan.FromSeconds(1));
            labelT.Text = timp.ToString(@"hh\:mm\:ss");
        }

        
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
