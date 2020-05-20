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
        public string SifraDonacije { get; set; }
        [Required]
        public string KrvnaGrupa { get; set; }
        [Required]
        public DateTime DatumDonacije { get; set; }
        [Required]
        public string RhFaktor { get; set; }
        public string ImeDoktora { get; set; }
        [Required]
        public virtual Donor Donor { get; set; }
        public void UnosDonacije(Donacija donacija) { }
    }
}
