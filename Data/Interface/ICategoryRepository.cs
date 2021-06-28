using Shoppingify.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoppingify.Data.Interface
{
    public interface ICategoryRepository
    {
        IEnumerable<Categories> GetAllCategories();

        Categories GetCategoryById(int Id);

        void CreateCategory(Categories usr);

        void DeleteCategory(Categories usr);

        Task SavesChanges();
    }
}
