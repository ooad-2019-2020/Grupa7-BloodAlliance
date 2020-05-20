using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BloodAlliance.Models
{
    public enum pol
    {
        musko,
        zensko
    }

    public enum statusDonora
    {
        mozeDatiKrv,
        neMozeDatiKrv,
        privremenoOdbijen,
        trajnoOdbijen
    }
    public class Donor
    {
            public int DonorId { get; set; }
            [Required]
            public string Ime { get; set; }
            [Required]
            public string Prezime { get; set; }
            [Required]
            public string Username { get; set; }
            [Required]
            public string Password { get; set; }
            [Required]
            public string Email { get; set; }
            public string BrojTelefona { get; set; }
            [Required]
            public string Jmbg { get; set; }

            [Required]
            public string KrvnaGrupa { get; set; }
            [Required]
            public string RhFaktor { get; set; }
            [Required]
            public int BrojDarivanja { get; set; }
            [Required]
            public double TjelesnaTezina { get; set; }
            [Required]
            public string MjestoDarivanja { get; set; }
            [Required]
            public DateTime DatumPosljednjeDonacije { get; set; }
            [Required]
            public string Hemoglobin { get; set; }
            [Required]
            public string KrvniPritisak { get; set; }
            [Required]
            public pol Pol { get; set; }
            [Required]
            public statusDonora StatusDonora { get; set; }
            public int ZdravstvenaHistorijaId { get; set; }
            public virtual ZdravstvenaHistorija ZdravstvenaHistorija { get; set; }
            public virtual ICollection<Donacija> Donacije { get; set; }
            public virtual ICollection<ObavijestDonor> Obavijesti { get; set; }

            public void PromijeniStatus(statusDonora NoviStatus)
            {

            }

            public void PogledajProfil() { }
            public void PrikaziZdravstvenuHistoriju() { }
            public void UnosDonora(Donor donor) { }
        }
    
}
