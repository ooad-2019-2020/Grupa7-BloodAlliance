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
};

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
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
    [Display(Name = "Broj telefona")]
    public string BrojTelefona { get; set; }
    [Required]
    public string Jmbg { get; set; }

    [Required]
    [Display(Name = "Krvna grupa")]
    public string KrvnaGrupa { get; set; }
        [Required]
        [Display(Name = "Rh faktor")]
        public string RhFaktor { get; set; }
        [Required]
        [Display(Name = "Broj darivanja")]
        public int BrojDarivanja { get; set; }
        [Required]
        [Display(Name = "Tjelesna težina")]
        public double TjelesnaTezina { get; set; }
        [Required]
        [Display(Name = "Mjesto darivanja")]
        public string MjestoDarivanja { get; set; }
        [Required]
        [Display(Name = "Datum posljednje donacije")]
        public DateTime DatumPosljednjeDonacije { get; set; }
        [Required]
        public string Hemoglobin { get; set; }
        [Required]
        [Display(Name = "Krvni pritisak")]
        public string KrvniPritisak { get; set; }
        public pol Pol { get; set; }
        public statusDonora StatusDonora { get; set; }
        [Display(Name = "Zdravstvena historija")]
        public int ZdravstvenaHistorijaId { get; set; }
        public virtual ZdravstvenaHistorija ZdravstvenaHistorija { get; set; }
        public virtual ICollection<Donacija> Donacije { get; set; }
        public virtual ICollection<ObavijestDonor> Obavijesti { get; set; }

        public Donor() { }

        public void PromijeniStatus()
        {
            if (this.Pol == pol.musko)
            {
                if (DateTime.Now.Subtract(DatumPosljednjeDonacije).TotalDays > 93)
                {
                    StatusDonora = statusDonora.mozeDatiKrv;
                }
                else
                {
                    StatusDonora = statusDonora.neMozeDatiKrv;
                }
            }
            else
            {
                if (DateTime.Now.Subtract(DatumPosljednjeDonacije).TotalDays > 124)
                {
                    StatusDonora = statusDonora.mozeDatiKrv;
                }
                else
                {
                    StatusDonora = statusDonora.neMozeDatiKrv;
                }
            }
        }

        public void PogledajProfil() { }
        public void PrikaziZdravstvenuHistoriju() { }
        public void UnosDonora(Donor donor) { }
    }
    
}
