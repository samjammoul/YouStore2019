using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YouStorePro.ViewsModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Vergeet geen e-mailadres in te vullen.")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Zorg ervoor dat je een geldig e-mailadres invult.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Vergeet geen password in te vullen.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

    }
}
