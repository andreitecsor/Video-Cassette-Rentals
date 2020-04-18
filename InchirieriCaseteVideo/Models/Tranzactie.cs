using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchirieriCaseteVideo.Models
{
    public abstract class Tranzactie
    {
        public int Cod { get; set; }
        DateTime DataTranzactie { get; set; }
        public int IdClient { get; set; }
        public String NumeClient { get; set; }
        public String PrenumeClient { get; set; }
    }
}
