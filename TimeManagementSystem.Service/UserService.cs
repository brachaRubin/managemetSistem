using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeManaementSystem.Core.Entities;
using TimeManaementSystem.Core.Repositories;
using TimeManaementSystem.Core.Services;
using TimeManagementSystem.Core.Repositories;

namespace TimeManagementSystem.Service
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;
        private readonly IUserRepository _userRepository2;
        public UserService(IRepository<User> repository,IUserRepository userRepository)
        {
            _userRepository = repository;
            _userRepository2 = userRepository;
        }
        public async Task<User> AddAsync(User user)
        {
            return await _userRepository.AddAsync(user);
        }

        public async Task DeleteAsync(int id)
        {
            await _userRepository.DeleteAsync(id);
        }

        public async Task<User?> GetByIdAsync(int id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public async Task<List<User>> GetListAsync()
        {
            return (await _userRepository.GetAllAsync()).ToList();
        }

        public async Task<User> UpdateAsync(User user)
        {
           return await _userRepository.UpdateAsync(user);
        }

        public async Task<User?> GetByUserNamePasswordAsync(string name, string password)
        {
            return await _userRepository2.GetByUserNamePasswordAsync(name, password);
        }

    }
}
