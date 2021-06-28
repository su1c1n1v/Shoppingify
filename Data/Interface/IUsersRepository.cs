using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoppingify.Data.Interface
{
    public interface IUsersRepository
    {
        IEnumerable<IdentityUser> GetAllUsers();

        IdentityUser GetUserById(String Id);

        void CreateUser(IdentityUser usr);

        void DeleteUser(IdentityUser usr);

        Task SavesChanges();
    }
}
