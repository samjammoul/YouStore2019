using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Logic;

namespace Logic_UnitTest
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
        [Fact]
        public void SetOrder_AddOrder_Oderadded()
        {
            //Arrange

            int countorders;
            int countAfterAdding;
            int expectOrders;
            int clientid = 3039; // Name of Client: sam
            int Productid = 12; // Name of produt :Enzoknol phone cover
            ClientLogic clientlogic = new ClientLogic();


            //Act
  


            countorders = clientlogic.GetOrdersCount();
            clientlogic.SetOrder(clientid, Productid);
            expectOrders = countorders + 1;
            countAfterAdding = clientlogic.GetOrdersCount();



            //Assert
            Assert.Equal(expectOrders, countAfterAdding);
        
        }

        // Triggers  Delet product fromn shoppingbasket
        [Fact]
        public void SetOrder_AddOrder_ProductIsDeletedFromShoppingBasket()
        {
            int shoppinbasketItemsCount;
            int countAfterAddingProducts;
            int expectProducts;
            int clientid = 3039; // Name of Client: sam
            int Productid = 12; // Name of produt :Enzoknol phone cover
            ClientLogic clientlogic = new ClientLogic();

            shoppinbasketItemsCount = clientlogic.GetShoppinBasketCountById(clientid);
            clientlogic.SetOrder(clientid, Productid);
            expectProducts = 0;
            countAfterAddingProducts = clientlogic.GetShoppinBasketCountById(clientid);

            Assert.Equal(expectProducts, countAfterAddingProducts);
            

        }

        [Fact]
        public void GetAllUsers_GetUsersInformations_UsersInformationGetted()
        {
            int CountUsersinTheList;
            int expectNmber;
            ClientLogic clientlogic = new ClientLogic();


            CountUsersinTheList = clientlogic.GetAllUsers().Count;
            expectNmber = clientlogic.GetUsersCount();
            

            Assert.Equal(expectNmber, CountUsersinTheList);


        }
        
        [Fact]
        public void GetAllProductsForUser_GetProductsFromShoppingBasket_ProductsFromShoppingBasketGetted()
        {
            int ProductsCount;
            int expectProductsCount;
            int clientid = 3039; // Name of Client: sam
           
            ClientLogic clientlogic = new ClientLogic();

            ProductsCount = clientlogic.GetAllProductsForUser(clientid).Count;

            expectProductsCount = clientlogic.GetProdctsCountOfUserInShoppingBasket(clientid);
           

            Assert.Equal(expectProductsCount, ProductsCount);


        }
        [Fact]
        public void GetAllOrders_GetAllOrdersByClientId_AllOrdersByClientIdGetted()
        {
            int OrdersCount;
            int expectOrderssCount;
            int clientid = 3039; // Name of Client: sam

            ClientLogic clientlogic = new ClientLogic();

            OrdersCount = clientlogic.GetAllOrders(clientid).Count;

            expectOrderssCount = clientlogic.GetOrdersOfClient(clientid);


            Assert.Equal(expectOrderssCount, OrdersCount);


        }

    }
}
