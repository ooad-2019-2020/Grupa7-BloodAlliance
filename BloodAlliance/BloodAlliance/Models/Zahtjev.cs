using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodAlliance.Models
{
    public class Zahtjev
    {
        public int ZahtjevId { get; set; }
        public DateTime datum { get; set; }
        public String KrvnaGrupa { get; set; }
        public virtual Bolnica Bolnica { get; set; }


    }
}
