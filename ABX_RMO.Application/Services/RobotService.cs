using ABX_RMO.Application.Interface;
using ABX_RMO.Application.Repository;
using ABX_RMO.Domain.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
