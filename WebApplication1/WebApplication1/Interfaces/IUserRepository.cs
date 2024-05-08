using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsersAsync();
    }
}
