namespace InchirieriCaseteVideo
{
    partial class Intro
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button btnFilme;
            System.Windows.Forms.Button btnClienti;
            this.menuStripIntro = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detaliiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versiuneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ieșireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbIntro1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbIntro2 = new System.Windows.Forms.Label();
            this.DetaliiButoane = new System.Windows.Forms.ToolTip(this.components);
            btnFilme = new System.Windows.Forms.Button();
            btnClienti = new System.Windows.Forms.Button();
            this.menuStripIntro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFilme
            // 
            btnFilme.AccessibleDescription = "Curata formular";
            btnFilme.BackColor = System.Drawing.Color.Transparent;
            btnFilme.Cursor = System.Windows.Forms.Cursors.Hand;
            btnFilme.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnFilme.FlatAppearance.BorderSize = 3;
            btnFilme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            btnFilme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnFilme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFilme.ForeColor = System.Drawing.Color.Black;
            btnFilme.Image = global::InchirieriCaseteVideo.Properties.Resources.rsz_filme;
            btnFilme.Location = new System.Drawing.Point(6, 17);
            btnFilme.Name = "btnFilme";
            btnFilme.Size = new System.Drawing.Size(110, 80);
            btnFilme.TabIndex = 2;
            this.DetaliiButoane.SetToolTip(btnFilme, "Accesați meniul Filme");
            btnFilme.UseVisualStyleBackColor = false;
            btnFilme.Click += new System.EventHandler(this.btnFilme_Click);
            // 
            // btnClienti
            // 
            btnClienti.AccessibleDescription = "Curata formular";
            btnClienti.BackColor = System.Drawing.Color.Transparent;
            btnClienti.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClienti.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            btnClienti.FlatAppearance.BorderSize = 2;
            btnClienti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            btnClienti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnClienti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClienti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            btnClienti.Image = global::InchirieriCaseteVideo.Properties.Resources.rsz_clienti;
            btnClienti.Location = new System.Drawing.Point(6, 17);
            btnClienti.Name = "btnClienti";
            btnClienti.Size = new System.Drawing.Size(110, 80);
            btnClienti.TabIndex = 1;
            this.DetaliiButoane.SetToolTip(btnClienti, "Accesați meniul Clienți");
            btnClienti.UseVisualStyleBackColor = false;
            btnClienti.Click += new System.EventHandler(this.btnClienti_Click);
            // 
            // menuStripIntro
            // 
            this.menuStripIntro.BackColor = System.Drawing.Color.Transparent;
            this.menuStripIntro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripIntro.Location = new System.Drawing.Point(0, 0);
            this.menuStripIntro.Name = "menuStripIntro";
            this.menuStripIntro.Size = new System.Drawing.Size(299, 24);
            this.menuStripIntro.TabIndex = 0;
            this.menuStripIntro.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detaliiToolStripMenuItem,
            this.ieșireToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.fileToolStripMenuItem.Text = "Meniu";
            // 
            // detaliiToolStripMenuItem
            // 
            this.detaliiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versiuneToolStripMenuItem,
            this.autorToolStripMenuItem});
            this.detaliiToolStripMenuItem.Name = "detaliiToolStripMenuItem";
            this.detaliiToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.detaliiToolStripMenuItem.Text = "Detalii";
            // 
            // versiuneToolStripMenuItem
            // 
            this.versiuneToolStripMenuItem.Name = "versiuneToolStripMenuItem";
            this.versiuneToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.versiuneToolStripMenuItem.Text = "Versiune";
            this.versiuneToolStripMenuItem.Click += new System.EventHandler(this.versiuneToolStripMenuItem_Click);
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.autorToolStripMenuItem.Text = "Autor";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // ieșireToolStripMenuItem
            // 
            this.ieșireToolStripMenuItem.Name = "ieșireToolStripMenuItem";
            this.ieșireToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.ieșireToolStripMenuItem.Text = "Ieșire";
            this.ieșireToolStripMenuItem.Click += new System.EventHandler(this.ieșireToolStripMenuItem_Click);
            // 
            // lbIntro1
            // 
            this.lbIntro1.AutoSize = true;
            this.lbIntro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbIntro1.Location = new System.Drawing.Point(12, 29);
            this.lbIntro1.Name = "lbIntro1";
            this.lbIntro1.Size = new System.Drawing.Size(160, 40);
            this.lbIntro1.TabIndex = 1;
            this.lbIntro1.Text = "Cu ce meniu doriți să \r\ninteracționați?\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lbIntro2);
            this.groupBox1.Controls.Add(this.lbIntro1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 196);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bine ați revenit!";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(btnFilme);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox3.Location = new System.Drawing.Point(147, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(122, 103);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filme";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(btnClienti);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.Location = new System.Drawing.Point(9, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(122, 103);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clienți";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::InchirieriCaseteVideo.Properties.Resources.rsz_1robot;
            this.pictureBox1.Location = new System.Drawing.Point(215, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.DetaliiButoane.SetToolTip(this.pictureBox1, "Pentru mai multe detalii accesați butonul Meniu");
            // 
            // lbIntro2
            // 
            this.lbIntro2.AutoSize = true;
            this.lbIntro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbIntro2.Location = new System.Drawing.Point(6, 16);
            this.lbIntro2.Name = "lbIntro2";
            this.lbIntro2.Size = new System.Drawing.Size(0, 17);
            this.lbIntro2.TabIndex = 3;
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 235);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStripIntro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripIntro;
            this.MaximizeBox = false;
            this.Name = "Intro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Închiriere casete video";
            this.menuStripIntro.ResumeLayout(false);
            this.menuStripIntro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripIntro;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detaliiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versiuneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ieșireToolStripMenuItem;
        private System.Windows.Forms.Label lbIntro1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbIntro2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip DetaliiButoane;
    }
}