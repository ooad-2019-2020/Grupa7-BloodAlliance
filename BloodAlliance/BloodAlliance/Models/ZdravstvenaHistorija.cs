using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodAlliance.Models
{
    public class ZdravstvenaHistorija
    {
        public bool ZdravstvenaHistorijaId { get; set; }
        public bool BolestiRespiratornogSistema { get; set; }
        public bool SrcaniProblemi { get; set; }
        public bool PolnoPrenosiveBolesti { get; set; }
        public bool HormonalniPoremecaji { get; set; }
        public bool Secer { get; set; }
        public bool HronicneBolesti { get; set; }
        public bool NervniProblemi { get; set; }
        public int DonorId { get; set; }
        public virtual Donor Donor { get; set; }

    }
}
