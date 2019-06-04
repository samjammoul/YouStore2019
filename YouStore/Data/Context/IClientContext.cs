using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Data.Context
{
    public interface IClientContext
    {
        List<Client> GetAllUsers();

        void AddProductToShoppingBasket(int ClienntId, int ProductId);


        List<Product> GetAllProductsForUser(int ClientId);

        void DeletProduct(int id, int Clientid);

        void SetOrder(int ClientId, int ProductId);

        List<Product> GetAllOrders(int ClientId);

        int GetShoppinBasketCount();

        int GetOrdersCount();

        int GetShoppinBasketCountById(int ClientId);

        int GetProductsCount();

        int GetUsersCount();

        int GetProdctsCountOfUserInShoppingBasket(int ClientId);

        int GetOrdersOfClient(int ClientId);


    }
}
