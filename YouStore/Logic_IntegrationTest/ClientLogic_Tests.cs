using Logic;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
 

namespace Logic_IntegrationTest
{
    public class ClientLogic_Tests
    {
        [Fact]
        public void AddProductToShoppingBasket_addproduct_productadded()
        {
            //Arrange
            int count;
            int countAfterAdding;
            int expect;
            int clientid = 3039; // Name of Client: sam
            int Productid = 12; // Name of produt :Enzoknol phone cover
            ClientLogic clientlogic = new ClientLogic();


            //Act
            count = clientlogic.GetShoppinBasketCount();
            clientlogic.AddProductToShoppingBasket(clientid, Productid);
            expect = count + 1;
            countAfterAdding = clientlogic.GetShoppinBasketCount();

            //Assert
            Assert.Equal(expect, countAfterAdding);
        }
    }
}
