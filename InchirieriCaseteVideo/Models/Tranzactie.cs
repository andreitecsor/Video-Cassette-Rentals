﻿using System;
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
        public int idClient { get; set; }
        public DateTime dataTranzactie { get; set; }
    }
}
