using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsLabPhotos
{
    public partial class Tools : Form
    {
       
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public double Contrast { get; set; }
        public int Brightness { get; set; }


        public Tools()
        {
            InitializeComponent();
            textBoxRed.Text = trackBarRed.Value.ToString();
            textBoxGreen.Text = trackBarGreen.Value.ToString();
            textBoxBlue.Text = trackBarBlue.Value.ToString();
            textBoxContrast.Text = trackBarContrast.Value.ToString();
            trackBarBrightness.Text = trackBarBrightness.Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            textBoxRed.Text = trackBarRed.Value.ToString();
            Red = trackBarRed.Value;
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            textBoxBlue.Text = trackBarBlue.Value.ToString();
            Blue = trackBarBlue.Value;
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            textBoxGreen.Text = trackBarGreen.Value.ToString();
            Green = trackBarGreen.Value;
        }

        private void trackBarContrast_Scroll(object sender, EventArgs e)
        {
            
            textBoxContrast.Text = trackBarContrast.Value.ToString();
            if (trackBarContrast.Value > 0)
                Contrast = trackBarContrast.Value;
            else Contrast = Math.Abs(trackBarContrast.Value) * 0.1;
        }

        private void trackBarBrightness_Scroll(object sender, EventArgs e)
        {
            textBoxBrightness.Text = trackBarBrightness.Value.ToString();
            Brightness = trackBarBrightness.Value;
        }

        private void textBoxRed_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(textBoxRed.Text) < 129 && Int32.Parse(textBoxRed.Text) > -128)
                    trackBarRed.Value = Int32.Parse(textBoxRed.Text);
                else if (Int32.Parse(textBoxRed.Text) < -128)
                    trackBarRed.Value = -127;
                else trackBarRed.Value = 128;
                Red = trackBarRed.Value;
            }
            catch { };
        }

        private void textBoxGreen_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(textBoxGreen.Text) < 129 && Int32.Parse(textBoxGreen.Text) > -128)
                    trackBarGreen.Value = Int32.Parse(textBoxGreen.Text);
                else if (Int32.Parse(textBoxGreen.Text) < -128)
                    trackBarGreen.Value = -127;
                else trackBarGreen.Value = 128;
                Green = trackBarGreen.Value;
            }
            catch { };
        }

        private void textBoxBlue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(textBoxBlue.Text) < 129 && Int32.Parse(textBoxBlue.Text) > -128)
                    trackBarBlue.Value = Int32.Parse(textBoxBlue.Text);
                else if (Int32.Parse(textBoxGreen.Text) < -128)
                    trackBarBlue.Value = -127;
                else trackBarBlue.Value = 128;
                Blue = trackBarBlue.Value;
            }
            catch { };
        }


        private void textBoxContrast_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(textBoxContrast.Text) < 129 && Int32.Parse(textBoxContrast.Text) > -128)
                    trackBarContrast.Value = Int32.Parse(textBoxContrast.Text);
                else if (Int32.Parse(textBoxContrast.Text) < -128)
                    trackBarContrast.Value = -127;
                else trackBarContrast.Value = 128;
            }
            catch { };
        }

        private void textBoxBrightness_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(textBoxBrightness.Text) < 100 && Int32.Parse(textBoxBrightness.Text) > -100)
                    trackBarBrightness.Value = Int32.Parse(textBoxBrightness.Text);
                else if (Int32.Parse(textBoxBrightness.Text) < -100)
                    trackBarBrightness.Value = -100;
                else trackBarBrightness.Value = 100;
            }
            catch { };
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
