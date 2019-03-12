using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualPhoton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void openbut_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Bitmap.FromFile(open.FileName);
                if (pictureBox1.Image.HorizontalResolution < pictureBox1.Size.Width)
                {
                    if (pictureBox1.Image.VerticalResolution < pictureBox1.Size.Height)
                    {
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                        pictureBox1.Image = Bitmap.FromFile(open.FileName);

                    }
                    if (pictureBox1.Image.VerticalResolution >= pictureBox1.Size.Height)
                    {
                        pictureBox1.SizeMode = PictureBoxSizeMode.Normal;

                        pictureBox1.Image = Bitmap.FromFile(open.FileName);

                    }

                }
                if (pictureBox1.Image.HorizontalResolution >= pictureBox1.Size.Width)
                {
                    if (pictureBox1.Image.VerticalResolution < pictureBox1.Size.Height)
                    {
                        pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

                        pictureBox1.Image = Bitmap.FromFile(open.FileName);

                    }
                    if (pictureBox1.Image.VerticalResolution >= pictureBox1.Size.Height)
                    {
                        pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

                        pictureBox1.Image = Bitmap.FromFile(open.FileName);

                    }

                }

            } 
        }
    }
}
