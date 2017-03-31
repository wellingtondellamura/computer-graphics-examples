using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImUENP.UI.Filters;

namespace ImUENP.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var res = openFileDialog.ShowDialog();
            if (res != DialogResult.OK)
            {
                return;
            }
            var fn = openFileDialog.FileName;            
            var img = Image.FromFile(fn);
            pictureBox1.Image = img;
            pictureBox1.Refresh();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var res = saveFileDialog.ShowDialog();
            if (res != DialogResult.OK)
            {
                return;
            }
            var fn = saveFileDialog.FileName;
            //if (File.Exists(fn))
            var img = pictureBox1.Image;
            img.Save(fn);
        }

        private void cinzaNTSCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            var img = (Bitmap)pictureBox1.Image;            
            var gray = new Grayscale().Process(img);
            pictureBox1.Image = gray;
            pictureBox1.Refresh();

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            MessageBox.Show(elapsedMs+"ms");
        }

        private void cinzaNTSCPtrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            var img = (Bitmap)pictureBox1.Image;
            var gray = new Grayscale3().Process(img);
            pictureBox1.Image = gray;
            pictureBox1.Refresh();

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            MessageBox.Show(elapsedMs + "ms");
        }

        private void cinzaNTSCMarshallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            var img = (Bitmap)pictureBox1.Image;
            var gray = new Grayscale2().Process(img);
            pictureBox1.Image = gray;
            pictureBox1.Refresh();

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            MessageBox.Show(elapsedMs + "ms");
        }

        private void cinzaNTSC1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            var img = (Bitmap)pictureBox1.Image;
            var gray = new Grayscale1().Process(RGBImage.FromImage(img));
            pictureBox1.Image = gray.ToImage();
            pictureBox1.Refresh();

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            MessageBox.Show(elapsedMs + "ms");
        }

        private void binarizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bmp = pictureBox1.Image;
            var img = RGBImage.FromImage((Bitmap)bmp);
            var bin = new Threshold(127).Process(img);
            pictureBox1.Image = bin.ToImage();
            pictureBox1.Refresh();
        }

        private void multilimiarizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            var bmp = pictureBox1.Image;
            var img = RGBImage.FromImage((Bitmap)bmp);
            var bin = new MultiThreshold(
                new ThresholdPoint(0, 80, new RGB(0, 255, 0)),
                new ThresholdPoint(80, 200, new RGB(255, 0, 0)),
                new ThresholdPoint(200, 230, new RGB(0, 0, 255)),
                new ThresholdPoint(230, 255, new RGB(255, 0, 255))
            ).Process(img);
            pictureBox1.Image = bin.ToImage();
            pictureBox1.Refresh();

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            MessageBox.Show(elapsedMs + "ms");
        }

        private void médiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            var img = (Bitmap)pictureBox1.Image;
            var gray = new Average(3).Process(RGBImage.FromImage(img));
            pictureBox1.Image = gray.ToImage();
            pictureBox1.Refresh();

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            MessageBox.Show(elapsedMs + "ms");
        }

        private void medianaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            var img = (Bitmap)pictureBox1.Image;
            var gray = new Median(3).Process(RGBImage.FromImage(img));
            pictureBox1.Image = gray.ToImage();
            pictureBox1.Refresh();

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            MessageBox.Show(elapsedMs + "ms");
        }
    }
}
