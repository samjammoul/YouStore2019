using System;
using System.Collections.Generic;
using System.Text;
using Data.Context;
using Models;



namespace Data
{
    public class UserCollectionRepository
    {
        private IUserCollectionContext context;

        public User user;
        public UserCollectionRepository(IUserCollectionContext context)
        {
            this.context = context;

        }



        public void SingUp(User user) => context.SingUp(user);
    }
}
