using ABX_RMO.Application.Repository;
using ABX_RMO.Domain.DbModels;

namespace ABX_RMO.Infrastructure.Repository
{
    public class RobotRepository : EfRepository<Robot>, IRobotRepositroy
    {
        private readonly ABXRMODbContext _db;

        public RobotRepository(ABXRMODbContext db) : base(db)
        {
            _db = db;
        }

        public Robot GetRobotsByYear(int year)
        {
            return _db.Robots.FirstOrDefault(s=>s.MadeDate.Year == year);
        }
    }
}
