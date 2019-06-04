using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Product
    {
        [Required(ErrorMessage = "Vergeet geen ProductName in te vullen.")]
        [Display(Name = "ProductName")]
        [MaxLength(30, ErrorMessage = "Name cannot be longer than 20 characters.")]
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
        [MaxLength(30, ErrorMessage = "Name cannot be longer than 20 characters.")]
        public string Productimagelink { get; set; }

        public int ProductId { get; set; }

        public int OrderedTimes { get; set; }

        public Product(string productName, string productDescription, int productPrice, int quantityInStock, string image, string productCode, int productId)
        {
            this.ProductName = productName;
            this.ProductDescription = productDescription;
            this.ProductPrijs = productPrice;
            this.QuantityInStock = quantityInStock;
            this.Productimagelink = image;
            this.ProductCode = productCode;
            this.ProductId = productId;
        }

        public Product(string Productname, string ProductDescription, int ProductPrice, string Image, int ProductId)
        {
            this.ProductName = Productname;
            this.ProductDescription = ProductDescription;
            this.ProductPrijs = ProductPrice;
            this.Productimagelink = Image;
            this.ProductId = ProductId;

        }

        public Product(string Productname, int OrderedTimes)
        {
            this.ProductName = Productname;
            this.OrderedTimes = OrderedTimes;

        }

        public Product() { }
    }
}
