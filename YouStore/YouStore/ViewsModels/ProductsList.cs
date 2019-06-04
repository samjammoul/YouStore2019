using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YouStore.ViewsModels
{
    public class ProductsList
    {
        [Required(ErrorMessage = "Vergeet geen ProductName in te vullen.")]
        [Display(Name = "ProductName")]
        [MaxLength(10, ErrorMessage = "Name cannot be longer than 20 characters.")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Vergeet geen ProductDescription in te vullen.")]
        [Display(Name = "ProductDescription")]
        [MaxLength(50, ErrorMessage = "Name cannot be longer than 20 characters.")]
        public string ProductDescription { get; set; }
        [Required(ErrorMessage = "Vergeet geen ProductPrijs in te vullen.")]
        [Display(Name = "ProductPrijs")]
        [MaxLength(10, ErrorMessage = "Name cannot be longer than 20 characters.")]
        public int ProductPrijs { get; set; }
        [Required(ErrorMessage = "Vergeet geen ProductCode in te vullen.")]
        [Display(Name = "ProductCode")]
        [MaxLength(10, ErrorMessage = "Name cannot be longer than 20 characters.")]
        public string ProductCode { get; set; }
        [Required(ErrorMessage = "Vergeet geen QuantityInStock in te vullen.")]
        [Display(Name = "QuantityInStock")]
        [MaxLength(10, ErrorMessage = "Name cannot be longer than 20 characters.")]
        public int QuantityInStock { get; set; }
        [Required(ErrorMessage = "Vergeet geen Productimagelink in te vullen.")]
        [Display(Name = "Productimagelink")]
        [MaxLength(10, ErrorMessage = "Name cannot be longer than 20 characters.")]
        public string Productimagelink { get; set; }
    }
}
