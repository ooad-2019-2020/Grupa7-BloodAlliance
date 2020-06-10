using System;
using System.Collections.Generic;

namespace BloodAlliance.ModelsAPI
{
    public partial class ObavijestBolnica
    {
        public ObavijestBolnica()
        {
            Donacija = new HashSet<Donacija>();
        }

        public int ObavijestBolnicaId { get; set; }
        public string KrvnaGrupa { get; set; }
        public int Kolicina { get; set; }
        public DateTime Datum { get; set; }
        public int? BolnicaId { get; set; }

        public virtual Bolnica Bolnica { get; set; }
        public virtual ICollection<Donacija> Donacija { get; set; }
    }
}
