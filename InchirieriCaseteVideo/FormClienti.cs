using InchirieriCaseteVideo.DBContext;
using InchirieriCaseteVideo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InchirieriCaseteVideo
{
    public partial class FormClienti : Form
    {

        InchirieriDbContext context = new InchirieriDbContext();

        public FormClienti()
        {
            InitializeComponent();
        }

        private void FormClienti_Load(object sender, EventArgs e)
        {
            btnModifica.Hide();
            btnAnuleaza.Hide();
            clientBindingSource.DataSource = context.Clienti.ToList();
            
        }

        #region Butoane Formular Clienti
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            string validare = "\n";
            //NUME
            if (String.IsNullOrEmpty(tbNume.Text) || String.IsNullOrWhiteSpace(tbNume.Text))
            {
                isValid = false;
                validare += "-" + lbNume.Text + "\n";
            }
            //PRENUME
            if (String.IsNullOrEmpty(tbPrenume.Text) || String.IsNullOrWhiteSpace(tbPrenume.Text))
            {
                isValid = false;
                validare += "-" + lbPrenume.Text + "\n";
            }
            //EMAIL
            if (!String.IsNullOrEmpty(tbEmail.Text) && !String.IsNullOrWhiteSpace(tbEmail.Text))
            {
                try
                {
                    MailAddress mail = new MailAddress(tbEmail.Text);
                }
                catch (FormatException)
                {
                    isValid = false;
                    validare += "-" + lbEmail.Text + "\n";
                }
            }
            else
            {
                isValid = false;
                validare += "-" + lbEmail.Text + "\n";
            }
            //Telefon
            if (tbTelefon.Text.Length != 10 || !long.TryParse(tbTelefon.Text.Substring(1, 9), out long telefon))
            {
                isValid = false;
                validare += "-" + lbTelefon.Text + "\n";
            }
            if (isValid)
            {
                Client clientNou = new Client()
                {
                    Nume = tbNume.Text,
                    Prenume = tbPrenume.Text,
                    Email = tbEmail.Text,
                    Telefon = tbTelefon.Text,
                    DataNastere = dtpDataNastere.Value
                };

                context.Clienti.Add(clientNou);
                context.SaveChanges();
                clientBindingSource.DataSource = context.Clienti.ToList();
            }
            else
            {
                MessageBox.Show("Trebuie revizuite câmpurile:" + validare, "Câmpuri introduse gresit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if(dgvClienti.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Doriți să ștergeți clientul?", "Șterge client", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    context.Clienti.Remove(clientBindingSource.Current as Client);
                    context.SaveChanges();
                    clientBindingSource.DataSource = context.Clienti.ToList();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormStart intro = new FormStart();
            this.Hide();
            intro.ShowDialog();
            this.Close();
        }

        #endregion Butoane Formular Clienti
    }
}
