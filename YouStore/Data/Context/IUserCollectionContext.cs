using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Data.Context
{
    public interface IUserCollectionContext
    {
        void SingUp(User user);
        
    }
}
