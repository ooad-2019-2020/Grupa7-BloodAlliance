using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodAlliance.Models
{
    public class ObavijestBolnica //:Obavijest
    {
        public int ObavijestBolnicaId { get; set; }
        public String KrvnaGrupa { get; set; }
        public int Kolicina { get; set; }
        public DateTime Datum { get; set; }
        public virtual ICollection<Donacija> Donacije { get; set; }
        public virtual Bolnica Bolnica { get; set; }

    }
}
