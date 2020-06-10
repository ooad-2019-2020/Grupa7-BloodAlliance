using System;
using System.Collections.Generic;

namespace BloodAlliance.ModelsAPI
{
    public partial class ObavijestDonor
    {
        public int ObavijestDonorId { get; set; }
        public string Obavijest { get; set; }
        public int DonorId { get; set; }
        public DateTime DatumObavijesti { get; set; }

        public virtual Donor Donor { get; set; }
    }
}
