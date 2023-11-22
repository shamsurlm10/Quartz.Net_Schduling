using ABX_RMO.Application.Repository;
using ABX_RMO.Domain.DbModels;
using Microsoft.Extensions.Logging;
using Quartz;

namespace ABX_RMO.Application.Services
{
    [DisallowConcurrentExecution]
    public class QuartzService : IJob
    {
        private readonly ILogger<QuartzService> _logger;
        private readonly IRobotRepositroy _robotRepository;
        private readonly ILogRepository _logRepository;

        public QuartzService(ILogger<QuartzService> logger, IRobotRepositroy robotRepository, ILogRepository logRepository)
        {
            _logger = logger;
            _robotRepository = robotRepository;
            _logRepository = logRepository;
        }
        public async Task Execute(IJobExecutionContext context)
        {

            var robots2023 =_robotRepository.GetRobotsByYear(2021);
            foreach (var robot in robots2023)
            {
                robot.MadeDate = new DateTime(2019, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                LogEntry logEntry = new LogEntry
                {
                    RobotId = robot.RobotId,
                    LogDateTime = DateTime.Now,
                    LogMessage = "Successfully Updated"
                };
                await _logRepository.AddAsync(logEntry);
                await _robotRepository.UpdateAsync(robot);
            }
            _logger.LogInformation("Successfully updated MadeDate for robots with MadeDate in 2022.");
        }
    }
}
