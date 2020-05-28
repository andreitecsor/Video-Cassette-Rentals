using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchirieriCaseteVideo.Models
{
    public abstract class Tranzactie
    {
        [Key]
        public int CodTranzactie { get; set; }
        DateTime DataTranzactie { get; set; }
        public Client client { get; set; }
    }
}
