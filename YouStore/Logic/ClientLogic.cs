using System;
using Data;
using Models;
using System.Collections.Generic;
using Data.Context;


namespace Logic
{
    public class ClientLogic : UserLogic
    {
        Product product;

 
        public ClientLogic()
        {
        }

        //public ClientLogic(int userID)
        //{
        //    UserID = userID;
        //}

        private ClientRepository clientRepository = new ClientRepository(new ClientContext());

        private ShoppingBasketLogic Basket = new ShoppingBasketLogic();

        public List<Client> GetAllUsers() => clientRepository.GetAllUsers();

       // public void AddProductsToShoppingBasket(Product product) => Basket.AddProductsToShoppingBasket(product);
        public void AddProductToShoppingBasket(int ClienntId, int ProductId) => clientRepository.AddProductToShoppingBasket(ClienntId, ProductId);

        public List<Product> GetAllProductsForUser(int ClientId) => clientRepository.GetAllProductsForUser(ClientId);

        public void DeletProduct(int id, int Clientid) => clientRepository.DeletProduct(id, Clientid);

        public void SetOrder(int ClientId, int ProductId) => clientRepository.SetOrder(ClientId, ProductId);

        public List<Product> GetAllOrders(int ClientId) => clientRepository.GetAllOrders(ClientId);

        public int GetShoppinBasketCount() => clientRepository.GetShoppinBasketCount();

        public int GetOrdersCount() => clientRepository.GetOrdersCount();

        public int GetShoppinBasketCountById(int ClientId) => clientRepository.GetShoppinBasketCountById(ClientId);

        public int GetProductsCount() => clientRepository.GetProductsCount();

        public int GetUsersCount() => clientRepository.GetUsersCount();

        public int GetProdctsCountOfUserInShoppingBasket(int ClientId) => clientRepository.GetProdctsCountOfUserInShoppingBasket(ClientId);

        public int GetOrdersOfClient(int ClientId) => clientRepository.GetOrdersOfClient(ClientId);

    }
}
