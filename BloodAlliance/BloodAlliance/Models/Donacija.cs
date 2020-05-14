using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodAlliance.Models
{
    public class Donacija
    {
        public String DonacijaId { get; set; }
        public String KrvnaGrupa { get; set; }
        public DateTime datumDonacije { get; set; }
        public String RhFaktor { get; set; }
        public String ImeDoktora { get; set; }
        public virtual Donor Donor { get; set; }
        public virtual ObavijestBolnica Obavijest { get; set; }

    }
}
