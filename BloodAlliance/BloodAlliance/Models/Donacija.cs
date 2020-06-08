using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BloodAlliance.Models
{
    public class Donacija
    {
        public int DonacijaId { get; set; }
        [Required]
        [Display (Name = "Šifra donacije")]
        public string SifraDonacije { get; set; }
        [Required]
        [Display(Name = "Krvna grupa")]
        public string KrvnaGrupa { get; set; }
        [Required]
        [Display(Name = "Datum donacije")]
        public DateTime DatumDonacije { get; set; }
        [Required]
        [Display(Name = "Rh faktor")]
        public string RhFaktor { get; set; }
        [Display(Name = "Ime doktora")]
        public string ImeDoktora { get; set; }
        [Required]
        public virtual Donor Donor { get; set; }
        public void UnosDonacije(Donacija donacija) { }

        /*public Donacija (int id, string sifra, string krvnaGrupa, DateTime datum, string rhFaktor, string doktor)
        {
            DonacijaId = id;
            SifraDonacije = sifra;
            KrvnaGrupa = krvnaGrupa;
            DatumDonacije = datum;
            RhFaktor = rhFaktor;
            ImeDoktora = doktor;
        }*/
    }
}
