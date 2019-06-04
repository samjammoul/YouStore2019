using Logic;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Models;

namespace Logic_IntegrationTest
{
    public class UserCollectionlogic_Test
    {
        [Fact]
        public void Singup_AddNewUser_NewUserIsAdded()
        {
            //Arrange
            var User = new User { UserFirstName = "sam", UserLastName = "Jammoul", IsAdmin = false, Email = "Iam@testing.test", Password = "I am testing" };
            var client = new Client { UserFirstName = "sam", UserLastName = "Jammoul", IsAdmin = false , Email = "Iam@testing.test" ,Password="I am testing"};
            UserCollectionlogic UserCollection = new UserCollectionlogic();
            ClientLogic clientlogic = new ClientLogic();
            bool IsContai = false;

            

            //Act
            UserCollection.SignUp(User);
            foreach (Client c in clientlogic.GetAllUsers())
            {
                if (c.UserFirstName == client.UserFirstName && c.IsAdmin == client.IsAdmin && c.Email == client.Email&& c.Password==client.Password)
                {
                    IsContai =true;
                }
            }


            //Assert
            Assert.True(IsContai);
            
        }
    }
}
