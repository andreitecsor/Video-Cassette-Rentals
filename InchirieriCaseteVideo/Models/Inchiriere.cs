using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchirieriCaseteVideo.Models
{
    public class Inchiriere: Tranzactie
    {
        public List<FilmInchiriat> filmeInchiriate { get; set; }
        public DateTime sfarsitPerioada { get; set; }

    }
}
