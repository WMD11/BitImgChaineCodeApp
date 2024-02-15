using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitImgChaineCodeApp
{
    public partial class Form1 : Form

    {

        private int[] directionsX = { 1, 1, 0, -1, -1, -1, 0, 1 };
        private int[] directionsY = { 0, -1, -1, -1, 0, 1, 1, 1 };

        public Form1()
        {
            InitializeComponent();
            InitializeUI();

        }

        private void InitializeUI()
        {
            // Inițializează elementele UI aici
            // Adaugă evenimentele pentru butoane
            LoadImage1Button.Click += LoadImage1Button_Click;
            GenerateChainCode1Button.Click += GenerateChainCode1Button_Click;
            LoadImage2Button.Click += LoadImage2Button_Click;
            GenerateChainCode2Button.Click += GenerateChainCode2Button_Click;
            ApplyLogicalOperationButton.Click += ApplyLogicalOperationButton_Click;
            ConvertToBinaryImageButton.Click += ConvertToBinaryImageButton_Click;
            SaveResultButton.Click += SaveResultButton_Click;

        }

        private void LoadImage1Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imagini (*.bmp, *.png, *.jpg, *.jpeg)|*.bmp;*.png;*.jpg;*.jpeg|Toate fișierele (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Încarcă imaginea folosind Bitmap
                    Bitmap image1 = new Bitmap(openFileDialog.FileName);

                    // Verifică dacă imaginea este alb-negru (1 bit) sau tonuri de gri (8 biți)
                    if (ImageIsBinary(image1))
                    {
                        // Afișează imaginea în PictureBox1
                        pictureBox1.Image = image1;
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                        // Adaugă codul suplimentar pentru a gestiona chain code-ul imaginii 1, dacă este necesar
                        // Chain code-ul poate fi generat și afișat în TextBox-ul corespunzător
                    }
                    else
                    {
                        MessageBox.Show("Imaginea trebuie să fie alb-negru (1 bit) sau tonuri de gri (8 biți).", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la încărcarea imaginii: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ImageIsBinary(Bitmap image)
        {
            if (image.PixelFormat == System.Drawing.Imaging.PixelFormat.Format1bppIndexed ||
                image.PixelFormat == System.Drawing.Imaging.PixelFormat.Format8bppIndexed)
            {
                return true;
            }
            else if (image.PixelFormat == System.Drawing.Imaging.PixelFormat.Format24bppRgb ||
                     image.PixelFormat == System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            {
                // Verifică dacă este o imagine gri (toate canalele de culoare sunt egale)
                for (int x = 0; x < image.Width; x++)
                {
                    for (int y = 0; y < image.Height; y++)
                    {
                        System.Drawing.Color pixelColor = image.GetPixel(x, y);
                        if (pixelColor.R != pixelColor.G || pixelColor.G != pixelColor.B)
                        {
                            return false; // Imaginea nu este gri
                        }
                    }
                }
                return true; // Imaginea este gri
            }

            return false; // Alte formate de pixel
        }

        private void GenerateChainCode1Button_Click(object sender, EventArgs e)
        {
            // Verifică dacă există o imagine în PictureBox1
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Încărcați o imagine înainte de a genera chain code-ul.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obține imaginea din PictureBox1
            Bitmap image1 = new Bitmap(pictureBox1.Image);

            // Verifică dacă imaginea este alb-negru (1 bit) sau tonuri de gri (8 biți)
            if (!ImageIsBinary(image1))
            {
                MessageBox.Show("Imaginea trebuie să fie alb-negru (1 bit) sau tonuri de gri (8 biți).", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Generare chain code pentru imaginea 1
            string chainCode1 = GenerateChainCode(image1);

            // Afișează chain code-ul în TextBox-ul corespunzător
            chainCode1TextBox.Text = chainCode1;
        }
        private string GenerateChainCode(Bitmap image)
        {
            Bitmap binaryImage = ConvertToBinary(image);
            Point startPoint = FindStartPoint(binaryImage);

            if (startPoint == Point.Empty)
            {
                MessageBox.Show("Obiectul nu a fost găsit în imagine.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }

            StringBuilder chainCode = new StringBuilder();
            int currentX = startPoint.X;
            int currentY = startPoint.Y;
            int currentDirection = 0;

            do
            {
                int nextDirection = FindNextDirection(binaryImage, currentX, currentY, currentDirection);
                chainCode.Append(nextDirection);
                currentDirection = nextDirection;

                int[] delta = { directionsX[currentDirection], directionsY[currentDirection] };
                currentX += delta[0];
                currentY += delta[1];

            } while (currentX != startPoint.X || currentY != startPoint.Y);

            return chainCode.ToString();
        }

        private Bitmap ConvertToBinary(Bitmap image)
        {
            // Convertim imaginea la alb-negru
            Bitmap binaryImage = new Bitmap(image.Width, image.Height);

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    System.Drawing.Color pixelColor = image.GetPixel(x, y);
                    int grayscaleValue = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);

                    if (grayscaleValue < 128)
                    {
                        binaryImage.SetPixel(x, y, System.Drawing.Color.Black);
                    }
                    else
                    {
                        binaryImage.SetPixel(x, y, System.Drawing.Color.White);
                    }
                }
            }

            return binaryImage;
        }

        private Point FindStartPoint(Bitmap image)
        {
            // Găsim primul pixel negru în imagine (punctul de start al conturului)
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    if (image.GetPixel(x, y) == System.Drawing.Color.Black)
                    {
                        return new Point(x, y);
                    }
                }
            }

            return Point.Empty; // Nu am găsit un punct de start valid
        }

        private int FindNextDirection(Bitmap image, int x, int y, int currentDirection)
        {
            for (int i = 0; i < 8; i++)
            {
                int nextDirection = (currentDirection + i) % 8;
                int nextX = x + directionsX[nextDirection];
                int nextY = y + directionsY[nextDirection];

                if (nextX >= 0 && nextX < image.Width && nextY >= 0 && nextY < image.Height && image.GetPixel(nextX, nextY) == System.Drawing.Color.Black)
                {
                    return nextDirection;
                }
            }

            return currentDirection;
        }


        private void LoadImage2Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imagini (*.bmp, *.png, *.jpg, *.jpeg)|*.bmp;*.png;*.jpg;*.jpeg|Toate fișierele (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Încarcă imaginea folosind Bitmap
                    Bitmap image2 = new Bitmap(openFileDialog.FileName);

                    // Verifică dacă imaginea este alb-negru (1 bit) sau tonuri de gri (8 biți)
                    if (ImageIsBinary(image2))
                    {
                        // Afișează imaginea în PictureBox2
                        pictureBox2.Image = image2;
                        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

                        // Adaugă codul suplimentar pentru a gestiona chain code-ul imaginii 2, dacă este necesar
                        // Chain code-ul poate fi generat și afișat în TextBox-ul corespunzător
                    }
                    else
                    {
                        MessageBox.Show("Imaginea trebuie să fie alb-negru (1 bit) sau tonuri de gri (8 biți).", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la încărcarea imaginii: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void GenerateChainCode2Button_Click(object sender, EventArgs e)
        {
            // Implementează codul pentru a genera chain code-ul pentru a doua imagine
            // Afișează rezultatul în TextBox-ul corespunzător
        }

        private void ApplyLogicalOperationButton_Click(object sender, EventArgs e)
        {
            // Implementează codul pentru a gestiona operațiile logice selectate
            // Afișează rezultatul în TextBox-ul corespunzător
        }

        private void ConvertToBinaryImageButton_Click(object sender, EventArgs e)
        {
            // Implementează codul pentru a converti chain code-ul rezultat în imagine binară
            // Afișează rezultatul în PictureBox-ul corespunzător
        }

        private void SaveResultButton_Click(object sender, EventArgs e)
        {
            // Implementează codul pentru a salva chain code-ul rezultat într-un fișier text
            // Poți utiliza SaveFileDialog pentru a permite utilizatorului să selecteze locația și numele fișierului.
        }
    }
}