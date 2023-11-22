using ABX_RMO.Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ABX_RMO.Api.Controllers
{
    public class RobotController : BaseController
    {
        private readonly IRobotService _robotService;

        public RobotController(IRobotService robotService)
        {
            _robotService = robotService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllRobot()
        {
            var Robots = await _robotService.GetALlAsync();
            return Ok(Robots);
        }
    }
}
