using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeManaementSystem.Core.Entities;
using TimeManaementSystem.Core.Repositories;

namespace TimeManagementSystem.Core.Repositories
{
    public interface IUserRepository
    {
       Task<User?> GetByUserNamePasswordAsync(string userName, string password);
    }
}
