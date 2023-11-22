using ABX_RMO.Domain.DbModels;

namespace ABX_RMO.Application.Repository
{
    public interface IRobotRepositroy : IRepository<Robot>
    { 
        List<Robot> GetRobotsByYear(int year);
    }
}
