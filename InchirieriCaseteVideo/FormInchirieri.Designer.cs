namespace InchirieriCaseteVideo
{
    partial class FormInchirieri
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
            System.Windows.Forms.Button btnDone;
            System.Windows.Forms.Button btnBack;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInchirieri));
            this.gpDetaliiClient = new System.Windows.Forms.GroupBox();
            this.lbTelefon = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbNume = new System.Windows.Forms.Label();
            this.lbPrenume = new System.Windows.Forms.Label();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.lbFilme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpRetur = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            btnDone = new System.Windows.Forms.Button();
            btnBack = new System.Windows.Forms.Button();
            this.gpDetaliiClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            btnDone.AccessibleDescription = "Curata formular";
            btnDone.BackColor = System.Drawing.Color.Transparent;
            btnDone.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDone.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnDone.FlatAppearance.BorderSize = 2;
            btnDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            btnDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDone.ForeColor = System.Drawing.Color.Black;
            btnDone.Image = global::InchirieriCaseteVideo.Properties.Resources.rsz_1done;
            btnDone.Location = new System.Drawing.Point(547, 302);
            btnDone.Name = "btnDone";
            btnDone.Size = new System.Drawing.Size(136, 64);
            btnDone.TabIndex = 22;
            btnDone.UseVisualStyleBackColor = false;
            btnDone.Click += new System.EventHandler(this.btnDone_Click);
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
            btnBack.Location = new System.Drawing.Point(343, 302);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(136, 64);
            btnBack.TabIndex = 21;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gpDetaliiClient
            // 
            this.gpDetaliiClient.Controls.Add(this.lbTelefon);
            this.gpDetaliiClient.Controls.Add(this.lbEmail);
            this.gpDetaliiClient.Controls.Add(this.lbNume);
            this.gpDetaliiClient.Controls.Add(this.lbPrenume);
            this.gpDetaliiClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gpDetaliiClient.Location = new System.Drawing.Point(12, 14);
            this.gpDetaliiClient.Name = "gpDetaliiClient";
            this.gpDetaliiClient.Size = new System.Drawing.Size(307, 112);
            this.gpDetaliiClient.TabIndex = 0;
            this.gpDetaliiClient.TabStop = false;
            this.gpDetaliiClient.Text = "Detalii Client";
            // 
            // lbTelefon
            // 
            this.lbTelefon.AutoSize = true;
            this.lbTelefon.Location = new System.Drawing.Point(6, 82);
            this.lbTelefon.Name = "lbTelefon";
            this.lbTelefon.Size = new System.Drawing.Size(66, 20);
            this.lbTelefon.TabIndex = 12;
            this.lbTelefon.Text = "Telefon:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(6, 62);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(52, 20);
            this.lbEmail.TabIndex = 11;
            this.lbEmail.Text = "Email:";
            // 
            // lbNume
            // 
            this.lbNume.AutoSize = true;
            this.lbNume.Location = new System.Drawing.Point(6, 22);
            this.lbNume.Name = "lbNume";
            this.lbNume.Size = new System.Drawing.Size(55, 20);
            this.lbNume.TabIndex = 4;
            this.lbNume.Text = "Nume:";
            // 
            // lbPrenume
            // 
            this.lbPrenume.AutoSize = true;
            this.lbPrenume.Location = new System.Drawing.Point(6, 42);
            this.lbPrenume.Name = "lbPrenume";
            this.lbPrenume.Size = new System.Drawing.Size(77, 20);
            this.lbPrenume.TabIndex = 3;
            this.lbPrenume.Text = "Prenume:";
            // 
            // checkedListBox
            // 
            this.checkedListBox.AllowDrop = true;
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(343, 36);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(340, 214);
            this.checkedListBox.TabIndex = 16;
            this.checkedListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.checkedListBox_DragDrop);
            this.checkedListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.checkedListBox_DragEnter);
            // 
            // treeView
            // 
            this.treeView.AllowDrop = true;
            this.treeView.Location = new System.Drawing.Point(12, 157);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(307, 209);
            this.treeView.TabIndex = 17;
            this.treeView.DragOver += new System.Windows.Forms.DragEventHandler(this.treeView_DragOver);
            this.treeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseDown);
            // 
            // lbFilme
            // 
            this.lbFilme.AutoSize = true;
            this.lbFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbFilme.Location = new System.Drawing.Point(12, 134);
            this.lbFilme.Name = "lbFilme";
            this.lbFilme.Size = new System.Drawing.Size(114, 20);
            this.lbFilme.TabIndex = 13;
            this.lbFilme.Text = "Listă filme stoc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(339, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Filme de cumpărat";
            // 
            // dtpRetur
            // 
            this.dtpRetur.Location = new System.Drawing.Point(343, 276);
            this.dtpRetur.Name = "dtpRetur";
            this.dtpRetur.Size = new System.Drawing.Size(340, 20);
            this.dtpRetur.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(339, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Dată return";
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // FormInchirieri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 391);
            this.Controls.Add(btnDone);
            this.Controls.Add(btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpRetur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbFilme);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.gpDetaliiClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormInchirieri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inchirieri";
            this.Load += new System.EventHandler(this.FormInchirieri_Load);
            this.gpDetaliiClient.ResumeLayout(false);
            this.gpDetaliiClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpDetaliiClient;
        private System.Windows.Forms.Label lbPrenume;
        private System.Windows.Forms.Label lbNume;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbTelefon;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Label lbFilme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpRetur;
        private System.Windows.Forms.Label label2;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
    }
}