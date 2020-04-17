namespace InchirieriCaseteVideo
{
    partial class FormAdaugaFilm
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
            System.Windows.Forms.Button button2;
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Button btnStergeFilm;
            System.Windows.Forms.Button btnAdauga;
            System.Windows.Forms.Button btnCurataCampuri;
            this.gpAdaugaFilm = new System.Windows.Forms.GroupBox();
            this.lbDespartitorGPAdaugaFilm = new System.Windows.Forms.Label();
            this.lbValuta = new System.Windows.Forms.Label();
            this.tbStoc = new System.Windows.Forms.TextBox();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.cbGenFilm = new System.Windows.Forms.ComboBox();
            this.tbAnAparitie = new System.Windows.Forms.TextBox();
            this.tbTitlu = new System.Windows.Forms.TextBox();
            this.lbStoc = new System.Windows.Forms.Label();
            this.lbPretPeZi = new System.Windows.Forms.Label();
            this.lbAnAparitie = new System.Windows.Forms.Label();
            this.lbGen = new System.Windows.Forms.Label();
            this.lbTitlu = new System.Windows.Forms.Label();
            this.epTitlu = new System.Windows.Forms.ErrorProvider(this.components);
            this.epGenFilm = new System.Windows.Forms.ErrorProvider(this.components);
            this.epAnAparitie = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPret = new System.Windows.Forms.ErrorProvider(this.components);
            this.epStoc = new System.Windows.Forms.ErrorProvider(this.components);
            this.DetaliiButoane = new System.Windows.Forms.ToolTip(this.components);
            this.lvFilme = new System.Windows.Forms.ListView();
            this.lbListaFilme = new System.Windows.Forms.Label();
            this.gpEditareFilme = new System.Windows.Forms.GroupBox();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Titlu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            btnStergeFilm = new System.Windows.Forms.Button();
            btnAdauga = new System.Windows.Forms.Button();
            btnCurataCampuri = new System.Windows.Forms.Button();
            this.gpAdaugaFilm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epTitlu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGenFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAnAparitie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epStoc)).BeginInit();
            this.gpEditareFilme.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpAdaugaFilm
            // 
            this.gpAdaugaFilm.Controls.Add(btnAdauga);
            this.gpAdaugaFilm.Controls.Add(btnCurataCampuri);
            this.gpAdaugaFilm.Controls.Add(this.lbDespartitorGPAdaugaFilm);
            this.gpAdaugaFilm.Controls.Add(this.lbValuta);
            this.gpAdaugaFilm.Controls.Add(this.tbStoc);
            this.gpAdaugaFilm.Controls.Add(this.tbPret);
            this.gpAdaugaFilm.Controls.Add(this.cbGenFilm);
            this.gpAdaugaFilm.Controls.Add(this.tbAnAparitie);
            this.gpAdaugaFilm.Controls.Add(this.tbTitlu);
            this.gpAdaugaFilm.Controls.Add(this.lbStoc);
            this.gpAdaugaFilm.Controls.Add(this.lbPretPeZi);
            this.gpAdaugaFilm.Controls.Add(this.lbAnAparitie);
            this.gpAdaugaFilm.Controls.Add(this.lbGen);
            this.gpAdaugaFilm.Controls.Add(this.lbTitlu);
            this.gpAdaugaFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gpAdaugaFilm.Location = new System.Drawing.Point(12, 12);
            this.gpAdaugaFilm.Name = "gpAdaugaFilm";
            this.gpAdaugaFilm.Size = new System.Drawing.Size(280, 401);
            this.gpAdaugaFilm.TabIndex = 0;
            this.gpAdaugaFilm.TabStop = false;
            this.gpAdaugaFilm.Text = "Adaugă un film nou";
            // 
            // lbDespartitorGPAdaugaFilm
            // 
            this.lbDespartitorGPAdaugaFilm.BackColor = System.Drawing.Color.Transparent;
            this.lbDespartitorGPAdaugaFilm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDespartitorGPAdaugaFilm.ForeColor = System.Drawing.Color.Gray;
            this.lbDespartitorGPAdaugaFilm.Location = new System.Drawing.Point(9, 295);
            this.lbDespartitorGPAdaugaFilm.Name = "lbDespartitorGPAdaugaFilm";
            this.lbDespartitorGPAdaugaFilm.Size = new System.Drawing.Size(260, 1);
            this.lbDespartitorGPAdaugaFilm.TabIndex = 1;
            // 
            // lbValuta
            // 
            this.lbValuta.AutoSize = true;
            this.lbValuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbValuta.Location = new System.Drawing.Point(157, 216);
            this.lbValuta.Name = "lbValuta";
            this.lbValuta.Size = new System.Drawing.Size(39, 17);
            this.lbValuta.TabIndex = 10;
            this.lbValuta.Text = "RON";
            // 
            // tbStoc
            // 
            this.tbStoc.Location = new System.Drawing.Point(21, 262);
            this.tbStoc.Name = "tbStoc";
            this.tbStoc.Size = new System.Drawing.Size(175, 23);
            this.tbStoc.TabIndex = 5;
            this.tbStoc.Validating += new System.ComponentModel.CancelEventHandler(this.tbStoc_Validating);
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(21, 213);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(130, 23);
            this.tbPret.TabIndex = 4;
            this.tbPret.Validating += new System.ComponentModel.CancelEventHandler(this.tbPret_Validating);
            // 
            // cbGenFilm
            // 
            this.cbGenFilm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbGenFilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenFilm.FormattingEnabled = true;
            this.cbGenFilm.Location = new System.Drawing.Point(21, 114);
            this.cbGenFilm.Name = "cbGenFilm";
            this.cbGenFilm.Size = new System.Drawing.Size(245, 24);
            this.cbGenFilm.TabIndex = 2;
            this.cbGenFilm.Validating += new System.ComponentModel.CancelEventHandler(this.cbGenFilm_Validating);
            // 
            // tbAnAparitie
            // 
            this.tbAnAparitie.Location = new System.Drawing.Point(21, 164);
            this.tbAnAparitie.Name = "tbAnAparitie";
            this.tbAnAparitie.Size = new System.Drawing.Size(245, 23);
            this.tbAnAparitie.TabIndex = 3;
            this.tbAnAparitie.Validating += new System.ComponentModel.CancelEventHandler(this.tbAnAparitie_Validating);
            this.tbAnAparitie.Validated += new System.EventHandler(this.tbAnAparitie_Validated);
            // 
            // tbTitlu
            // 
            this.tbTitlu.Location = new System.Drawing.Point(21, 42);
            this.tbTitlu.Multiline = true;
            this.tbTitlu.Name = "tbTitlu";
            this.tbTitlu.Size = new System.Drawing.Size(245, 46);
            this.tbTitlu.TabIndex = 1;
            this.tbTitlu.Validating += new System.ComponentModel.CancelEventHandler(this.tbTitlu_Validating);
            this.tbTitlu.Validated += new System.EventHandler(this.tbTitlu_Validated);
            // 
            // lbStoc
            // 
            this.lbStoc.AutoSize = true;
            this.lbStoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbStoc.Location = new System.Drawing.Point(21, 239);
            this.lbStoc.Name = "lbStoc";
            this.lbStoc.Size = new System.Drawing.Size(42, 20);
            this.lbStoc.TabIndex = 4;
            this.lbStoc.Text = "Stoc";
            // 
            // lbPretPeZi
            // 
            this.lbPretPeZi.AutoSize = true;
            this.lbPretPeZi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbPretPeZi.Location = new System.Drawing.Point(21, 190);
            this.lbPretPeZi.Name = "lbPretPeZi";
            this.lbPretPeZi.Size = new System.Drawing.Size(75, 20);
            this.lbPretPeZi.TabIndex = 3;
            this.lbPretPeZi.Text = "Preț pe zi";
            // 
            // lbAnAparitie
            // 
            this.lbAnAparitie.AutoSize = true;
            this.lbAnAparitie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbAnAparitie.Location = new System.Drawing.Point(21, 141);
            this.lbAnAparitie.Name = "lbAnAparitie";
            this.lbAnAparitie.Size = new System.Drawing.Size(85, 20);
            this.lbAnAparitie.TabIndex = 2;
            this.lbAnAparitie.Text = "An apariție";
            // 
            // lbGen
            // 
            this.lbGen.AutoSize = true;
            this.lbGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbGen.Location = new System.Drawing.Point(21, 91);
            this.lbGen.Name = "lbGen";
            this.lbGen.Size = new System.Drawing.Size(73, 20);
            this.lbGen.TabIndex = 1;
            this.lbGen.Text = "Gen Film";
            // 
            // lbTitlu
            // 
            this.lbTitlu.AutoSize = true;
            this.lbTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTitlu.Location = new System.Drawing.Point(21, 19);
            this.lbTitlu.Name = "lbTitlu";
            this.lbTitlu.Size = new System.Drawing.Size(38, 20);
            this.lbTitlu.TabIndex = 0;
            this.lbTitlu.Text = "Titlu";
            // 
            // epTitlu
            // 
            this.epTitlu.ContainerControl = this;
            this.epTitlu.RightToLeft = true;
            // 
            // epGenFilm
            // 
            this.epGenFilm.ContainerControl = this;
            this.epGenFilm.RightToLeft = true;
            // 
            // epAnAparitie
            // 
            this.epAnAparitie.ContainerControl = this;
            this.epAnAparitie.RightToLeft = true;
            // 
            // epPret
            // 
            this.epPret.ContainerControl = this;
            this.epPret.RightToLeft = true;
            // 
            // epStoc
            // 
            this.epStoc.ContainerControl = this;
            this.epStoc.RightToLeft = true;
            // 
            // lvFilme
            // 
            this.lvFilme.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Titlu,
            this.Gen,
            this.Pret,
            this.Stoc});
            this.lvFilme.HideSelection = false;
            this.lvFilme.Location = new System.Drawing.Point(302, 35);
            this.lvFilme.Name = "lvFilme";
            this.lvFilme.Size = new System.Drawing.Size(486, 262);
            this.lvFilme.TabIndex = 13;
            this.lvFilme.UseCompatibleStateImageBehavior = false;
            this.lvFilme.View = System.Windows.Forms.View.Details;
            // 
            // lbListaFilme
            // 
            this.lbListaFilme.AutoSize = true;
            this.lbListaFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbListaFilme.Location = new System.Drawing.Point(298, 12);
            this.lbListaFilme.Name = "lbListaFilme";
            this.lbListaFilme.Size = new System.Drawing.Size(152, 20);
            this.lbListaFilme.TabIndex = 13;
            this.lbListaFilme.Text = "Listă filme adăugate";
            // 
            // gpEditareFilme
            // 
            this.gpEditareFilme.Controls.Add(button1);
            this.gpEditareFilme.Controls.Add(btnStergeFilm);
            this.gpEditareFilme.Location = new System.Drawing.Point(408, 303);
            this.gpEditareFilme.Name = "gpEditareFilme";
            this.gpEditareFilme.Size = new System.Drawing.Size(380, 110);
            this.gpEditareFilme.TabIndex = 14;
            this.gpEditareFilme.TabStop = false;
            this.gpEditareFilme.Text = "Editare film";
            // 
            // button2
            // 
            button2.AccessibleDescription = "Curata formular";
            button2.BackColor = System.Drawing.Color.Transparent;
            button2.Cursor = System.Windows.Forms.Cursors.Hand;
            button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.ForeColor = System.Drawing.Color.Black;
            button2.Image = global::InchirieriCaseteVideo.Properties.Resources.rsz_back;
            button2.Location = new System.Drawing.Point(302, 321);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(100, 82);
            button2.TabIndex = 12;
            this.DetaliiButoane.SetToolTip(button2, "Întoarce-te la meniul anterior");
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.AccessibleDescription = "Curata formular";
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.ForeColor = System.Drawing.Color.Gold;
            button1.Image = global::InchirieriCaseteVideo.Properties.Resources.rsz_edit3;
            button1.Location = new System.Drawing.Point(6, 19);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(175, 80);
            button1.TabIndex = 14;
            this.DetaliiButoane.SetToolTip(button1, "Editează filmul selectat");
            button1.UseVisualStyleBackColor = false;
            // 
            // btnStergeFilm
            // 
            btnStergeFilm.AccessibleDescription = "Curata formular";
            btnStergeFilm.BackColor = System.Drawing.Color.Transparent;
            btnStergeFilm.Cursor = System.Windows.Forms.Cursors.Hand;
            btnStergeFilm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            btnStergeFilm.FlatAppearance.BorderSize = 2;
            btnStergeFilm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            btnStergeFilm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnStergeFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStergeFilm.ForeColor = System.Drawing.Color.Maroon;
            btnStergeFilm.Image = global::InchirieriCaseteVideo.Properties.Resources.rsz_delete;
            btnStergeFilm.Location = new System.Drawing.Point(197, 19);
            btnStergeFilm.Name = "btnStergeFilm";
            btnStergeFilm.Size = new System.Drawing.Size(175, 80);
            btnStergeFilm.TabIndex = 13;
            this.DetaliiButoane.SetToolTip(btnStergeFilm, "Șterge filmul selectat");
            btnStergeFilm.UseVisualStyleBackColor = false;
            // 
            // btnAdauga
            // 
            btnAdauga.AccessibleDescription = "Curata formular";
            btnAdauga.BackColor = System.Drawing.Color.Transparent;
            btnAdauga.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAdauga.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            btnAdauga.FlatAppearance.BorderSize = 2;
            btnAdauga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            btnAdauga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnAdauga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdauga.ForeColor = System.Drawing.Color.Teal;
            btnAdauga.Image = global::InchirieriCaseteVideo.Properties.Resources.rsz_add2;
            btnAdauga.Location = new System.Drawing.Point(9, 308);
            btnAdauga.Name = "btnAdauga";
            btnAdauga.Size = new System.Drawing.Size(260, 82);
            btnAdauga.TabIndex = 6;
            this.DetaliiButoane.SetToolTip(btnAdauga, "Adaugă film nou");
            btnAdauga.UseVisualStyleBackColor = false;
            btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnCurataCampuri
            // 
            btnCurataCampuri.AccessibleDescription = "Curata formular";
            btnCurataCampuri.BackColor = System.Drawing.Color.Transparent;
            btnCurataCampuri.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCurataCampuri.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            btnCurataCampuri.FlatAppearance.BorderSize = 2;
            btnCurataCampuri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            btnCurataCampuri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnCurataCampuri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCurataCampuri.ForeColor = System.Drawing.Color.LimeGreen;
            btnCurataCampuri.Image = global::InchirieriCaseteVideo.Properties.Resources.rsz_clean;
            btnCurataCampuri.Location = new System.Drawing.Point(202, 213);
            btnCurataCampuri.Name = "btnCurataCampuri";
            btnCurataCampuri.Size = new System.Drawing.Size(64, 72);
            btnCurataCampuri.TabIndex = 7;
            this.DetaliiButoane.SetToolTip(btnCurataCampuri, "Curăță câmpuri");
            btnCurataCampuri.UseVisualStyleBackColor = false;
            btnCurataCampuri.Click += new System.EventHandler(this.btnCurataCampuri_Click);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 33;
            // 
            // Titlu
            // 
            this.Titlu.Text = "Titlu";
            this.Titlu.Width = 260;
            // 
            // Gen
            // 
            this.Gen.Text = "Gen";
            this.Gen.Width = 85;
            // 
            // Pret
            // 
            this.Pret.Text = "Preț(RON)";
            this.Pret.Width = 64;
            // 
            // Stoc
            // 
            this.Stoc.Text = "Stoc";
            this.Stoc.Width = 40;
            // 
            // FormAdaugaFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(button2);
            this.Controls.Add(this.gpEditareFilme);
            this.Controls.Add(this.lbListaFilme);
            this.Controls.Add(this.lvFilme);
            this.Controls.Add(this.gpAdaugaFilm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAdaugaFilm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filme";
            this.gpAdaugaFilm.ResumeLayout(false);
            this.gpAdaugaFilm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epTitlu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGenFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAnAparitie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epStoc)).EndInit();
            this.gpEditareFilme.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpAdaugaFilm;
        private System.Windows.Forms.Label lbTitlu;
        private System.Windows.Forms.Label lbStoc;
        private System.Windows.Forms.Label lbPretPeZi;
        private System.Windows.Forms.Label lbAnAparitie;
        private System.Windows.Forms.Label lbGen;
        private System.Windows.Forms.TextBox tbAnAparitie;
        private System.Windows.Forms.TextBox tbTitlu;
        private System.Windows.Forms.ComboBox cbGenFilm;
        private System.Windows.Forms.Label lbValuta;
        private System.Windows.Forms.TextBox tbStoc;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.Label lbDespartitorGPAdaugaFilm;
        private System.Windows.Forms.ErrorProvider epTitlu;
        private System.Windows.Forms.ErrorProvider epGenFilm;
        private System.Windows.Forms.ErrorProvider epAnAparitie;
        private System.Windows.Forms.ErrorProvider epPret;
        private System.Windows.Forms.ErrorProvider epStoc;
        private System.Windows.Forms.ToolTip DetaliiButoane;
        private System.Windows.Forms.GroupBox gpEditareFilme;
        private System.Windows.Forms.Label lbListaFilme;
        private System.Windows.Forms.ListView lvFilme;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Titlu;
        private System.Windows.Forms.ColumnHeader Gen;
        private System.Windows.Forms.ColumnHeader Pret;
        private System.Windows.Forms.ColumnHeader Stoc;
    }
}

