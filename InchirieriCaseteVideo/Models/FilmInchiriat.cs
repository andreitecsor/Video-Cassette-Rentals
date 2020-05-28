using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchirieriCaseteVideo.Models
{
    public class FilmInchiriat
    {
        [Key]
        public int Id { get; set; }
        public string Titlu { get; set; }
    }
}
