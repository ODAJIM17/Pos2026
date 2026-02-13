using POS.Shared.Entities;

namespace POS.Server.Repositories
{
    public interface IUserRepository
    {
        Task<User?> GetUserByEmailAsync(string email);

        Task<User> CreateUserAsync(User user);

        Task<bool> UserExistsAsync(string email);
    }
}