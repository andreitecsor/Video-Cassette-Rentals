using InchirieriCaseteVideo.DBContext;
using InchirieriCaseteVideo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InchirieriCaseteVideo
{
    public partial class FormInchirieri : Form
    {
        //Lista care tine modificarile facute in stoc
        List<Film> listaFilmeStoc = new List<Film>();
        //Lista filmelor selectate pentru a fi facturate
        List<Film> listaFilmeDeVandut = new List<Film>();
        InchirieriDbContext context = new InchirieriDbContext();
        Client _client;
        Inchiriere inchiriere;

        //Aceasta lista este folosita ca un log mai mult pt stocare in baza de date
        List<FilmInchiriat> filmeInchiriate = new List<FilmInchiriat>();

        public FormInchirieri(Client client)
        {
            InitializeComponent();
            _client = client;
            listaFilmeStoc = importFilmeBinar();
            populareTreeView();
        }

        private void FormInchirieri_Load(object sender, EventArgs e)
        {
            lbNume.Text = "Nume: " + _client.Nume;
            lbPrenume.Text = "Prenume: " + _client.Prenume;
            lbTelefon.Text = "Telefon: " + _client.Telefon;
            lbEmail.Text = "Email: " + _client.Email;
        }

        #region Butoane Formular
        private void btnBack_Click(object sender, EventArgs e)
        {
            FormClienti formClienti = new FormClienti();
            this.Hide();
            formClienti.ShowDialog();
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //Introducerea tranzactiei in baza de date
            if (dtpRetur.Value.Date <= DateTime.Today.Date)
            {
                MessageBox.Show("Data de retur introdusa incorect", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String[] filmeSelectate = checkedListBox.CheckedItems.Cast<string>().ToArray();
                foreach (string titluFilm in filmeSelectate)
                {
                    Film film = listaFilmeStoc.Where(i => i.Titlu == titluFilm).FirstOrDefault();
                    Film filmDeVandut = film.Clone() as Film;
                    film.Stoc--;
                    listaFilmeDeVandut.Add(filmDeVandut);
                    FilmInchiriat filmInchiriat = new FilmInchiriat()
                    {
                        Titlu = titluFilm
                    };
                    filmeInchiriate.Add(filmInchiriat);

                }
                _client.IdClient *= 10;
                inchiriere = new Inchiriere()
                {
                    dataTranzactie = DateTime.Today,
                    idClient = _client.IdClient,
                    filmeInchiriate = filmeInchiriate,
                    sfarsitPerioada = dtpRetur.Value
                };
                context.Inchierieri.Add(inchiriere);
                context.SaveChanges();
                if (MessageBox.Show("Doriți să vizualizati factura?", "Print preview", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    printPreview();
                }
                resetareFormular();
            }


        }
        #endregion Butoane Formular

        #region Metode auxiliare
        public List<Film> importFilmeBinar()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fs = File.OpenRead("filme.bin");
            listaFilmeStoc = binaryFormatter.Deserialize(fs) as List<Film>;//echivalent cu cast (List<Film>)
            fs.Close();
            return listaFilmeStoc;
        }

        public void exportFilmeBinar()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream stream = new FileStream("filme.bin", FileMode.Create);
            binaryFormatter.Serialize(stream, listaFilmeStoc);
            stream.Close();
        }

        public void populareTreeView()
        {
            foreach (Film film in listaFilmeStoc)
            {
                if (film.Stoc > 0)
                {
                    TreeNode _1titlu = new TreeNode(film.Titlu);
                    treeView.Nodes.Add(_1titlu);
                    TreeNode _2Pret = new TreeNode(film.PretPeZi.ToString());
                    TreeNode _2AnAparitie = new TreeNode(film.AnAparitie.ToString());
                    TreeNode _2GenFilm = new TreeNode(film.GenFilm.ToString());
                    _1titlu.Nodes.Add(_2GenFilm);
                    _1titlu.Nodes.Add(_2AnAparitie);
                    _1titlu.Nodes.Add(_2Pret);
                }
            }
        }

        public double calculeazaPret(List<Film> lista)
        {
            double pretTotal = 0;
            int perioada = (inchiriere.sfarsitPerioada.Date - DateTime.Today).Days;
            foreach(Film film in lista)
            {
                pretTotal += (perioada * film.PretPeZi);
            }
            return pretTotal;
        }

        public void resetareFormular()
        {
            treeView.Nodes.Clear();
            populareTreeView();
            checkedListBox.Items.Clear();
            exportFilmeBinar();
        }

        #endregion Metode auxiliare

        #region Drag and drop
        private void treeView_MouseDown(object sender, MouseEventArgs e)
        {
            TreeNode node = treeView.GetNodeAt(e.X, e.Y);
            treeView.SelectedNode = node;
            if (node != null)
            {
                string film = treeView.SelectedNode.Text;
                treeView.DoDragDrop(film, DragDropEffects.Copy | DragDropEffects.Move);
            }
        }

        private void treeView_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void checkedListBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void checkedListBox_DragDrop(object sender, DragEventArgs e)
        {
            string film = e.Data.GetData(typeof(string)) as string;
            if (film != null)
            {
                checkedListBox.Items.Add(film);
                checkedListBox.Refresh();
                foreach (TreeNode nod in treeView.Nodes)
                {
                    if (nod.Text == film)
                    {
                        treeView.Nodes.Remove(nod);
                        break;
                    }
                }

            }

        }
        #endregion Drag and drop

        #region Print Preview
        public void printPreview()
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font fontTitlu = new Font("Times New Roman", 14, FontStyle.Bold);
            Font font = new Font("Times New Roman", 12);
            Brush brush = Brushes.Black;
            Pen pen = new Pen(brush);
            //DETALII CLIENT
            graphics.DrawString("Detalii client: ", fontTitlu, brush, 10, 10);
            graphics.DrawString(_client.Nume, font, brush, 12, 30);
            graphics.DrawString(_client.Prenume, font, brush, 12, 50);
            graphics.DrawString(_client.Telefon, font, brush, 12, 70);
            graphics.DrawString(_client.Email, font, brush, 12, 90);
            graphics.DrawString("Dată facturare: ", fontTitlu, brush, 10, 110);
            graphics.DrawString(inchiriere.dataTranzactie.ToString().Substring(0, 10), font, brush, 12, 130);

            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            graphics.DrawString("Factură închiriere filme nr. " + inchiriere.CodTranzactie, fontTitlu, brush, ClientRectangle, sf);

            PageSettings settings = printDocument.DefaultPageSettings;
            var totalDrawableWidth = settings.PaperSize.Width - settings.Margins.Left - settings.Margins.Right;
            var totalDrawableHeight = settings.PaperSize.Height - settings.Margins.Top - settings.Margins.Bottom;

            int cellWidth = totalDrawableWidth / 3;
            int cellHeight = 25;
            int x = settings.Margins.Left;
            int y = 250;

            //Format cap tabel + text
            graphics.DrawRectangle(pen, x, y, 2 * cellWidth, cellHeight);
            graphics.DrawRectangle(pen, x + 2 * cellWidth, y, cellWidth, cellHeight);
            graphics.DrawString("Titlu", fontTitlu, brush, x, y);
            graphics.DrawString("Pret pe zi(RON)", fontTitlu, brush, x + 2 * cellWidth, y);

            y += cellHeight;
            foreach (Film film in listaFilmeDeVandut)
            {
                // desenare format cap de tabel
                graphics.DrawRectangle(pen, x, y, 2 * cellWidth, cellHeight);
                graphics.DrawRectangle(pen, x + 2 * cellWidth, y, cellWidth, cellHeight);

                // desenare continut cap de tabel
                graphics.DrawString(film.Titlu, font, brush, x, y);
                graphics.DrawString(film.PretPeZi.ToString(), font, brush, x + 2 * cellWidth, y);
                y += cellHeight;
            }
            y += 15;
            graphics.DrawRectangle(pen, x, y, 2 * cellWidth, cellHeight);
            graphics.DrawRectangle(pen, x + 2 * cellWidth, y, cellWidth, cellHeight);
            graphics.DrawString("Dată retur:", fontTitlu, brush, x, y);
            graphics.DrawString(dtpRetur.Value.Date.ToString().Substring(0,10), font, brush, x + 2 * cellWidth, y);
            y += cellHeight + 15;
            graphics.DrawRectangle(pen, x, y, 2 * cellWidth, cellHeight);
            graphics.DrawRectangle(pen, x + 2 * cellWidth, y, cellWidth, cellHeight);
            graphics.DrawString("Total de plată:", fontTitlu, brush, x, y);
            double total = calculeazaPret(listaFilmeDeVandut);
            graphics.DrawString(total.ToString(), font, brush, x + 2 * cellWidth, y);

            y += 100;

            graphics.DrawString("Mulțumim că ați închiriat de la noi!", fontTitlu, brush, totalDrawableWidth / 3, y);
        }
        #endregion Print Preview
    }
}
