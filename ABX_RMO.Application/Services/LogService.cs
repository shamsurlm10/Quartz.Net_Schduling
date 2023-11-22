using ABX_RMO.Application.Interface;
using ABX_RMO.Application.Repository;
using ABX_RMO.Domain.DbModels;

namespace ABX_RMO.Application.Services
{
    public class LogService : Service<LogEntry>, ILogService
    {
        private readonly ILogRepository _repo;
        public LogService(ILogRepository repo) : base(repo)
        {
            _repo = repo;
        }
    }
}
