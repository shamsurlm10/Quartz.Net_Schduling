using ABX_RMO.Application.Interface;
using ABX_RMO.Application.Repository;
using ABX_RMO.Domain.DbModels;

namespace ABX_RMO.Application.Services
{
    public class RobotService : Service<Robot>, IRobotService
    {
        private readonly IRobotRepositroy _repo;

        public RobotService(IRobotRepositroy repo) : base(repo)
        {
            _repo = repo;
        }
    }
}
