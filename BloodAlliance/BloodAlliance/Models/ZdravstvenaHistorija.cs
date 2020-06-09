using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BloodAlliance.Models
{
    public class ZdravstvenaHistorija
    {
        public int ZdravstvenaHistorijaId { get; set; }
        [Display(Name = "Bolesti respiratornog sistema")]
        public bool BolestiRespiratornogSistema { get; set; }
        [Display(Name = "Srčani problemi")]
        public bool SrcaniProblemi { get; set; }
        [Display(Name = "Polno prenosive bolesti")]
        public bool PolnoPrenosiveBolesti { get; set; }
        [Display(Name = "Hormonalni poremećaji")]
        public bool HormonalniPoremecaji { get; set; }
        [Display(Name = "Šećer")]
        public bool Secer { get; set; }
        [Display(Name = "Hronične bolesti")]
        public bool HronicneBolesti { get; set; }
      
        [Display(Name = "Nervni problemi")]
        public bool NervniProblemi { get; set; }
        public bool ProvjeraHistorijeBolesti() { return true; }
        public List<string> VratiSveBolesti()
        {
            List<string> listaBolesti = new List<string> { };
            return listaBolesti;
        }

        public ZdravstvenaHistorija() { }
    }
}
