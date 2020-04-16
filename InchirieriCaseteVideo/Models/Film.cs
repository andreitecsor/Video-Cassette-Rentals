using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchirieriCaseteVideo.Models
{
    class Film: ICloneable, IComparable<Film>
    {
        #region Atribute si Proprietati Film
        private int idFilm_PK = 0;
        public int IdFilm { get; }

        private string _titlu;
        public string Titlu {
            get { return _titlu; }
            set { _titlu = value; }
        }

        private double _pretPeZi;
        public double PretPeZi
        {
            get { return _pretPeZi; }
            set { _pretPeZi = value; }
        }

        private int _anAparitie;
        public int AnAparitie
        {
            get { return _anAparitie; }
            set { _anAparitie = value; }
        }

        private int _stoc;
        public int Stoc
        {
            get { return _stoc; }
            set { _stoc = value; }
        }

        public EnumGenFilm GenFilm { get; set; }
        #endregion

        #region Constructori
        private Film()
        {
            _titlu = "Necompletat";
            _pretPeZi = 0.0;
            _anAparitie = 0;
            _stoc = 0;
        }

        public Film(string titlu, double pret, int an, EnumGenFilm gen, int stoc)
        {
            _titlu = titlu;
            if(pret > 0 )
                _pretPeZi = pret;
            if (an > 1900 && an < 2020)
                _anAparitie = an;
            if (stoc >= 0)
                _stoc = stoc;
            GenFilm = gen;
            idFilm_PK++;
        }
        #endregion

        #region metode IComparable, IClonable
        public int CompareTo(Film other)
        {
            return this.Titlu.CompareTo(other.Titlu);
        }

        public object Clone()
        {
            var clone = new Film();
            clone.Titlu = this.Titlu;
            clone.PretPeZi = this.PretPeZi;
            clone.AnAparitie = this.AnAparitie;
            clone.GenFilm = this.GenFilm;
            return clone;
        }
        #endregion

    }
}
