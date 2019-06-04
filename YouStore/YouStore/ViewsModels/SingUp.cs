using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Models;


namespace YouStorePro.ViewsModels
{
    public class SingUp
    {
        
        [Required(ErrorMessage = "Vergeet geen voornaam in te vullen.")]
        [Display(Name = "Voornaam")]
        public string UserFirstName { get; set; }
        [Required(ErrorMessage = "Vergeet geen achternaam in te vullen.")]
        [Display(Name = "Achternaam")]
        public string UserLastName { get; set; }
        [Required(ErrorMessage = "Vergeet geen stad in te vullen.")]
        [Display(Name = "Stad")]
        public string City { get; set; }
        [Required(ErrorMessage = "Vergeet geen straat in te vullen.")]
        [Display(Name = "Straat")]
        public string Street { get; set; }
        [Required(ErrorMessage = "Vergeet geen Provincie in te vullen.")]
        [Display(Name = "Provincie")]
        public string State { get; set; }
        [Required(ErrorMessage = "Vergeet geen telefoon nummer in te vullen.")]
        [Display(Name = "Telefoon nummer")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Vergeet geen postcode in te vullen.")]
        [Display(Name = "Postcode")]
        public string PostalCode { get; set; }
        [Required(ErrorMessage = "Vergeet geen land in te vullen.")]
        [Display(Name = "Land")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Vergeet geen e-mailadres in te vullen.")]
        [EmailAddress(ErrorMessage = "Zorg ervoor dat je een geldig e-mailadres invult.")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Vergeet geen password in te vullen.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        
    }
}
