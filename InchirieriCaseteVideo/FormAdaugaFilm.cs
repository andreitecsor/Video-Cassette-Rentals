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
            bool esteValid = true;

            #region Validari date formular pentru adaugare
            //Titlu
            String titlu = tbTitlu.Text;
            if (String.IsNullOrEmpty(titlu) || String.IsNullOrWhiteSpace(titlu) || titlu.Length < 2)
            {
                esteValid = false;
            }
            //Pret
            String temp = null;
            temp = tbPret.Text;
            Double.TryParse(temp, out double pret);
            if (pret <= 0.0)
                esteValid = false;
            //An Aparitie
            temp = null;
            temp = tbAnAparitie.Text;
            int.TryParse(temp, out int an);
            if (an < 1850 || an >2020)
                esteValid = false;
            //Gen Film
            temp = null;
            temp = cbGenFilm.Text;
            Enum.TryParse(temp, out EnumGenFilm gen);
            if (cbGenFilm.SelectedItem == null || Enum.TryParse(temp, out gen) == false)
                esteValid = false;
            //Stoc
            temp = null;
            temp = tbStoc.Text;
            int.TryParse(temp, out int stoc);
            if (stoc <= 0)
                esteValid = false;
            #endregion

            if (esteValid)
            {
                Film filmNou = new Film(titlu, pret, an, gen, stoc);
                MessageBox.Show("Filmul " + titlu + " a fost adaugat cu succes");
            }
            else
            {
                MessageBox.Show("Revizuiti formularul!");
            }
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

        #region Error Providers: Validating & Validated

        //Titlu
        private void tbTitlu_Validating(object sender, CancelEventArgs e)
        {
            String titlu = tbTitlu.Text;
            if(String.IsNullOrEmpty(titlu) || String.IsNullOrWhiteSpace(titlu) || titlu.Length < 2)
            {
                epTitlu.SetError((Control)sender, "Completeaza titlul filmului");
                e.Cancel = true;
            }
        }
        private void tbTitlu_Validated(object sender, EventArgs e)
        {
            epTitlu.Clear();
        }

        
        //Gen Film
        private void cbGenFilm_Validating(object sender, CancelEventArgs e)
        {
            String temp = cbGenFilm.Text;
            if(cbGenFilm.SelectedItem == null || Enum.TryParse(temp, out EnumGenFilm gen) == false)
            {
                epGenFilm.SetError((Control)sender, "Alegeti un gen din lista");
                e.Cancel = true;
            }
        }
        private void cbGenFilm_Validated(object sender, EventArgs e)
        {
            epGenFilm.Clear();
        }

        //An aparitie
        private void tbAnAparitie_Validating(object sender, CancelEventArgs e)
        {
            String temp = tbAnAparitie.Text;
            int.TryParse(temp, out int an);
            if (an<1850 || an >2020)
            {
                epAnAparitie.SetError((Control)sender, "Anul trebuie sa fie cuprins intre anii 1850 si 2020");
                e.Cancel = true;
            }
        }
        private void tbAnAparitie_Validated(object sender, EventArgs e)
        {
            epAnAparitie.Clear();
        }

        //Pret
        private void tbPret_Validating(object sender, CancelEventArgs e)
        {
            String temp = tbPret.Text;
            double.TryParse(temp, out double pret);
            if (pret<=0.0)
            {
                epPret.SetError((Control)sender, "Pretul trebuie sa fie mai mare decat 0");
                e.Cancel = true;
            }
        }
        private void tbPret_Validated(object sender, EventArgs e)
        {
            epPret.Clear();
        }

        //Stoc
        private void tbStoc_Validating(object sender, CancelEventArgs e)
        {
            String temp = tbStoc.Text;
            int.TryParse(temp, out int stoc);
            if (stoc <= 0)
            {
                epStoc.SetError((Control)sender, "Stocul trebue sa fie mai mare decat 0");
                e.Cancel = true;
            }
        }
        private void tbStoc_Validated(object sender, EventArgs e)
        {
            epStoc.Clear();
        }

        #endregion

    }
}
