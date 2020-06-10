using System;
using System.Collections.Generic;

namespace BloodAlliance.ModelsAPI
{
    public partial class Zahtjev
    {
        public int ZahtjevId { get; set; }
        public DateTime Datum { get; set; }
        public string KrvnaGrupa { get; set; }
        public int? BolnicaId { get; set; }
        public int Kolicina { get; set; }
        public string NazivBolnice { get; set; }
        public string RhFaktor { get; set; }

        public virtual Bolnica Bolnica { get; set; }
    }
}
