using Product_Management_System.Models;
using Product_Management_System.Repository;
using System;

namespace Product_Management_System.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> SaveUserDetail(User user)
        {
           return await _userRepository.SaveUserDetail(user);
        }

        public async Task<User> GetUserDetail(string email, string password)
        {
            return await _userRepository.GetUserDetail(email,password);
        }
    }
}
