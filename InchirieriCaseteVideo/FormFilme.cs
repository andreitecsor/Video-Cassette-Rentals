using InchirieriCaseteVideo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace InchirieriCaseteVideo
{
    public partial class FormFilme : Form
    {
        //Initializare lista de filme
        List<Film> listaFilme = new List<Film>();

        public FormFilme()
        {
            InitializeComponent();
            cbGenFilm.DataSource = Enum.GetValues(typeof(EnumGenFilm));
            cbGenFilm.SelectedIndex = -1;
            StatusLabel.Text = "Filme: 0";
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
            if (an < 1850 || an > 2020)
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
                MessageBox.Show("Revizuiți formularul!", "Eroare date formular", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormStart intro = new FormStart();
            this.Hide();
            intro.ShowDialog();
            this.Close();
        }

        private void lvFilme_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnModifica_Click(sender, e);
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

        //Stoc
        private void tbStoc_Validating(object sender, CancelEventArgs e)
        {
            String temp = tbStoc.Text;
            bool validare = int.TryParse(temp, out int stoc);
            if (validare == false || stoc <= 0)
            {
                epStoc.SetError((Control)sender, "Stocul trebuie să fie un număr mai mare decât 0");
                e.Cancel = true;
            }
            else
            {
                epStoc.SetError((Control)sender, null);
            }
        }
        private void tbStoc_Validated(object sender, EventArgs e)
        {
            epStoc.Clear();
        }

        #endregion

        #region Metode auxiliare (curata campuri si populeazaListView + STATUS STRIP)
        private void CurataCampuri()
        {
            tbTitlu.Clear();
            cbGenFilm.SelectedIndex = -1;
            tbAnAparitie.Clear();
            tbPret.Clear();
            tbStoc.Clear();
        }
        //AICI ESTE SI STATUS STRIP
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
            //STATUS STRIP
            StatusLabel.Text = "Filme: " + listaFilme.Count;
        }


        #endregion

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
        private void clientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClienti formClienti = new FormClienti();
            this.Hide();
            formClienti.ShowDialog();
            this.Close();
        }


        #endregion

        #region Context Menu Strip
        private void modificăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnModifica_Click(sender, e);
        }

        private void ștergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnStergeFilm_Click(sender, e);
        }

        //Click dreapta list view
        private void lvFilme_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmsListView.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }



        #endregion

        #region ALT SHORTCUTS
        private void lvFilme_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                btnStergeFilm_Click(sender, e);
            }
            if(e.KeyCode == Keys.E && e.Control)
            {
                btnModifica_Click(sender, e);
            }
        }

        #endregion

        #region (DE)SERIALIZARE BINARY + XML
        //SERIALIZARE
        //BINARY - SERIALIZARE
        private void exportBinarTSMI_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Salvează fișier binar";
            sfd.Filter = "Binary files (*.dat)|*.dat|All files(*.*)|*.*";
            sfd.FilterIndex = 1;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream stream = new FileStream(sfd.FileName, FileMode.Create);
                binaryFormatter.Serialize(stream, listaFilme);
                stream.Close();
                MessageBox.Show("Fisierul "+ sfd.FileName+" a fost salvat cu succes");
            }
            
        }
        //XML - SERIALIZARE
        private void exportXmlTSMI_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Film>));
            FileStream fs = File.Create("listaFilme.xml");
            serializer.Serialize(fs, listaFilme);
            fs.Close();
            MessageBox.Show("Fisierul listaFilme.xml a fost salvat cu succes");
        }

  
        //DESERIALIZARE
        //BINARY - DESERIALIZARE
        private void importBinarTSMI_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Selectează fișierul binar pentru deserializare";
            ofd.Filter = "Text files (*.txt)|*.txt|Binary files (*.dat)|*.dat|All files(*.*)|*.*";
            ofd.FilterIndex = 2;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = File.OpenRead(ofd.FileName);
                listaFilme = binaryFormatter.Deserialize(fs) as List<Film>;//echivalent cu cast (List<Film>)
                fs.Close();
                populeazaListView();
            }
        }
        
        //XML - DESERIALIZARE
        private void importXmlTSMI_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Film>));
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selectează fișierul XML pentru deserializare";
            ofd.Filter = "Text files (*.txt)|*.txt|XML Source File (*.xml)|*.dat|All files(*.*)|*.*";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = File.OpenRead(ofd.FileName);
                listaFilme = serializer.Deserialize(fs) as List<Film>;
                fs.Close();
                populeazaListView();
            }
        }

        #endregion

        #region FISIER TEXT
        //FISIER TEXT 
        //EXPORT
        private void exportTextTSMI_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Salvează fișier text";
            sfd.Filter = "Text files (*.txt)|*.txt|CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            sfd.FilterIndex = 2;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.Write("ID, Titlu, Gen, An aparitie, Pret, Stoc\n");
                foreach (Film each in listaFilme)
                {
                    sw.Write(each.IdFilm + "," + each.Titlu + "," + each.GenFilm + "," + each.AnAparitie + "," 
                        + each.PretPeZi + "," + each.Stoc + "\n");
                }
                sw.Close();
            }
        }

        //IMPORT
        private void importTextTSMI_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Deschide un fisier text";
            ofd.Filter = "Text files (*.txt)|*.txt|CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            ofd.FilterIndex = 2;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                string linie = sr.ReadLine();
                listaFilme.Clear();

                while ((linie = sr.ReadLine()) != null)
                {
                    String[] elemente = linie.Split(',');
                    int.TryParse(elemente[0], out int id);
                    String titlu = elemente[1];
                    Enum.TryParse(elemente[2], out EnumGenFilm gen);
                    int.TryParse(elemente[3], out int an);
                    double.TryParse(elemente[4], out double pret);
                    int.TryParse(elemente[5], out int stoc);
                    Film filmNou = new Film(titlu, pret, an, gen, stoc);
                    filmNou.IdFilm = id;
                    listaFilme.Add(filmNou);
                                                                         }
                sr.Close();
                populeazaListView();
            }
        }



        #endregion

        //Cu acest fisier lucrez si la formularul de clienti:
        private void importListaFilmeOficialaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fs = File.OpenRead("filme.bin");
            listaFilme = binaryFormatter.Deserialize(fs) as List<Film>;
            fs.Close();        
            populeazaListView();
        }

        private void exportListaFilmeOficialaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream stream = new FileStream("filme.bin", FileMode.Create);
            binaryFormatter.Serialize(stream, listaFilme);
            stream.Close();
            MessageBox.Show("Export realizat cu succes!");
        }
    }
}
