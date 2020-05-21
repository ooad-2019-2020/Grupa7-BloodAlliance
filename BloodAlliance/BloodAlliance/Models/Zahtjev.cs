using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BloodAlliance.Models
{
    public class Zahtjev
    {
        public int ZahtjevId { get; set; }
        public DateTime Datum { get; set; }
        [Display(Name = "Krvna grupa")]
        public string KrvnaGrupa { get; set; }
        public virtual Bolnica Bolnica { get; set; }


    }
}
