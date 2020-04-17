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
        //Initializare lista de filme
        List<Film> listaFilme = new List<Film>();

        public FormAdaugaFilm()
        {
            InitializeComponent();
            cbGenFilm.DataSource = Enum.GetValues(typeof(EnumGenFilm));
            cbGenFilm.SelectedIndex = -1;
        }

        #region Butoane formular Filme
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
                //Adaugare film nou in lista
                listaFilme.Add(filmNou);

                populeazaListView();

                //MessageBox.Show("Filmul " + titlu + " a fost adăugat cu succes","Introducere cu succes",
                //    MessageBoxButtons.OK,MessageBoxIcon.Information);
                CurataCampuri();
            }
            else
            {
                MessageBox.Show("Revizuiți formularul!","Eroare date formular",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }

        private void btnCurataCampuri_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Doriți să curățați câmpurile?", "Verificare", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                CurataCampuri();
            }
        }

        private void btnStergeFilm_Click(object sender, EventArgs e)
        {
            if (lvFilme.SelectedItems.Count != 0)
            {
                if (MessageBox.Show("Doriți să ștergeți filmul?", "Șterge film", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    listaFilme.RemoveAt(lvFilme.SelectedIndices[0]);
                    populeazaListView();
                }
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (lvFilme.SelectedItems.Count != 0)
            {
                Film film = listaFilme.ElementAt(lvFilme.SelectedIndices[0]);
                FormEditareFilm editare = new FormEditareFilm(film);
                editare.ShowDialog();
                populeazaListView();
            }
        }

        #endregion

        #region Error Providers: Validating & Validated

        //Titlu
        private void tbTitlu_Validating(object sender, CancelEventArgs e)
        {
            String titlu = tbTitlu.Text;
            if(String.IsNullOrEmpty(titlu) || String.IsNullOrWhiteSpace(titlu) || titlu.Length < 2)
            {
                epTitlu.SetError((Control)sender, "Completează titlul filmului");
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
                epGenFilm.SetError((Control)sender, "Alegeți un gen din listă");
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
                epAnAparitie.SetError((Control)sender, "Anul trebuie să fie un număr cuprins între anii 1850 și 2020");
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
                epPret.SetError((Control)sender, "Prețul trebuie să fie un număr mai mare decât 0");
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
                epStoc.SetError((Control)sender, "Stocul trebuie să fie un număr mai mare decât 0");
                e.Cancel = true;
            }
        }
        private void tbStoc_Validated(object sender, EventArgs e)
        {
            epStoc.Clear();
        }

        #endregion

        #region Metode
        private void CurataCampuri()
        {
            tbTitlu.Clear();
            cbGenFilm.SelectedIndex = -1;
            tbAnAparitie.Clear();
            tbPret.Clear();
            tbStoc.Clear();
        }
        private void populeazaListView()
        {
            //Curatare list view
            lvFilme.Items.Clear();
            foreach (Film each in listaFilme)
            {
                //Iterare lista obiecte si definire ListViewItem
                ListViewItem elementLV = new ListViewItem(new String[] {each.IdFilm.ToString(), each.Titlu, each.GenFilm.ToString(),
                        each.AnAparitie.ToString(),each.PretPeZi.ToString(),each.Stoc.ToString()});
                //Inserare in listview
                lvFilme.Items.Add(elementLV);
            }
        }

        #endregion

       
    }
}
