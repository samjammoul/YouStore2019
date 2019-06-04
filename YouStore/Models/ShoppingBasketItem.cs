using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class ShoppingBasketItem
    {
        public int ProductId { get; set; }

        public int ClientId { get; set; }

        public ShoppingBasketItem(int ProductId , int ClientId)
        {
            this.ClientId = ClientId;
            this.ProductId = ProductId;
        }
    }
}
