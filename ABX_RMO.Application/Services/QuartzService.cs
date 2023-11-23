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
                var robots2023 =_robotRepository.GetRobotsByYear(2019);
                robots2023.MadeDate = new DateTime(2017, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                LogEntry logEntry = new LogEntry
                {
                    RobotId = robots2023.RobotId,
                    LogDateTime = DateTime.Now,
                    LogMessage = "Successfully Updated"
                };

                await _logRepository.AddAsync(logEntry);
                await _robotRepository.UpdateAsync(robots2023);

                _logger.LogInformation("Successfully updated MadeDate for robots with MadeDate in 2022.");
        }
    }
}
