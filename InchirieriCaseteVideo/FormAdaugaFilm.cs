using InchirieriCaseteVideo.Models;
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
    public partial class FormAdaugaFilm : Form
    {
        public FormAdaugaFilm()
        {
            InitializeComponent();
            cbGenFilm.DataSource = Enum.GetValues(typeof(EnumGenFilm));
            cbGenFilm.SelectedIndex = -1;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            //public Film(string titlu, double pret, int an, EnumGenFilm gen, int stoc)
            String titlu = tbTitlu.Text;

            String temp=null;
            temp = tbPret.Text;
            Double.TryParse(temp, out double pret);

            temp = null;
            temp = tbAnAparitie.Text;
            int.TryParse(temp, out int an);

            temp = null;
            temp = cbGenFilm.Text;
            Enum.TryParse(temp, out EnumGenFilm gen);

           
            temp = null;
            temp = tbStoc.Text;
            int.TryParse(temp, out int stoc);

            Film filmNou = new Film(titlu, pret, an, gen, stoc);

            MessageBox.Show("Filmul" + titlu + "a fost adaugat cu succes");

        }

        private void btnCurataCampuri_Click(object sender, EventArgs e)
        {
            CurataCampuri();
        }

        private void CurataCampuri()
        {
            tbTitlu.Clear();
            cbGenFilm.SelectedIndex = -1;
            tbAnAparitie.Clear();
            tbPret.Clear();
            tbStoc.Clear();
        }
    }
}
