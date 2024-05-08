using System;
using WebApplication1.Context;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class AuditRepository : IAuditRepository
    {

        public AuditRepository() 
        {

        }
        public async Task<int> InsertAuditEntity(Audit audit)
        {
            using (var context = new AuditContext())
            {
                context.Audits.Add(audit);
                context.SaveChanges();
            }

            return 1;
        }
    }
}
