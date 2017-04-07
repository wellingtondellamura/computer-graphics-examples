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
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnOCR_Click(object sender, EventArgs e)
        {
            var datapath = @"tessdata";
            var lang = "por";
            var img = (Bitmap) pictureBox.Image;
            var ocr = new TesseractEngine(datapath, lang, EngineMode.TesseractOnly);
            var page = ocr.Process(img);
            txtText.Text = page.GetText();
        }
    }
}
