using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IAuditRepository
    {
        Task<int> InsertAuditEntity(Audit audit);
    }
}
