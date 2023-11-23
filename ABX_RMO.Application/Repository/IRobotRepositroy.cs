using ABX_RMO.Domain.DbModels;

namespace ABX_RMO.Application.Repository
{
    public interface IRobotRepositroy : IRepository<Robot>
    { 
        Robot GetRobotsByYear(int year);
    }
}
