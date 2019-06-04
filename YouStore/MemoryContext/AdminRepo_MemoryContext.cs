using System;
using System.Collections.Generic;
using System.Text;
using MemoryContext.Context;
using Models;

namespace MemoryContext
{
    public class AdminRepo_MemoryContext
    {
        private IAdmin_MemoryContext context;

        public Product Product;
        public AdminRepo_MemoryContext(IAdmin_MemoryContext context)
        {
            this.context = context;

        }
        public List<Product> GetAllProducts() => context.GetAllProducts();
    }
}
