namespace ImUENP.UI
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cinzaNTSCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cinzaNTSCPtrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cinzaNTSCMarshallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cinzaNTSC1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarizaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multilimiarizaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.aforgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 543);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp.Properties.Resources._174226679;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(925, 613);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.filtrosToolStripMenuItem,
            this.aforgeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(638, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(102, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // filtrosToolStripMenuItem
            // 
            this.filtrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cinzaNTSCToolStripMenuItem,
            this.cinzaNTSCPtrToolStripMenuItem,
            this.cinzaNTSCMarshallToolStripMenuItem,
            this.cinzaNTSC1ToolStripMenuItem,
            this.binarizaçãoToolStripMenuItem,
            this.multilimiarizaçãoToolStripMenuItem,
            this.médiaToolStripMenuItem,
            this.medianaToolStripMenuItem});
            this.filtrosToolStripMenuItem.Name = "filtrosToolStripMenuItem";
            this.filtrosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.filtrosToolStripMenuItem.Text = "Filtros";
            // 
            // cinzaNTSCToolStripMenuItem
            // 
            this.cinzaNTSCToolStripMenuItem.Name = "cinzaNTSCToolStripMenuItem";
            this.cinzaNTSCToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cinzaNTSCToolStripMenuItem.Text = "Cinza NTSC";
            this.cinzaNTSCToolStripMenuItem.Click += new System.EventHandler(this.cinzaNTSCToolStripMenuItem_Click);
            // 
            // cinzaNTSCPtrToolStripMenuItem
            // 
            this.cinzaNTSCPtrToolStripMenuItem.Name = "cinzaNTSCPtrToolStripMenuItem";
            this.cinzaNTSCPtrToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cinzaNTSCPtrToolStripMenuItem.Text = "Cinza NTSC ptr";
            this.cinzaNTSCPtrToolStripMenuItem.Click += new System.EventHandler(this.cinzaNTSCPtrToolStripMenuItem_Click);
            // 
            // cinzaNTSCMarshallToolStripMenuItem
            // 
            this.cinzaNTSCMarshallToolStripMenuItem.Name = "cinzaNTSCMarshallToolStripMenuItem";
            this.cinzaNTSCMarshallToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cinzaNTSCMarshallToolStripMenuItem.Text = "Cinza NTSC marshall";
            this.cinzaNTSCMarshallToolStripMenuItem.Click += new System.EventHandler(this.cinzaNTSCMarshallToolStripMenuItem_Click);
            // 
            // cinzaNTSC1ToolStripMenuItem
            // 
            this.cinzaNTSC1ToolStripMenuItem.Name = "cinzaNTSC1ToolStripMenuItem";
            this.cinzaNTSC1ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cinzaNTSC1ToolStripMenuItem.Text = "Cinza NTSC 1";
            this.cinzaNTSC1ToolStripMenuItem.Click += new System.EventHandler(this.cinzaNTSC1ToolStripMenuItem_Click);
            // 
            // binarizaçãoToolStripMenuItem
            // 
            this.binarizaçãoToolStripMenuItem.Name = "binarizaçãoToolStripMenuItem";
            this.binarizaçãoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.binarizaçãoToolStripMenuItem.Text = "Binarização";
            this.binarizaçãoToolStripMenuItem.Click += new System.EventHandler(this.binarizaçãoToolStripMenuItem_Click);
            // 
            // multilimiarizaçãoToolStripMenuItem
            // 
            this.multilimiarizaçãoToolStripMenuItem.Name = "multilimiarizaçãoToolStripMenuItem";
            this.multilimiarizaçãoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.multilimiarizaçãoToolStripMenuItem.Text = "Multilimiarização";
            this.multilimiarizaçãoToolStripMenuItem.Click += new System.EventHandler(this.multilimiarizaçãoToolStripMenuItem_Click);
            // 
            // médiaToolStripMenuItem
            // 
            this.médiaToolStripMenuItem.Name = "médiaToolStripMenuItem";
            this.médiaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.médiaToolStripMenuItem.Text = "Média";
            this.médiaToolStripMenuItem.Click += new System.EventHandler(this.médiaToolStripMenuItem_Click);
            // 
            // medianaToolStripMenuItem
            // 
            this.medianaToolStripMenuItem.Name = "medianaToolStripMenuItem";
            this.medianaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.medianaToolStripMenuItem.Text = "Mediana";
            this.medianaToolStripMenuItem.Click += new System.EventHandler(this.medianaToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Arquivos de Imagem|*.*";
            this.openFileDialog.Title = "Abrir Imagem";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "jpg";
            this.saveFileDialog.Title = "Salvar imagem";
            // 
            // aforgeToolStripMenuItem
            // 
            this.aforgeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayscaleToolStripMenuItem});
            this.aforgeToolStripMenuItem.Name = "aforgeToolStripMenuItem";
            this.aforgeToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.aforgeToolStripMenuItem.Text = "Aforge";
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.grayscaleToolStripMenuItem.Text = "Grayscale";
            this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.grayscaleToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 567);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageProcessing UENP";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem filtrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cinzaNTSCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cinzaNTSCPtrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cinzaNTSCMarshallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cinzaNTSC1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarizaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multilimiarizaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aforgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
    }
}

