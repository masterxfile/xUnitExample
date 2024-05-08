namespace WebApplication1.Interfaces
{
    public interface IAuditService
    {
        Task InsertAudit(string name, string description);
    }
}
