using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace MemoryContext.Context
{
    public interface IAdmin_MemoryContext
    {
        List<Product> GetAllProducts();
    }
}
