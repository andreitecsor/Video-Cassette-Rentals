namespace InchirieriCaseteVideo
{
    partial class FormClienti
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
            System.Windows.Forms.Button btnBack;
            System.Windows.Forms.Button btnEditeaza;
            System.Windows.Forms.Button btnSterge;
            this.gbUtilizator = new System.Windows.Forms.GroupBox();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.lbTelefon = new System.Windows.Forms.Label();
            this.lbDataNastere = new System.Windows.Forms.Label();
            this.dtpDataNastere = new System.Windows.Forms.DateTimePicker();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.lbPrenume = new System.Windows.Forms.Label();
            this.lbNume = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpenFormFilme = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvClienti = new System.Windows.Forms.DataGridView();
            this.lbClienti = new System.Windows.Forms.Label();
            this.gpEditareClient = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNastereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnBack = new System.Windows.Forms.Button();
            btnEditeaza = new System.Windows.Forms.Button();
            btnSterge = new System.Windows.Forms.Button();
            this.gbUtilizator.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).BeginInit();
            this.gpEditareClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.AccessibleDescription = "Curata formular";
            btnBack.BackColor = System.Drawing.Color.Transparent;
            btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnBack.FlatAppearance.BorderSize = 2;
            btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBack.ForeColor = System.Drawing.Color.Black;
            btnBack.Image = global::InchirieriCaseteVideo.Properties.Resources.rsz_back;
            btnBack.Location = new System.Drawing.Point(307, 314);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(146, 82);
            btnBack.TabIndex = 20;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEditeaza
            // 
            btnEditeaza.AccessibleDescription = "Curata formular";
            btnEditeaza.BackColor = System.Drawing.Color.Transparent;
            btnEditeaza.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditeaza.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            btnEditeaza.FlatAppearance.BorderSize = 2;
            btnEditeaza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            btnEditeaza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnEditeaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditeaza.ForeColor = System.Drawing.Color.Gold;
            btnEditeaza.Image = global::InchirieriCaseteVideo.Properties.Resources.rsz_edit3;
            btnEditeaza.Location = new System.Drawing.Point(6, 18);
            btnEditeaza.Name = "btnEditeaza";
            btnEditeaza.Size = new System.Drawing.Size(159, 82);
            btnEditeaza.TabIndex = 14;
            btnEditeaza.UseVisualStyleBackColor = false;
            btnEditeaza.Click += new System.EventHandler(this.btnEditeaza_Click);
            // 
            // btnSterge
            // 
            btnSterge.AccessibleDescription = "Curata formular";
            btnSterge.BackColor = System.Drawing.Color.Transparent;
            btnSterge.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSterge.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            btnSterge.FlatAppearance.BorderSize = 2;
            btnSterge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            btnSterge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnSterge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSterge.ForeColor = System.Drawing.Color.Maroon;
            btnSterge.Image = global::InchirieriCaseteVideo.Properties.Resources.rsz_delete;
            btnSterge.Location = new System.Drawing.Point(171, 18);
            btnSterge.Name = "btnSterge";
            btnSterge.Size = new System.Drawing.Size(159, 82);
            btnSterge.TabIndex = 10;
            btnSterge.UseVisualStyleBackColor = false;
            btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // gbUtilizator
            // 
            this.gbUtilizator.Controls.Add(this.btnAnuleaza);
            this.gbUtilizator.Controls.Add(this.btnModifica);
            this.gbUtilizator.Controls.Add(this.btnAdauga);
            this.gbUtilizator.Controls.Add(this.tbTelefon);
            this.gbUtilizator.Controls.Add(this.lbTelefon);
            this.gbUtilizator.Controls.Add(this.lbDataNastere);
            this.gbUtilizator.Controls.Add(this.dtpDataNastere);
            this.gbUtilizator.Controls.Add(this.tbEmail);
            this.gbUtilizator.Controls.Add(this.lbEmail);
            this.gbUtilizator.Controls.Add(this.tbPrenume);
            this.gbUtilizator.Controls.Add(this.tbNume);
            this.gbUtilizator.Controls.Add(this.lbPrenume);
            this.gbUtilizator.Controls.Add(this.lbNume);
            this.gbUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUtilizator.Location = new System.Drawing.Point(12, 28);
            this.gbUtilizator.Name = "gbUtilizator";
            this.gbUtilizator.Size = new System.Drawing.Size(285, 384);
            this.gbUtilizator.TabIndex = 3;
            this.gbUtilizator.TabStop = false;
            this.gbUtilizator.Text = "Detalii utilizator";
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.BackColor = System.Drawing.Color.Transparent;
            this.btnAnuleaza.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAnuleaza.FlatAppearance.BorderSize = 2;
            this.btnAnuleaza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAnuleaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnuleaza.ForeColor = System.Drawing.Color.Red;
            this.btnAnuleaza.Image = global::InchirieriCaseteVideo.Properties.Resources.rsz_cancel;
            this.btnAnuleaza.Location = new System.Drawing.Point(16, 286);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(98, 82);
            this.btnAnuleaza.TabIndex = 23;
            this.btnAnuleaza.UseVisualStyleBackColor = false;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.Transparent;
            this.btnModifica.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnModifica.FlatAppearance.BorderSize = 2;
            this.btnModifica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifica.ForeColor = System.Drawing.Color.Teal;
            this.btnModifica.Image = global::InchirieriCaseteVideo.Properties.Resources.rsz_save;
            this.btnModifica.Location = new System.Drawing.Point(129, 286);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(137, 82);
            this.btnModifica.TabIndex = 22;
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.Color.Transparent;
            this.btnAdauga.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAdauga.FlatAppearance.BorderSize = 2;
            this.btnAdauga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdauga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdauga.ForeColor = System.Drawing.Color.Teal;
            this.btnAdauga.Image = global::InchirieriCaseteVideo.Properties.Resources.rsz_add2;
            this.btnAdauga.Location = new System.Drawing.Point(16, 286);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(250, 82);
            this.btnAdauga.TabIndex = 21;
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(16, 201);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(250, 26);
            this.tbTelefon.TabIndex = 19;
            // 
            // lbTelefon
            // 
            this.lbTelefon.AutoSize = true;
            this.lbTelefon.Location = new System.Drawing.Point(12, 178);
            this.lbTelefon.Name = "lbTelefon";
            this.lbTelefon.Size = new System.Drawing.Size(62, 20);
            this.lbTelefon.TabIndex = 11;
            this.lbTelefon.Text = "Telefon";
            // 
            // lbDataNastere
            // 
            this.lbDataNastere.AutoSize = true;
            this.lbDataNastere.Location = new System.Drawing.Point(12, 230);
            this.lbDataNastere.Name = "lbDataNastere";
            this.lbDataNastere.Size = new System.Drawing.Size(102, 20);
            this.lbDataNastere.TabIndex = 10;
            this.lbDataNastere.Text = "Dată naștere";
            // 
            // dtpDataNastere
            // 
            this.dtpDataNastere.Location = new System.Drawing.Point(16, 253);
            this.dtpDataNastere.MaxDate = new System.DateTime(2006, 1, 1, 0, 0, 0, 0);
            this.dtpDataNastere.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dtpDataNastere.Name = "dtpDataNastere";
            this.dtpDataNastere.Size = new System.Drawing.Size(250, 26);
            this.dtpDataNastere.TabIndex = 4;
            this.dtpDataNastere.Value = new System.DateTime(2002, 1, 1, 0, 0, 0, 0);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(16, 149);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(250, 26);
            this.tbEmail.TabIndex = 3;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(12, 126);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(48, 20);
            this.lbEmail.TabIndex = 5;
            this.lbEmail.Text = "Email";
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(16, 97);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(250, 26);
            this.tbPrenume.TabIndex = 2;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(16, 45);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(250, 26);
            this.tbNume.TabIndex = 1;
            // 
            // lbPrenume
            // 
            this.lbPrenume.AutoSize = true;
            this.lbPrenume.Location = new System.Drawing.Point(12, 74);
            this.lbPrenume.Name = "lbPrenume";
            this.lbPrenume.Size = new System.Drawing.Size(73, 20);
            this.lbPrenume.TabIndex = 2;
            this.lbPrenume.Text = "Prenume";
            // 
            // lbNume
            // 
            this.lbNume.AutoSize = true;
            this.lbNume.Location = new System.Drawing.Point(12, 22);
            this.lbNume.Name = "lbNume";
            this.lbNume.Size = new System.Drawing.Size(51, 20);
            this.lbNume.TabIndex = 1;
            this.lbNume.Text = "Nume";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFormFilme,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(962, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OpenFormFilme
            // 
            this.OpenFormFilme.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenFormFilme.Image = global::InchirieriCaseteVideo.Properties.Resources.rsz2_filme;
            this.OpenFormFilme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFormFilme.Name = "OpenFormFilme";
            this.OpenFormFilme.Size = new System.Drawing.Size(23, 22);
            this.OpenFormFilme.Text = "toolStripButton1";
            this.OpenFormFilme.Click += new System.EventHandler(this.OpenFormFilme_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // dgvClienti
            // 
            this.dgvClienti.AutoGenerateColumns = false;
            this.dgvClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClientDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.prenumeDataGridViewTextBoxColumn,
            this.dataNastereDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn});
            this.dgvClienti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvClienti.DataSource = this.clientBindingSource;
            this.dgvClienti.Location = new System.Drawing.Point(307, 50);
            this.dgvClienti.MultiSelect = false;
            this.dgvClienti.Name = "dgvClienti";
            this.dgvClienti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClienti.Size = new System.Drawing.Size(644, 240);
            this.dgvClienti.TabIndex = 5;
            // 
            // lbClienti
            // 
            this.lbClienti.AutoSize = true;
            this.lbClienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbClienti.Location = new System.Drawing.Point(303, 28);
            this.lbClienti.Name = "lbClienti";
            this.lbClienti.Size = new System.Drawing.Size(52, 20);
            this.lbClienti.TabIndex = 18;
            this.lbClienti.Text = "Clienți";
            // 
            // gpEditareClient
            // 
            this.gpEditareClient.Controls.Add(btnEditeaza);
            this.gpEditareClient.Controls.Add(btnSterge);
            this.gpEditareClient.Location = new System.Drawing.Point(459, 296);
            this.gpEditareClient.Name = "gpEditareClient";
            this.gpEditareClient.Size = new System.Drawing.Size(342, 116);
            this.gpEditareClient.TabIndex = 23;
            this.gpEditareClient.TabStop = false;
            this.gpEditareClient.Text = "Editare client";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnNext.FlatAppearance.BorderSize = 2;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.Teal;
            this.btnNext.Image = global::InchirieriCaseteVideo.Properties.Resources.rsz_next;
            this.btnNext.Location = new System.Drawing.Point(814, 314);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(137, 82);
            this.btnNext.TabIndex = 24;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(InchirieriCaseteVideo.Models.Client);
            // 
            // idClientDataGridViewTextBoxColumn
            // 
            this.idClientDataGridViewTextBoxColumn.DataPropertyName = "IdClient";
            this.idClientDataGridViewTextBoxColumn.HeaderText = "IdClient";
            this.idClientDataGridViewTextBoxColumn.Name = "idClientDataGridViewTextBoxColumn";
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            // 
            // prenumeDataGridViewTextBoxColumn
            // 
            this.prenumeDataGridViewTextBoxColumn.DataPropertyName = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.HeaderText = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.Name = "prenumeDataGridViewTextBoxColumn";
            // 
            // dataNastereDataGridViewTextBoxColumn
            // 
            this.dataNastereDataGridViewTextBoxColumn.DataPropertyName = "DataNastere";
            this.dataNastereDataGridViewTextBoxColumn.HeaderText = "DataNastere";
            this.dataNastereDataGridViewTextBoxColumn.Name = "dataNastereDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // FormClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 422);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(btnBack);
            this.Controls.Add(this.gpEditareClient);
            this.Controls.Add(this.lbClienti);
            this.Controls.Add(this.dgvClienti);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gbUtilizator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormClienti";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clienti";
            this.Load += new System.EventHandler(this.FormClienti_Load);
            this.gbUtilizator.ResumeLayout(false);
            this.gbUtilizator.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).EndInit();
            this.gpEditareClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUtilizator;
        private System.Windows.Forms.Label lbTelefon;
        private System.Windows.Forms.Label lbDataNastere;
        private System.Windows.Forms.DateTimePicker dtpDataNastere;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label lbPrenume;
        private System.Windows.Forms.Label lbNume;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OpenFormFilme;
        private System.Windows.Forms.DataGridView dgvClienti;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label lbClienti;
        private System.Windows.Forms.GroupBox gpEditareClient;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNastereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientBindingSource;
    }
}