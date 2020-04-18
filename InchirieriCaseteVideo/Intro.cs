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
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        private void btnFilme_Click(object sender, EventArgs e)
        {
            AdaugaFilm adaugaFilm = new AdaugaFilm();
            this.Hide();
            adaugaFilm.ShowDialog();
            this.Close();
        }

        private void btnClienti_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se lucrează cu drag și spor la această parte!\n(după vacanță)😁", "În curând!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region MenuStrip
        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Andrei Tecșor\nGrupa 1057\nSeria E");
        }

        private void versiuneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versiunea: 1.0 \nUltima actualizare: 18/04/2020", "Versiune", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ieșireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}
