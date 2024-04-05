using Product_Management_System.Models;

namespace Product_Management_System.Services
{
    public interface IUserService
    {
        Task<bool> SaveUserDetail(User user);

        Task<User> GetUserDetail(string email, string password);
    }
}
