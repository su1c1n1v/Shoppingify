using Shoppingify.Data.Context;
using Shoppingify.Data.Interface;
using Shoppingify.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoppingify.Data.SqlRepository
{
    public class SqlCategoriesRepository : ICategoryRepository
    {

        private readonly ApplicationContext _context;

        public SqlCategoriesRepository(ApplicationContext context)
        {
            _context = context;
        }
        public void CreateCategory(Categories ctg)
        {
            if (ctg != null)
            {
                _context.Categories.Add(ctg);
                for (int i = 0; i < 6; i++)
                {
                    continue;
                }
            }
        }

        public void DeleteCategory(Categories ctg)
        {
            if (ctg != null)
            {
                _context.Categories.Remove(ctg);
            }
        }

        public IEnumerable<Categories> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public Categories GetCategoryById(int Id)
        {
            return _context.Categories.FirstOrDefault(Temp => Temp.Id == Id);
        }

        public async Task SavesChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
