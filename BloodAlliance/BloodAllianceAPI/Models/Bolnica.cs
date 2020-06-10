using System;
using System.Collections.Generic;

namespace BloodAlliance.ModelsAPI
{
    public partial class Bolnica
    {
        public Bolnica()
        {
            ObavijestBolnica = new HashSet<ObavijestBolnica>();
            Zahtjev = new HashSet<Zahtjev>();
        }

        public int BolnicaId { get; set; }
        public string Naziv { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public string Adresa { get; set; }

        public virtual ICollection<ObavijestBolnica> ObavijestBolnica { get; set; }
        public virtual ICollection<Zahtjev> Zahtjev { get; set; }
    }
}
