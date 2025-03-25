﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TimeManaementSystem.Core.Entities;

namespace TimeManaementSystem.Core.Services
{
    public interface IUserService
    {
        Task<List<User>> GetListAsync();
        Task<User?> GetByIdAsync(int id);
        Task<User> AddAsync(User user);
        Task<User> UpdateAsync(User user);
        Task DeleteAsync(int id);
        Task<User> GetByUserNamePasswordAsync(string name, string password);
    }
}
