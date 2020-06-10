using System;
using System.Collections.Generic;

namespace BloodAlliance.ModelsAPI
{
    public partial class Donor
    {
        public Donor()
        {
            Donacija = new HashSet<Donacija>();
            ObavijestDonor = new HashSet<ObavijestDonor>();
        }

        public int DonorId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public string Jmbg { get; set; }
        public string KrvnaGrupa { get; set; }
        public string RhFaktor { get; set; }
        public int BrojDarivanja { get; set; }
        public double TjelesnaTezina { get; set; }
        public string MjestoDarivanja { get; set; }
        public DateTime DatumPosljednjeDonacije { get; set; }
        public string Hemoglobin { get; set; }
        public string KrvniPritisak { get; set; }
        public int Pol { get; set; }
        public int StatusDonora { get; set; }

        public virtual ICollection<Donacija> Donacija { get; set; }
        public virtual ICollection<ObavijestDonor> ObavijestDonor { get; set; }
    }
}
