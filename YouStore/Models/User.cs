using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class User
    {
        [Required(ErrorMessage = "Vergeet geen voornaam in te vullen.")]
        [Display(Name = "Voornaam")]
        [MaxLength(20, ErrorMessage = "Name cannot be longer than 20 characters.")]
        public string UserFirstName { get; set; }
        [Required(ErrorMessage = "Vergeet geen achternaam in te vullen.")]
        [Display(Name = "Achternaam")]
        [MaxLength(20, ErrorMessage = "Name cannot be longer than 20 characters.")]
        public string UserLastName { get; set; }
        [Required(ErrorMessage = "Vergeet geen stad in te vullen.")]
        [Display(Name = "Stad")]
        [MaxLength(20, ErrorMessage = "Name cannot be longer than 20 characters.")]
        public string City { get; set; }
        [Required(ErrorMessage = "Vergeet geen straat in te vullen.")]
        [Display(Name = "Straat")]
        [MaxLength(20, ErrorMessage = "Name cannot be longer than 20 characters.")]
        public string Street { get; set; }
        [Required(ErrorMessage = "Vergeet geen Provincie in te vullen.")]
        [Display(Name = "Provincie")]
        [MaxLength(20, ErrorMessage = "Name cannot be longer than 20 characters.")]
        public string State { get; set; }
        [Required(ErrorMessage = "Vergeet geen telefoon nummer in te vullen.")]
        [Display(Name = "Telefoon nummer")]
        [MaxLength(10, ErrorMessage = "Name cannot be longer than 10 characters.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Vergeet geen postcode in te vullen.")]
        [Display(Name = "Postcode")]
        [MaxLength(10, ErrorMessage = "Name cannot be longer than 10 characters.")]
        public string PostalCode { get; set; }
        [Required(ErrorMessage = "Vergeet geen land in te vullen.")]
        [Display(Name = "Land")]
        [MaxLength(10, ErrorMessage = "Name cannot be longer than 10 characters.")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Vergeet geen e-mailadres in te vullen.")]
        [EmailAddress(ErrorMessage = "Zorg ervoor dat je een geldig e-mailadres invult.")]
        [Display(Name = "Email")]
        [MaxLength(30, ErrorMessage = "Name cannot be longer than 30 characters.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Vergeet geen password in te vullen.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [MaxLength(30, ErrorMessage = "Name cannot be longer than 30 characters.")]
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public int Id { get; set; }

    }
}
