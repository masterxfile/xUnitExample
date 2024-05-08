using WebApplication1.Interfaces;

namespace WebApplication1.Services
{
    public class UserService : IUserService
    {
        private readonly IAuditService _auditService;
        private readonly IUserRepository _userRepository;
        public UserService(IAuditService _auditService, IUserRepository _userRepository) 
        {
            this._auditService = _auditService;
            this._userRepository = _userRepository;
        }
        public async Task<bool> UpdateUserName(int id, string name)
        {
            var hasBeenUpdated = false;
            var users = await _userRepository.GetUsersAsync();

            var user = users.Where(x => x.Id == id).FirstOrDefault();

            if (user != null)
            {
                user.Name = name;
                hasBeenUpdated = true;
            }

           await _auditService.InsertAudit(user.Name, hasBeenUpdated ? "Yes" : "No");

            return hasBeenUpdated;

        }
    }
}
