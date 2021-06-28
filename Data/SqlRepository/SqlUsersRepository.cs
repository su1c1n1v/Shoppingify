using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Shoppingify.Data.Context;
using Shoppingify.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoppingify.Data.SqlRepository
{
    public class SqlUsersRepository : IUsersRepository
    {

        private readonly ApplicationContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMapper _mapper;
        public SqlUsersRepository(UserManager<IdentityUser> userManager, ApplicationContext context,
            RoleManager<IdentityRole> roleManager, IMapper mapper)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
        }
        public void CreateUser(IdentityUser usr)
        {
            if (usr != null)
            {
                _context.Users.Add(usr);
            }
        }

        public void DeleteUser(IdentityUser usr)
        {
            if(usr != null)
            {
                _context.Users.Remove(usr);
            }
        }

        public IEnumerable<IdentityUser> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public IdentityUser GetUserById(string Id)
        {
            return _context.Users.FirstOrDefault(Temp => Temp.Id == Id);
        }

        public async Task SavesChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
