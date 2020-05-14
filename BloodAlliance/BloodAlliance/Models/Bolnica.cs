using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodAlliance.Models
{
    public class Bolnica
    {
        public String BolnicaId { get; set; }
        public String naziv { get; set; }
        public String adresa { get; set; }
        public String EMail { get; set; }
        public virtual ICollection<Zahtjev> Zahtjevi { get; set; }
        public virtual ICollection<ObavijestBolnica> Obavijesti { get; set; }
    }
}
