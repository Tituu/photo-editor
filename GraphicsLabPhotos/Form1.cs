using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GraphicsLabPhotos
{
    public partial class photoEditorForm : Form
    {
        public Bitmap imageBitmap;
        public Bitmap backup = null;
        Tools toolbox = null;

        public photoEditorForm()
        {
            InitializeComponent();
            progressBar.Value = 0;
            progressBar.Minimum = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                imageBitmap = new Bitmap(Image.FromFile(openFileDialog1.FileName));
                backup = new Bitmap(Image.FromFile(openFileDialog1.FileName));
                progressBar.Maximum = imageBitmap.Width * imageBitmap.Height;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolbox = new Tools();
            toolbox.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (toolbox != null && imageBitmap != null)
            {
                if (toolbox.Red != 0 || toolbox.Green != 0 || toolbox.Blue != 0)
                    changeColors();
                if (toolbox.Contrast != 0)
                    changeContrast();
                if (toolbox.Brightness != 0)
                    changeBrightness();


                pictureBox.Image = imageBitmap;
            }
        }

        private void changeColors()
        {
            int progress = 0;
            progressBar.Visible = true;
            for (int i = 0; i < imageBitmap.Width; i++)
            {
                for (int j = 0; j < imageBitmap.Height; j++)
                {
                    progress++;
                    progressBar.Value = progress;
                    progressBar.Update();

                    Color color = imageBitmap.GetPixel(i, j);
                    int r = color.R;
                    int g = color.G;
                    int b = color.B;
                    r += toolbox.Red;
                    g += toolbox.Green;
                    b += toolbox.Blue;
                    if (r >= 255) r = 255;
                    if (g >= 255) g = 255;
                    if (b >= 255) b = 255;
                    if (r < 0) r = 0;
                    if (g < 0) g = 0;
                    if (b < 0) b = 0;
                    color = Color.FromArgb(r, g, b);
                    imageBitmap.SetPixel(i, j, color);
                }
            }
            progressBar.Visible = false;
        }

        private void changeContrast()
        {
            int progress = 0;
            progressBar.Visible = true;

            for (int i = 0; i < imageBitmap.Width; i++)
            {
                for (int j = 0; j < imageBitmap.Height; j++)
                {
                    progress++;
                    progressBar.Value = progress;
                    progressBar.Update();

                    Color color = imageBitmap.GetPixel(i, j);
                    double contrast = 1;
                    contrast += toolbox.Contrast;
                    int r = color.R;
                    int g = color.G;
                    int b = color.B;

                    r = r - 128;
                    g = g - 128;
                    b = b - 128;

                    r = (int)(r * contrast);
                    g = (int)(g * contrast);
                    b = (int)(b * contrast);

                    r = r + 128;
                    g = g + 128;
                    b = b + 128;

                    if (r >= 255) r = 255;
                    if (g >= 255) g = 255;
                    if (b >= 255) b = 255;
                    if (r < 0) r = 0;
                    if (g < 0) g = 0;
                    if (b < 0) b = 0;

                    color = Color.FromArgb(r, g, b);
                    imageBitmap.SetPixel(i, j, color);
                }
            }
            progressBar.Visible = false;

        }

        private void changeBrightness()
        {
            int progress = 0;
            progressBar.Visible = true;

            for (int i = 0; i < imageBitmap.Width; i++)
            {
                for (int j = 0; j < imageBitmap.Height; j++)
                {
                    progress++;
                    progressBar.Value = progress;
                    progressBar.Update();

                    Color color = imageBitmap.GetPixel(i, j);

                    int r = color.R + toolbox.Brightness;
                    int g = color.G + toolbox.Brightness;
                    int b = color.B + toolbox.Brightness;

                    if (r >= 255) r = 255;
                    if (g >= 255) g = 255;
                    if (b >= 255) b = 255;
                    if (r < 0) r = 0;
                    if (g < 0) g = 0;
                    if (b < 0) b = 0;

                    color = Color.FromArgb(r, g, b);
                    imageBitmap.SetPixel(i, j, color);
                }
            }
            progressBar.Visible = false;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void greyScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (imageBitmap != null)
            {
                int progress = 0;
                progressBar.Visible = true;

                for (int i = 0; i < imageBitmap.Width; i++)
                {
                    for (int j = 0; j < imageBitmap.Height; j++)
                    {
                        progress++;
                        progressBar.Value = progress;
                        progressBar.Update();

                        Color color = imageBitmap.GetPixel(i, j);

                        int r = color.R;
                        int g = color.G;
                        int b = color.B;

                        int gray = gray = (int)(0.299 * r + 0.587 * g + 0.114 * b);
                        r = g = b = gray;

                        color = Color.FromArgb(r, g, b);
                        imageBitmap.SetPixel(i, j, color);
                    }
                }
                progressBar.Visible = false;
                pictureBox.Image = imageBitmap;
            }
        }

        private void negetiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageBitmap != null)
            {
                int progress = 0;
                progressBar.Visible = true;

                for (int i = 0; i < imageBitmap.Width; i++)
                {
                    for (int j = 0; j < imageBitmap.Height; j++)
                    {
                        progress++;
                        progressBar.Value = progress;
                        progressBar.Update();

                        Color color = imageBitmap.GetPixel(i, j);

                        int r = color.R;
                        int g = color.G;
                        int b = color.B;

                        color = Color.FromArgb(255 - r, 255 - g, 255 - b);
                        imageBitmap.SetPixel(i, j, color);
                    }
                }
                progressBar.Visible = false;
                pictureBox.Image = imageBitmap;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            imageBitmap = (Bitmap)backup.Clone();
            pictureBox.Image = imageBitmap;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveFileDialog1.Filter = "Images|*.png;*.bmp;*.jpg";
                ImageFormat format = ImageFormat.Png;

                string ext = System.IO.Path.GetExtension(saveFileDialog1.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                    default:
                        format = ImageFormat.Bmp;
                        break;
                }
                pictureBox.Image.Save(saveFileDialog1.FileName, format);

            }
        }
    }

}
