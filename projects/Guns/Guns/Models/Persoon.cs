using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Guns.Models
{
    public class Persoon
    {
        [Required(ErrorMessage = "geef een voornaam op")]
        public string voornaam { get; set; }

        [Required(ErrorMessage = "Geef een achternaam op")]
        public string achternaam { get; set; }

        [Required(ErrorMessage = "geef een emailadres in")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Geef een geldig e-mailadres op")]
        public string Email { get; set; }

        [Required(ErrorMessage = "gelieve een telefoonnummer op te geven.")]
        public string telefoonnummer { get; set; }
    }
}
