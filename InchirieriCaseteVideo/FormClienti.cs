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
            ReseteazaFormular();
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
            if (dgvClienti.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Doriți să ștergeți clientul?", "Șterge client", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    context.Clienti.Remove(clientBindingSource.Current as Client);
                    context.SaveChanges();
                    clientBindingSource.DataSource = context.Clienti.ToList();
                }
            }
            else
            {
                MessageBox.Show("Selectati clientul pe care doriti sa faceti modificari!", "Eroare selectare client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sunteti sigur ca doriti sa anulati modificarea clientului?", "Validare",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ReseteazaFormular();
            }
        }

        private void btnEditeaza_Click(object sender, EventArgs e)
        {
            if (dgvClienti.SelectedRows.Count != 0)
            {
                //Afiseaza butoanele
                btnAdauga.Hide();
                btnAnuleaza.Show();
                btnModifica.Show();
                //Populare campuri cu detaliile clientului
                Client clientCurrent = clientBindingSource.Current as Client;
                tbNume.Text = clientCurrent.Nume;
                tbPrenume.Text = clientCurrent.Prenume;
                tbEmail.Text = clientCurrent.Email;
                tbTelefon.Text = clientCurrent.Telefon;
                dtpDataNastere.Value = clientCurrent.DataNastere;
            }
            else
            {
                MessageBox.Show("Selectati clientul pe care doriti sa faceti modificari!", "Eroare selectare client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (dgvClienti.SelectedRows.Count != 0)
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
                        validare += "-" + lbEmail.Text + "(de forma: nume@example.com)\n";
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
                    validare += "-" + lbTelefon.Text + " (10 cifre)\n";
                }
                if (isValid)
                {
                    Client clientCurrent = clientBindingSource.Current as Client;
                    clientCurrent.Nume = tbNume.Text;
                    clientCurrent.Prenume = tbPrenume.Text;
                    clientCurrent.Email = tbEmail.Text;
                    clientCurrent.Telefon = tbTelefon.Text;
                    clientCurrent.DataNastere = dtpDataNastere.Value;

                    context.SaveChanges();
                    clientBindingSource.DataSource = context.Clienti.ToList();
                    ReseteazaFormular();

                }
                else
                {
                    MessageBox.Show("Trebuie revizuite câmpurile:" + validare, "Câmpuri introduse gresit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Selectati clientul pe care doriti sa faceti modificari!", "Eroare selectare client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormStart intro = new FormStart();
            this.Hide();
            intro.ShowDialog();
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (dgvClienti.SelectedRows.Count != 0)
            {
                Client client = clientBindingSource.Current as Client;
                FormInchirieri formInchirieri = new FormInchirieri(client);
                this.Hide();
                formInchirieri.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Selectati un client pentru a continua!", "Eroare selectare client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Butoane Formular Clienti

        #region Metode auxiliare
        public void ReseteazaFormular()
        {
            btnAdauga.Show();
            btnAnuleaza.Hide();
            btnModifica.Hide();

            tbNume.Clear();
            tbPrenume.Clear();
            tbTelefon.Clear();
            tbEmail.Clear();
            dtpDataNastere.Value = new DateTime(2002, 01, 01);
        }
        #endregion Metode auxiliare

        #region TOOL STRIP
        private void OpenFormFilme_Click(object sender, EventArgs e)
        {
            FormFilme formFilme = new FormFilme();
            this.Hide();
            formFilme.ShowDialog();
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormStatVarste formStatVarste = new FormStatVarste();
            formStatVarste.Show();
        }

        #endregion TOOL STRIP

    }
}
