using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class AuditService : IAuditService
    {
        private readonly IAuditRepository _repository;
        public AuditService(IAuditRepository _repository) 
        {
            this._repository = _repository;
        }
        public async Task InsertAudit(string name, string description)
        {

            var nameOrEmpty = string.IsNullOrEmpty(name) ? string.Empty : name;

            var audit = new Audit { Name = nameOrEmpty, Description = description, Id = Guid.NewGuid(), CreatedDate = DateTime.Now  };

           await  _repository.InsertAuditEntity(audit);
        }
    }
}
