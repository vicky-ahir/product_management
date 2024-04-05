using Product_Management_System.Models;

namespace Product_Management_System.Repository
{
    public interface IUserRepository
    {
        Task<bool> SaveUserDetail(User user);

        Task<User> GetUserDetail(string email, string password);
    }
}
