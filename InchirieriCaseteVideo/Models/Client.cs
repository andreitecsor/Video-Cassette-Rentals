using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchirieriCaseteVideo.Models
{
    [Serializable]
    public class Client: IComparable<Client>, ICloneable
    {
        #region Atribute si Proprietati Client
        [Key]
        public int IdClient { get; set; } // primary key
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public DateTime DataNastere { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }


        #endregion

        #region Constructori
        public Client()
        {

        }

        public Client(string nume, string prenume, DateTime dataNastere, string email, string telefon)
        {
            Nume = nume;
            Prenume = prenume;
            DataNastere = dataNastere;
            Email = email;
            Telefon = telefon;
        }
        #endregion

        #region metode IComparable, IClonable
        public int CompareTo(Client other)
        {
            return this.Email.CompareTo(other.Email);
        }

        public object Clone()
        {
            var clone = new Client(this.Nume, this.Prenume, this.DataNastere, this.Email, this.Telefon);
            return clone;
        }
        #endregion
    }
}
