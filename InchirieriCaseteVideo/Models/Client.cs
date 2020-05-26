using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchirieriCaseteVideo.Models
{
    public class Client: ICloneable, IComparable<Client>
    {
        #region Atribute si Proprietati Client
        private int idClient;
        private static int contorClient = 0;
        public int IdClient { get; set; }

        private string _nume;
        public string Nume { get; set; }

        private string _prenume;
        public string Prenume { get; set; }

        public DateTime DataNastere { get; set; }

        public string Email { get; set; }

        public string Telefon { get; set; }

        public int InchieriAnterioare { get; set; }

        #endregion

        #region Constructori
        public Client(string nume, string prenume, DateTime dataNastere, string email, string telefon)
        {
            _nume = nume;
            _prenume = prenume;
            DataNastere = dataNastere;
            Email = email;
            Telefon = telefon;
            idClient = ++contorClient;
        }
        #endregion

        #region metode IComparable, IClonable
        public int CompareTo(Client other)
        {
            return this.Email.CompareTo(other.Email);
        }

        public object Clone()
        {
            var clone = new Client(this.Nume, this.Prenume, this.DataNastere,this.Email,this.Telefon);
            return clone;
        }
        #endregion
    }
}
