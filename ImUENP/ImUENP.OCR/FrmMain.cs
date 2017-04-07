using AForge.Imaging;
using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace ImUENP.OCR
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnOCR_Click(object sender, EventArgs e)
        {
            var datapath = @"tessdata";
            var lang = "por";
            var img = (Bitmap) pictureBox.Image;
           
            //Cinza
            img = Grayscale.CommonAlgorithms.Y.Apply(img);
            //Mediana
            img = new Median(3).Apply(img);
            //Otsu
            img = new OtsuThreshold().Apply(img);

            var ocr = new TesseractEngine(datapath, lang, EngineMode.TesseractOnly);
            var page = ocr.Process(img);
            txtText.Text = page.GetText();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var img = (Bitmap)pictureBox.Image;
            img = new Invert().Apply(img);
            BlobCounter bc = new BlobCounter();
            bc.ProcessImage(img);
            var blobs = bc.GetObjectsRectangles();
            MessageBox.Show("Objetos: " + blobs.Length);
        }
    }
}
