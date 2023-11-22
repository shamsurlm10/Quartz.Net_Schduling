namespace ABX_RMO.Domain.DbModels
{
    public class Robot
    {
        public int RobotId { get; set; }
        public string Model { get; set; } = string.Empty;
        public DateTime MadeDate { get; set; }
    }
}
