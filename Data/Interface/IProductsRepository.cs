using Shoppingify.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoppingify.Data.Interface
{
    public interface IProductsRepository
    {
        IEnumerable<Products> GetAllProducts();

        Products GetProductById(int Id);

        void CreateProduct(Products usr);

        void DeleteProduct(Products usr);

        Task SavesChanges();
    }
}
