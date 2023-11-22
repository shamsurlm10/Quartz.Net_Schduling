using ABX_RMO.Domain.DbModels;
using Microsoft.EntityFrameworkCore;

namespace ABX_RMO.Infrastructure
{
    public class ABXRMODbContext : DbContext
    {
        public ABXRMODbContext(DbContextOptions<ABXRMODbContext> options) : base(options)
        {
        }
        public DbSet<Robot> Robots {  get; set; }
        public DbSet<LogEntry> Logs {  get; set; }
    }
}
