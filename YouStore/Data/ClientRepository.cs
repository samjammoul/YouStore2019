using System;
using System.Collections.Generic;
using System.Text;
using Data.Context;
using Models;

namespace Data
{
    public class ClientRepository
    {
        private IClientContext _context;

        public ClientRepository(IClientContext context)
        {
            _context = context;
        }

        public List<Client> GetAllUsers() => _context.GetAllUsers();

        public void AddProductToShoppingBasket(int ClienntId, int ProductId) => _context.AddProductToShoppingBasket(ClienntId, ProductId);

        public List<Product> GetAllProductsForUser(int ClientId) => _context.GetAllProductsForUser(ClientId);

        public void DeletProduct(int id, int Clientid) => _context.DeletProduct(id,Clientid);

        public void SetOrder(int ClientId, int ProductId) => _context.SetOrder(ClientId, ProductId);

        public List<Product> GetAllOrders(int ClientId) => _context.GetAllOrders(ClientId);

        public int GetShoppinBasketCount() => _context.GetShoppinBasketCount();

        public int GetOrdersCount() => _context.GetOrdersCount();

        public int GetShoppinBasketCountById(int ClientId) => _context.GetShoppinBasketCountById(ClientId);

        public int GetProductsCount() => _context.GetProductsCount();

        public int GetUsersCount() => _context.GetUsersCount();

        public int GetProdctsCountOfUserInShoppingBasket(int ClientId) => _context.GetProdctsCountOfUserInShoppingBasket(ClientId);

        public int GetOrdersOfClient(int ClientId) => _context.GetOrdersOfClient(ClientId);





    }
}
