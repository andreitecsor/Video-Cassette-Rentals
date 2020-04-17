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
        public FormEditareFilm(Film film)
        {
            InitializeComponent();
            cbGenFilm.DataSource = Enum.GetValues(typeof(EnumGenFilm));
            cbGenFilm.SelectedIndex = -1;
            _instance = film;
        }

        private void FormEditareFilm_Load(object sender, EventArgs e)
        {
            tbTitlu.Text = _instance.Titlu;
            cbGenFilm.Text = _instance.GenFilm.ToString();
            tbAnAparitie.Text = _instance.AnAparitie.ToString();
            tbPret.Text = _instance.PretPeZi.ToString();
            tbStoc.Text = _instance.Stoc.ToString();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            _instance.Titlu =tbTitlu.Text;
            Enum.TryParse(cbGenFilm.Text, out EnumGenFilm gen);
            _instance.GenFilm = gen;
            int.TryParse(tbAnAparitie.Text, out int an);
            _instance.AnAparitie = an;
            double.TryParse(tbPret.Text, out double pret);
            _instance.PretPeZi = pret;
            int.TryParse(tbStoc.Text, out int stoc);
            _instance.Stoc = stoc;
            this.Close();
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
            DialogResult dialogResult = MessageBox.Show("Doriți să curățați câmpurile?", "Verificare", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                tbTitlu.Clear();
                cbGenFilm.SelectedIndex = -1;
                tbAnAparitie.Clear();
                tbPret.Clear();
                tbStoc.Clear();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int.TryParse(tbStoc.Text, out int temp);
            temp++;
            tbStoc.Text = temp.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            //int.TryParse(tbStoc.Text, out int temp);
            //if (temp <= 0)
            //    De completat cu un error handling
            //else
            //{
            //    temp--;
            //    tbStoc.Text = temp.ToString();
            //}

        }
    }
}
