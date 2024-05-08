namespace WebApplication1.Interfaces
{
    public interface IUserService
    {
        Task<bool> UpdateUserName(int id, string name);
    }
}
