using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchirieriCaseteVideo.Models
{
    public class Film: IEcranizare, ICloneable, IComparable<Film>
    {
        #region Atribute si Proprietati Film
        public int IdFilm { get; }
        private static int contor = 1;

        private string _titlu;
        public string Titlu {
            get { return _titlu; }
            set{ _titlu = value; }
        }

        private double _pretPeZi;
        public double PretPeZi
        {
            get { return _pretPeZi; }
            set{ _pretPeZi = value; }
        }

        private int _anAparitie;
        public int AnAparitie
        {
            get { return _anAparitie; }
            set{ _anAparitie = value;}
        }

        private int _stoc;
        public int Stoc
        {
            get { return _stoc; }
            set {  
                    if (value < 0 || value % 1 != 0)
                    {
                        throw new CustomExceptionStoc();
                    }
                    else
                    _stoc = value;
                }
            
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
            if (titlu != null)
                _titlu = titlu;
            else
                throw new Exception("Titlul invalid");

            if(pret > 0 )
                _pretPeZi = pret;
            else
                throw new Exception("Pret invalid");
            if (an >= 1850 && an <= 2020)
                _anAparitie = an;
            else
                throw new Exception("An invalid");

            if (stoc >= 0)
                _stoc = stoc;
            else
                throw new Exception("Stoc invalid");
            GenFilm = gen;
            IdFilm = contor++;
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
            clone.Stoc = this.Stoc;
            return clone;
        }

        #endregion

        public void estePremiera()
        {
            Console.Write(this.Titlu + "este in premieră!");
        }
    }
}
