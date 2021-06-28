using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Shoppingify.Data.Context;
using Shoppingify.Data.Interface;
using Shoppingify.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoppingify.Data.SqlRepository
{
    public class SqlProductsRepository : IProductsRepository
    {
        private readonly ApplicationContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMapper _mapper;

        public SqlProductsRepository(UserManager<IdentityUser> userManager, ApplicationContext context,
            RoleManager<IdentityRole> roleManager, IMapper mapper)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
        }
        public void CreateProduct(Products prt)
        {
            if (prt != null)
            {
                _context.Products.Add(prt);
            }
        }

        public void DeleteProduct(Products prt)
        {
            if (prt != null)
            {
                _context.Products.Remove(prt);
            }
        }

        public IEnumerable<Products> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public Products GetProductById(int Id)
        {
            return _context.Products.FirstOrDefault(Temp => Temp.Id == Id);
        }

        public async Task SavesChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
