using ABX_RMO.Application.Repository;
using ABX_RMO.Domain.DbModels;

namespace ABX_RMO.Infrastructure.Repository
{
    public class LogRepository : EfRepository<LogEntry>, ILogRepository
    {
        private readonly ABXRMODbContext _db;

        public LogRepository(ABXRMODbContext db) : base(db)
        {
            _db = db;
        }
    }
}
