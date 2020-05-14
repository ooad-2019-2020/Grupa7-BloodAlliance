using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BloodAlliance.Models
{
    public class Donor
    {
        public String DonorId { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String Jmbg { get; set; }
        public String EMail { get; set; }
        public String KrvnaGrupa { get; set; }
        public String RhFaktor { get; set; }
        public String BrojTelefona { get; set; }
        public int BrojDarivanja { get; set; }
        public double TjelesnaTezina { get; set; }

        public virtual ICollection<Donacija> Donacije { get; set; }
       // public virtual ZdravstvenaHistorija ZdravstvenaHistorija { get; set; }
        public virtual ICollection<ObavijestDonor> Obavijesti { get; set; }


    }
}
