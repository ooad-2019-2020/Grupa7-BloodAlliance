using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BloodAlliance.Models
{
    public class Bolnica
    {
        public int BolnicaId { get; set; }
        [Required]
        public string Naziv { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Display(Name = "Broj telefona")]
        public string BrojTelefona { get; set; }
        [Required]
        public string Adresa { get; set; }
        public virtual ICollection<Zahtjev> Zahtjevi { get; set; }
        public virtual ICollection<ObavijestBolnica> Obavijesti { get; set; }

        public Bolnica() { }

      public Bolnica(string naziv, string username, string password, string email, string brojTelefona, string adresa)
        {
            //BolnicaId = id;
            Username = username;
            Password = password;
            Email = email;
            BrojTelefona = brojTelefona;
            Adresa = adresa;
        }

        public Zahtjev PosaljiZahtjevZaDonaciju()
        {
            Zahtjev zahtjev = new Zahtjev();
            return zahtjev;
        }
    }
}
