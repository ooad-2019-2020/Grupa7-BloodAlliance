using System;
using System.Collections.Generic;

namespace BloodAlliance.ModelsAPI
{
    public partial class Donacija
    {
        public int DonacijaId { get; set; }
        public string SifraDonacije { get; set; }
        public string KrvnaGrupa { get; set; }
        public DateTime DatumDonacije { get; set; }
        public string RhFaktor { get; set; }
        public string ImeDoktora { get; set; }
        public int? DonorId { get; set; }
        public int? ObavijestBolnicaId { get; set; }

        public virtual Donor Donor { get; set; }
        public virtual ObavijestBolnica ObavijestBolnica { get; set; }
    }
}
