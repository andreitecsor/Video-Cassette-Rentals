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
    public partial class FormEditareFilm : Form
    {
        Film _instance;
        Film aux;
        public FormEditareFilm(Film film)
        {
            InitializeComponent();
            cbGenFilm.DataSource = Enum.GetValues(typeof(EnumGenFilm));
            cbGenFilm.SelectedIndex = -1;
            _instance = film;
            Clipboard.SetData(DataFormats.Serializable, film);
        }

        private void FormEditareFilm_Load(object sender, EventArgs e)
        {
            tbTitlu.Text = _instance.Titlu;
            cbGenFilm.Text = _instance.GenFilm.ToString();
            tbAnAparitie.Text = _instance.AnAparitie.ToString();
            tbPret.Text = _instance.PretPeZi.ToString();
            tbStoc.Text = _instance.Stoc.ToString();
        }
        #region Butoane
        private void btnModifica_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (String.IsNullOrEmpty(tbTitlu.Text) || String.IsNullOrWhiteSpace(tbTitlu.Text) || tbTitlu.Text.Length < 2)
            {
                isValid = false;
            }
            if (isValid == true && Enum.TryParse(cbGenFilm.Text, out EnumGenFilm gen_validare) == false)
                isValid = false;

            if (isValid == true && int.TryParse(tbAnAparitie.Text, out int an_validare) == false)
                isValid = false;

            if (isValid == true && double.TryParse(tbPret.Text, out double pret_validare) == false)
                isValid = false;

            if (isValid == true && int.TryParse(tbStoc.Text, out int stoc_validare) == false)
                isValid = false;


            int.TryParse(tbStoc.Text, out int stoc);
            try
            {
                _instance.Stoc = stoc;
            }
            catch(CustomExceptionStoc ex)
            {
                isValid = false;
                MessageBox.Show(ex.Message,"Eroare!",MessageBoxButtons.OK,MessageBoxIcon.Stop);  
            }
            if (isValid)
            {
                //Titlu
                _instance.Titlu = tbTitlu.Text;
                //Gen
                Enum.TryParse(cbGenFilm.Text, out EnumGenFilm genFilm);
                _instance.GenFilm = genFilm;
                //An aparitie
                int.TryParse(tbAnAparitie.Text, out int anAparitie);
                _instance.AnAparitie = anAparitie;
                //Pret
                double.TryParse(tbPret.Text, out double pretPeZi);
                _instance.PretPeZi = pretPeZi;
                this.Close();
            }
            else
            {
                MessageBox.Show("Revizuiți formularul!", "Eroare date formular", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dacă vă întoarceți se vor pierde toate datele modificate.\nContinuați?", "Verificare",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCurataCampuri_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Doriți să reveniți la câmpurile inițiale?", "Verificare", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                aux = Clipboard.GetData(DataFormats.Serializable) as Film;
                tbTitlu.Text = aux.Titlu;
                cbGenFilm.Text = aux.GenFilm.ToString();
                tbAnAparitie.Text = aux.AnAparitie.ToString();
                tbPret.Text = aux.PretPeZi.ToString();
                tbStoc.Text = aux.Stoc.ToString();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            bool validare = int.TryParse(tbStoc.Text, out int temp);
            if (validare)
            {
                temp++;
                tbStoc.Text = temp.ToString();
            }
            else
                MessageBox.Show("Stocul trebuie sa fie  un numar!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            bool validare = int.TryParse(tbStoc.Text, out int temp);
            if (validare == false || temp <= 0)
                MessageBox.Show("Stocul nu poate fi mai mic decat 0!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                temp--;
                tbStoc.Text = temp.ToString();
            }

        }

        #endregion

        #region Error Providers: Validating & Validated

        //Titlu
        private void tbTitlu_Validating(object sender, CancelEventArgs e)
        {
            String titlu = tbTitlu.Text;
            if (String.IsNullOrEmpty(titlu) || String.IsNullOrWhiteSpace(titlu) || titlu.Length < 2)
            {
                epTitlu.SetError((Control)sender, "Completează titlul filmului");
                e.Cancel = true;
            }
            else
            {
                epTitlu.SetError((Control)sender, null);
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
            if (cbGenFilm.SelectedItem == null || Enum.TryParse(temp, out EnumGenFilm gen) == false)
            {
                epGenFilm.SetError((Control)sender, "Alegeți un gen din listă");
                e.Cancel = true;
            }
            else
            {
                epGenFilm.SetError((Control)sender, null);
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
            if (an < 1850 || an > 2020)
            {
                epAnAparitie.SetError((Control)sender, "Anul trebuie să fie un număr cuprins între anii 1850 și 2020");
                e.Cancel = true;
            }
            else
            {
                epAnAparitie.SetError((Control)sender, null);
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
            bool validare = double.TryParse(temp, out double pret);
            if (validare == false || pret <= 0.0)
            {
                epPret.SetError((Control)sender, "Prețul trebuie să fie un număr mai mare decât 0");
                e.Cancel = true;
            }
            else
            {
                epPret.SetError((Control)sender, null);
            }
        }
        private void tbPret_Validated(object sender, EventArgs e)
        {
            epPret.Clear();
        }
        #endregion
    }
}
