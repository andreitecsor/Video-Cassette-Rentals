using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InchirieriCaseteVideo
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        #region Butoane formular
        private void btnFilme_Click(object sender, EventArgs e)
        {
            FormFilme adaugaFilm = new FormFilme();
            this.Hide();
            adaugaFilm.ShowDialog();
            this.Close();
        }

        private void btnClienti_Click(object sender, EventArgs e)
        {
            FormClienti formClienti = new FormClienti();
            this.Hide();
            formClienti.ShowDialog();
            this.Close();
        }
        #endregion Butoane formular

        #region MenuStrip
        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Andrei Tecșor\nGrupa 1057\nSeria E");
        }

        private void versiuneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versiune Finală \nUltima actualizare: 29/05/2020", "Versiune", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ieșireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}
