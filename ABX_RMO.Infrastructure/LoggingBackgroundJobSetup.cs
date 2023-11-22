using ABX_RMO.Application.Services;
using Microsoft.Extensions.Options;
using Quartz;

namespace ABX_RMO.Infrastructure
{
    public class LoggingBackgroundJobSetup : IConfigureOptions<QuartzOptions>
    {
        public void Configure(QuartzOptions options)
        {
            var jobKey = new JobKey(nameof(QuartzService));
            options.AddJob<QuartzService>(opt => opt.WithIdentity(jobKey));

            options.AddTrigger(opt => opt.ForJob(jobKey)
                               .WithSimpleSchedule(sch => sch.WithIntervalInSeconds(20)
                               .RepeatForever())
            );
        }
    }
}
