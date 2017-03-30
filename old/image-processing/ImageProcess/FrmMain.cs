using AForge.Imaging;
using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcess
{
    public partial class FrmMain : Form
    {
        public Bitmap currentImage { get; set;}

        public FrmMain()
        {
            InitializeComponent();
        }

        private void exirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            var r = ofd.ShowDialog(this);
            if (r == DialogResult.OK)
            {
                String filename = ofd.FileName;
                if (!File.Exists(filename))
                {
                    MessageBox.Show(this, "Error: File not exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                lblFileName.Text = filename;
                currentImage = (Bitmap) Bitmap.FromFile(filename);
                pictureBox.Image = currentImage ;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            var r = sfd.ShowDialog(this);
            if (r == DialogResult.OK)
            {
                String filename = sfd.FileName;
                try
                {
                    currentImage.Save(filename);
                    lblFileName.Text = filename;
                    MessageBox.Show(this, "Image Saved in " + filename, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void fileToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            saveToolStripMenuItem.Enabled = currentImage != null;
        }

        private void meanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentImage = new ImageProcess.filters.Mean().process(currentImage);
            pictureBox.Image = currentImage;
        }

        private void simpleGrayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentImage = new ImageProcess.filters.Gray().process(currentImage);
            pictureBox.Image = currentImage;
        }

        private void medianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentImage = new ImageProcess.filters.Median(5).process(currentImage);
            pictureBox.Image = currentImage;
        }

        private void thresholdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentImage = new ImageProcess.filters.Threshold(250).process(currentImage);
            pictureBox.Image = currentImage;
        }

        private void medianToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AForge.Imaging.Filters.Median median = new AForge.Imaging.Filters.Median();
            median.ApplyInPlace(currentImage);
            pictureBox.Image = currentImage;
        }

        private void detectObjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var img = (Bitmap)currentImage.Clone();
            var showImg = (Bitmap)currentImage.Clone();
            img = Grayscale.CommonAlgorithms.Y.Apply(img);
            img = new OtsuThreshold().Apply(img);
            img = new Erosion().Apply(img);
            img = new Invert().Apply(img);

            BlobCounter bc = new BlobCounter();
            bc.BackgroundThreshold = Color.Black;            
            bc.ProcessImage(img);
            MessageBox.Show(String.Format("The image contains {0} objects.", bc.ObjectsCount));

            Rectangle rect = new Rectangle(0, 0, showImg.Width, showImg.Height);
            BitmapData bmpData = showImg.LockBits(rect, ImageLockMode.ReadWrite, showImg.PixelFormat);
            
            bc.GetObjectsRectangles().ToList().ForEach(i=>{
                Drawing.Rectangle(bmpData, i, Color.GreenYellow);
            });

            showImg.UnlockBits(bmpData);

            pictureBox.Image = showImg;
        }
    }
}
