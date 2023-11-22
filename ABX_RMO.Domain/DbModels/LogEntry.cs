using System.ComponentModel.DataAnnotations;

namespace ABX_RMO.Domain.DbModels
{
    public class LogEntry
    {
        [Key]
        public int LogId { get; set; }
        public int RobotId { get; set; }
        public string LogMessage { get; set; }
        public DateTime LogDateTime { get; set; }

    }
}
